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
            TextInHTML t = new TextInHTML();
            var aw = t.getTextAndLinks(str);
            aw.Wait();
            Assert.AreEqual("foo bar baz", aw.Result.Text);

        }
        [TestMethod]
        public  void HtmlUtilDownload() {
            Task.Run(async () => {
                string url = "http://msdn.microsoft.com";
                TextInHTML d = new TextInHTML();
                var str = await d.download(url);
                var str1 = await d.download(url);
                var str2 = await d.download(url);
                Assert.AreEqual(str1, str);
            }).Wait();

        }
    }
}
