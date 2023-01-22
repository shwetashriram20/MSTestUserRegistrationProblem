using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegisteration;

namespace TestProject1
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
            try
            {

                var actual = RegexSample.ValidatingFirstName(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
        }
        //Validating for Last Name
        [TestMethod]
        [DataRow("taeh", "taeh")]
        [DataRow("ta", null)]
        [DataRow("tae", "tae")]
        [DataRow("tae09", null)]
        public void ValidateUserLastname(string a, string expected)
        {
            try
            {
                var actual = RegexSample.ValidatingLastName(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
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
            try
            {
                var actual = RegexSample.ValidatingEmailId(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
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
            try
            {
                var actual = RegexSample.ValidatingPhoneNum(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
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
        [DataRow("shw-et@12A", null)]
        [DataRow("shwET@a", null)]

        public void ValidateUserPassword(string a, string expected)
        {
            try
            {
                var actual = RegexSample.ValidatingPassWord(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
        }
        [TestMethod]
        public void Test_Method_Object_Creation_RegexSample()
        {
            object expected = new RegexSample();
            UserRegistrationFactory factory = new UserRegistrationFactory();
            object actual = factory.CreateObjectForRegexSample("UserRegistration.RegexSample", "RegexSample");
            expected.Equals(actual);

        }
        //Test for parameterconstructor invoked using object created
        [TestMethod]
        public void Test_Method_Parameteized_Constructor()
        {
            object expected = new RegexSample("RegularExpression");
            UserRegistrationFactory factory = new UserRegistrationFactory();
            object actual = factory.CreateParameterizedConstructor("UserRegistration.RegexSample", "RegexSample", "RegularExpression");
            actual.Equals(expected);
        }

        [TestMethod]
        public void Reflection_Return_Default_Constructor_No_Constructor_Found()
        {
            string expected = "No constructor found";
            object obj = null;
            try
            {
                UserRegistrationFactory factory = new UserRegistrationFactory();
                obj = factory.CreateObjectForRegexSample("UserRegistration.RegexSample", "RegexSam");

            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
        }
        [TestMethod]
        public void Reflection_Return_Default_Constructor_No_Class_Found()
        {
            string expected = "No class found";
            object obj = null;
            try
            {
                UserRegistrationFactory factory = new UserRegistrationFactory();
                obj = factory.CreateObjectForRegexSample("UserRegistration.RegexSae", "RegexSample");

            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
        }
        [TestMethod]
        public void Reflection_Return_Parameterized_Class_Invalid()
        {
            string message = "Regular Expression";
            string expected = "No class found";
            object actual = null;
            try
            {
                UserRegistrationFactory factory = new UserRegistrationFactory();
                actual = factory.CreateParameterizedConstructor("UserRegistration.RegexSae", "RegexSample", message);

            }
            catch (CustomException actual1)
            {
                Assert.AreEqual(expected, actual1.Message);
            }
        }
        [TestMethod]
        public void Reflection_Return_Parameterized_Constructor_Invalid()
        {
            string message = "Regular Expression";
            string expected = "No constructor found";
            object actual = null;
            try
            {
                UserRegistrationFactory factory = new UserRegistrationFactory();
                actual = factory.CreateParameterizedConstructor("UserRegistration.RegexSample", "RegexSam", message);

            }
            catch (CustomException actual1)
            {
                Assert.AreEqual(expected, actual1.Message);
            }
        }



    }
}