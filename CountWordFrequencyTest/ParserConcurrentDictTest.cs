using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountWordFrequency;

namespace CountWordFrequencyTest {
    [TestClass]
    public class ParserConcurrentDictTest {
        [TestInitialize]
        public void TestInit() {

        }
        [TestMethod]
        public void TestSmallCnt1() {
            ParserConcurrentDict p = new ParserConcurrentDict(TextSample.ShortText);
            p.StartProcessing(1);
            checkCountAndSum(p);
            smallCheckAssert(p);
        }
        [TestMethod]
        public void TestSmallCnt3() {
            ParserConcurrentDict p = new ParserConcurrentDict(TextSample.ShortText);
            p.StartProcessing(3);
            checkCountAndSum(p);
            smallCheckAssert(p);
        }

        [TestMethod]
        public void TestSmallCnt5() {
            ParserConcurrentDict p = new ParserConcurrentDict(TextSample.ShortText);
            p.StartProcessing(5);
            checkCountAndSum(p);
            smallCheckAssert(p);
        }
        [TestMethod]
        public void TestSmallCnt11() {
            ParserConcurrentDict p = new ParserConcurrentDict(TextSample.ShortText);
            p.StartProcessing(11);
            checkCountAndSum(p);
            smallCheckAssert(p);
        }

        [TestMethod]
        public void TestSmallCnt12() {
            ParserConcurrentDict p = new ParserConcurrentDict(TextSample.ShortText);
            p.StartProcessing(12);
            checkCountAndSum(p);
            smallCheckAssert(p);
        }

        [TestMethod]
        public void TestLarge1() {
            ParserConcurrentDict p = new ParserConcurrentDict(TextSample.LongText);
            p.StartProcessing(1);
            checkCountAndSum(p);
            largeCheckAssert(p);
        }
        [TestMethod]
        public void TestLarge2() {
            ParserConcurrentDict p = new ParserConcurrentDict(TextSample.LongText);
            p.StartProcessing(2);
            checkCountAndSum(p);
            largeCheckAssert(p);
        }
        [TestMethod]
        public void TestLarge3() {
            ParserConcurrentDict p = new ParserConcurrentDict(TextSample.LongText);
            p.StartProcessing(3);
            checkCountAndSum(p);
            largeCheckAssert(p);
        }
        [TestMethod]
        public void TestLarge10() {
            ParserConcurrentDict p = new ParserConcurrentDict(TextSample.LongText);
            p.StartProcessing(20);
            checkCountAndSum(p);
            largeCheckAssert(p);
        }
        [TestMethod]
        public void TestLarge15() {
            ParserConcurrentDict p = new ParserConcurrentDict(TextSample.LongText);
            p.StartProcessing(15);
            checkCountAndSum(p);
            largeCheckAssert(p);
        }
        [TestMethod]
        public void TestLarge5() {
            ParserConcurrentDict p = new ParserConcurrentDict(TextSample.LongText);
            p.StartProcessing(5);
            checkCountAndSum(p);
            largeCheckAssert(p);
        }
        [TestMethod]
        public void TestLarge20() {
            ParserConcurrentDict p = new ParserConcurrentDict(TextSample.LongText);
            p.StartProcessing(20);
            checkCountAndSum(p);
            largeCheckAssert(p);
        }


        /// <summary>
        /// Sprawdza czy suma policzona równa się liczbie wyrazów
        /// </summary>
        /// <param name="p"></param>
        private static void checkCountAndSum(ParserConcurrentDict p) {
            int sum = 0;
            foreach (var item in p.Count.Values) {
                sum += item;
            }
            Assert.AreEqual(p.Arr.Length, sum);
        }

        private static void smallCheckAssert(ParserConcurrentDict p) {
            Assert.AreEqual(3, p.Count["ma"]);
            Assert.AreEqual(7, p.Count.Count);
            Assert.AreEqual(1, p.Count["nie"]);
            Assert.AreEqual(2, p.Count["kot"]);
        }

        private static void largeCheckAssert(ParserConcurrentDict p) {
            Assert.AreEqual(400, p.Count["may"]);
            Assert.AreEqual(70, p.Count["hence"]);
            Assert.AreEqual(180, p.Count["within"]);
            Assert.AreEqual(130, p.Count["painting."]);
            Assert.AreEqual(3289, p.Count.Count);
            //Dla pojedynczego 
            //Assert.AreEqual(40, p.Count["may"]);
            //Assert.AreEqual(7, p.Count["hence"]);
            //Assert.AreEqual(18, p.Count["within"]);
            //Assert.AreEqual(13, p.Count["painting."]);
            //Assert.AreEqual(3289, p.Count.Count);        
        }
    }
}
