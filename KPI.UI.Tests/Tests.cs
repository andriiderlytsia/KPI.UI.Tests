using HtmlAgilityPack;
using NUnit.Framework;
using System.Text;
using System.Threading.Tasks;

namespace KPI.UI.Tests
{
    public class Tests
    {
        private HtmlDocument _document;

        [SetUp]
        public void Setup()
        {
            _document = new HtmlWeb() { OverrideEncoding = Encoding.UTF8 }.Load("https://www.c-sharpcorner.com/article/pattern-matching-in-c-sharp/", "GET");
        }

        [Test]
        public void Test1()
        {
            var expected_h1 = "Introduction";

            var h2 = _document.DocumentNode.SelectSingleNode("//div[@id='div2']//h2");

            Assert.AreEqual(expected_h1, h2.InnerText.Trim());
        }

        [Test]
        public void Test2()
        {
            var expected_div = "Pattern Matching In C#";

            var div = _document.DocumentNode.SelectSingleNode("//h1[@id='ContentTitle']");

            Assert.AreEqual(expected_div, div.InnerText.Trim());
        }
    }
}