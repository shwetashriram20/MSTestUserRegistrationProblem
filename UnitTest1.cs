using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegisteration;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        //validation for first Name
        [TestMethod]
        [DataRow("Shweta", "Shweta")]
        [DataRow("Shw", "Shw")]
        [DataRow("s", null)]
        [DataRow("Shwt09", null)]

        public void ValidateFirstname(string a, string expected)
        {

            var actual = RegexSample.ValidatingFirstName(a);
            Assert.AreEqual(expected, actual);
        }
        //Validating for Last Name
        [TestMethod]
        [DataRow("taeh", "taeh")]
        [DataRow("ta", null)]
        [DataRow("tae", "tae")]
        [DataRow("tae09", null)]
        public void ValidateUserLastname(string a, string expected)
        {
            var actual = RegexSample.ValidatingLastName(a);
            Assert.AreEqual(expected, actual);
        }
        //Validation for Email
        [TestMethod]
        [DataRow("abc@gmail.com", "abc@gmail.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc111@yahoo.com", "abc111@yahoo.com")]
        [DataRow("abc111@abc.com", "abc111@abc.com")]
        [DataRow("abc-100@abc.net", "abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
        [DataRow("abc@1.com", "abc@1.com")]
        [DataRow("abc@gmail.com.com", "abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com", "abc+100@gmail.com")]
        [DataRow("abc", null)]
        [DataRow("abc@.com.my", null)]
        [DataRow("abc123@.com", null)]
        [DataRow("abc123@.com.com", null)]
        [DataRow("abc()*@gmail.com", null)]
        [DataRow(".abc@abc.com", null)]
        [DataRow("abc@%*.com", null)]
        [DataRow("abc..2002@gmail.com", null)]
        [DataRow("abc.@gmail.com", null)]
        [DataRow("abc@abc@gmail.com", null)]
        [DataRow("abc@gmail.com.1a", null)]
        [DataRow("abc@gmail.com.aa.au", null)]

        public void ValidateUserEmail(string a, string expected)
        {
            var actual = RegexSample.ValidatingEmailId(a);
            Assert.AreEqual(expected, actual);
        }

        //Validation for Phone Number
        [TestMethod]
        [DataRow("1 1000987267", "1 1000987267")]
        [DataRow("91 9842905050", "91 9842905050")]
        [DataRow("100 9842905050", "100 9842905050")]
        [DataRow("919842905050", null)]
        [DataRow("919842905", null)]
        [DataRow("91 984290", null)]
        [DataRow("91 984290505000000", null)]
        public void ValidateUserPhoneNumber(string a, string expected)
        {
            var actual = RegexSample.ValidatingPhoneNum(a);
            Assert.AreEqual(expected, actual);
        }

        ////Validation for Password
        [TestMethod]
        [DataRow("Shwe@123", "Shwe@123")]
        [DataRow("Shwe#ta123", "Shwe#ta123")]
        [DataRow("Shw@etaa1S ", "Shw@etaa1S")]
        [DataRow("@Shwetae129", "@Shwetae129")]
        [DataRow("Shw-eta123", "Shw-eta123")]
        [DataRow("shweta123)@1234", null)]
        [DataRow("Shw@eta", null)]
        [DataRow("shw123", null)]
        [DataRow("shw@123", null)]
        [DataRow("@shw#12shw", null)]
        [DataRow(")shwe12", null)]
        [DataRow(")shwEt12", null)]
        [DataRow("shw-et@12S", null)]
        [DataRow("shwET@s", null)]

        public void ValidateUserPassword(string a, string expected)
        {
            var actual = RegexSample.ValidatingPassWord(a);
            Assert.AreEqual(expected, actual);
        }



    }
}

