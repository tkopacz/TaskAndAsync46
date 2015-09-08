using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HTMLUtil;

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
    }
}
