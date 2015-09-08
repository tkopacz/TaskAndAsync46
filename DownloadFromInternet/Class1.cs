using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DownloadFromInternet
{
    public class DownloadItems
    {
        Dictionary<string, string> m_cache = new Dictionary<string, string>();
        HttpClient m_hc = new HttpClient();
        public DownloadItems() {

        }

        public async Task<string> Download(string url) {
            Uri uri = new Uri(url.ToLower());
            if (m_cache.ContainsKey(uri.AbsolutePath)) return m_cache[uri.AbsolutePath];
            var resp = await m_hc.GetAsync(uri.AbsoluteUri);
            if (resp.IsSuccessStatusCode) {
                string body = await resp.Content.ReadAsStringAsync();
                lock (m_cache) {
                    if (!m_cache.ContainsKey(uri.AbsolutePath)) m_cache.Add(uri.AbsoluteUri, body);
                    return m_cache[uri.AbsolutePath];
                }
            }
            return null;
        }
    }
}
