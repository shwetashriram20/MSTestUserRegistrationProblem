using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegisteration;

namespace UserRegisteration
{
    [TestClass]
    public class UnitTest1
    {
        //validation for first Name
        [TestMethod]
        [DataRow("Shweta", "Shweta")]
        [DataRow("Shw", "Shw")]
        [DataRow("s", null)]
        [DataRow("Shwt0e", null)]

        public void ValidateFirstname(string a, string expected)
        {
            var actual = RegexSample.ValidatingFirstName(a);
            Assert.AreEqual(expected, actual);

        }
    }
}
