using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLUtil
{
    public class TextInHTML {
        public string m_html;
        public string m_text;
        public string Text { get { return m_text; } }
        public List<string> Links { get; } = new List<string>();
        public TextInHTML(string html) {
            m_html = html;
        }

        public void Prepare() {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(m_html);
            m_text = doc.DocumentNode.InnerText;
            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]")) {
                string hrefValue = link.GetAttributeValue("href", string.Empty);
                Links.Add(hrefValue);
            }
        }

    }
}
