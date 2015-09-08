using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HTMLUtil;
using System.Threading.Tasks;

namespace HTMLUtilTest {
    [TestClass]
    public class HtmlUtilTest {
        [TestMethod]
        public void HtmlUtilGetTextFromPage() {
            string str = "<html><body><p>foo <a href='http://www.example.com'>bar</a> baz</p></body></html>";
            TextInHTML t = new TextInHTML(str);
            t.Prepare();
            Assert.AreEqual("foo bar baz", t.Text);

        }
        [TestMethod]
        public  void HtmlUtilDownload() {
            Task.Run(async () => {
                string url = "http://msdn.microsoft.com";
                DownloadItems d = new DownloadItems();
                var str = await d.Download(url);
                var str1 = await d.Download(url);
                Assert.AreEqual(str1, str);
            }).Wait();

        }
    }
}
