using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Runtime.Caching;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("HTMLUtilTest")]
namespace HTMLUtil {
    public class ParseResult {
        public string Text { get; set; }
        public List<string> Links { get; } = new List<string>();
    }
    public class TextInHTML {
        //MemoryCache m_cache = new MemoryCache("DownloadItems", new System.Collections.Specialized.NameValueCollection() {
        //    {"CacheMemoryLimitMegabytes","10" },
        //    {"PhysicalMemoryLimitPercentage","5" },
        //    {"CacheMemoryLimitMegabytes","10" },

        ObjectCache m_cache;
        HttpClient m_hc = new HttpClient();

        public TextInHTML() {
            m_cache = MemoryCache.Default;
        }

        public async Task<ParseResult> Process(string url) {
            var html = await download(url);
            if (html == null) return null;
            return await getTextAndLinks(html);
        }
        internal async Task<ParseResult> getTextAndLinks(string html) {
            ParseResult result = new ParseResult();
            await Task.Run(() => {
                try {
                    HtmlDocument doc = new HtmlDocument();
                    doc.LoadHtml(html);
                    result.Text = doc.DocumentNode.InnerText;
                    var links = doc.DocumentNode.SelectNodes("//a[@href]");
                    if (links != null) {
                        foreach (HtmlNode link in links) {
                            string hrefValue = link.GetAttributeValue("href", string.Empty).ToLower();
                            if (hrefValue.StartsWith("http")) result.Links.Add(hrefValue); //lub https - uproszczenie
                        }
                    }
                } catch (Exception ex) {
                    Trace.TraceError(ex.ToString());
                }
            }).ConfigureAwait(false);
            return result;
        }
        internal async Task<string> download(string url) {
            Uri uri = new Uri(url.ToLower());
            if (m_cache.Contains(uri.AbsoluteUri)) return (string)m_cache.Get(uri.AbsoluteUri);
            bool read = false;
            int cnt = 10;
            do {
                try {
                    var resp = await m_hc.GetAsync(uri.AbsoluteUri);
                    if (resp.IsSuccessStatusCode) {
                        string body = await resp.Content.ReadAsStringAsync();
                        //Jak dodał w międzyczasie to trudno
                        m_cache.Add(uri.AbsoluteUri, body, DateTime.Now.AddHours(2));//2h
                        read = false; //Dla porządku
                        return body;
                    }
                } catch when (cnt-->0) {
                    Thread.Sleep(1000);
                } catch (Exception ex) {
                    Trace.TraceError(ex.ToString());
                }
            } while (!read);
            return null;
        }
    }
}
