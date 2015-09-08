using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace HTMLUtil {
    public class DownloadItems
    {
        //MemoryCache m_cache = new MemoryCache("DownloadItems", new System.Collections.Specialized.NameValueCollection() {
        //    {"CacheMemoryLimitMegabytes","10" },
        //    {"PhysicalMemoryLimitPercentage","5" },
        //    {"CacheMemoryLimitMegabytes","10" },

        //});
        //TODO: Ograniczyć rozmiar cache; lista z sortowaniem i priorytetem
        //Dictionary<string, string> m_cache = new Dictionary<string, string>();
        ObjectCache m_cache;
        HttpClient m_hc = new HttpClient();
        public DownloadItems() {
            m_cache = MemoryCache.Default; 
        }

        public async Task<string> Download(string url) {
            Uri uri = new Uri(url.ToLower());
            if (m_cache.Contains(uri.AbsoluteUri)) return (string)m_cache.Get(uri.AbsoluteUri);
            var resp = await m_hc.GetAsync(uri.AbsoluteUri);
            if (resp.IsSuccessStatusCode) {
                string body = await resp.Content.ReadAsStringAsync();
                //Jak dodał w międzyczasie to trudno
                m_cache.Add(uri.AbsoluteUri, body,DateTime.Now.AddHours(2));//2h
                return body;
            }
            return null;
        }
    }
}
