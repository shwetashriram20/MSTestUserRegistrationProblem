using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegisteration
{
    public class RegexSample
    {

        public string message;
        public static string firstName;
        public static string lastName;
        public static string email;
        public static string phoneNum;
        public static string paasword;
        string pattern = "^[A-Z][a-z]{2,}$";

        public RegexSample()
        {
            Console.WriteLine("Default Constructor");
        }
        public RegexSample(string message)
        {
            this.message = message;
        }
        public void Validating()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The First Name");
            Console.WriteLine("Enter the first name : ");
            string input = Console.ReadLine();
            ValidatingFirstName(input);
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The Last Name");
            Console.WriteLine("Enter the last name : ");
            string input1 = Console.ReadLine();
            ValidatingLastName(input1);
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The Email Id");
            Console.WriteLine("Enter Email Id");
            string input2 = Console.ReadLine();
            ValidatingEmailId(input2);
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The Phone Number");
            Console.WriteLine("Enter the phone number");
            string input3 = Console.ReadLine();
            ValidatingPhoneNum(input3);
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The Password");
            Console.WriteLine("Enter the password");
            string input4 = Console.ReadLine();
            ValidatingPassWord(input4);
        }
        public static string ValidatingFirstName(string firstName)
        {
            Regex regex = new Regex("^[A-Z][a-z]{2,}$");
            bool res = regex.IsMatch(firstName);
            try
            {
                if (firstName.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "First name should not be empty");
                }
                if (firstName.Equals(null))
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Last name should not be null");
                }
                if (res)
                {
                    Console.WriteLine("Valid");
                    return firstName;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "First should be valid");
                }
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
        }
        public static Func<string, string> ValidatingLastName = (lastName) =>
        {
            string pattern = "^[A-Z][a-z]{2,}$";
            Regex regex = new Regex(pattern);
            bool res1 = regex.IsMatch(lastName);
            try
            {
                if (lastName.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Last name should not be empty");
                }
                if (lastName.Equals(null))
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Last name should not be null");
                }
                if (res1)
                {
                    Console.WriteLine("Valid");
                    return lastName;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "Last name should be valid");
                }

            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
            // return default;

        };
        public static Func<string, string> ValidatingEmailId = (email) =>
        {

            string emailPattern = (@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");
            Regex regex = new Regex(emailPattern);

            bool result = regex.IsMatch(email);
            try
            {
                if (email.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Email Id should not be empty");
                }
                if (email.Equals(null))
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Email Id should not be null");
                }
                if (result)
                {
                    Console.WriteLine(email + " ----->Valid");
                    return email;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "Email Id should be valid");
                }
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }

        };

        public static Func<string, string> ValidatingPhoneNum = (phoneNum) =>
        {
            string[] phoneNumInput = { "91 7852234896", " 91 9865741548", "919865795312", "91@123", "A865" };
            string phoneNumPattern = @"^[0-9]+[\s]+[0-9]{10}$";
            Regex regex = new Regex(phoneNumPattern);

            bool result = regex.IsMatch(phoneNum);
            try
            {
                if (phoneNum.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Phone number should not be empty");
                }
                if (phoneNum.Equals(null))
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Phone number should not be null");
                }
                if (result)
                {
                    Console.WriteLine(phoneNum + " ----->Valid");
                    return phoneNum;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "Phone number should be valid");
                }
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
        };



        public static Func<string, string> ValidatingPassWord = (password) =>
        {
            string[] passwordInput = { "Radhika@12", "sumAthi_32", "Priya123", "praveena" };
            string passwordPattern = @"(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?!.*[<>`])(?=[^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*[.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\][^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*$).{8,}$";

            Regex regex = new Regex(passwordPattern);

            bool result = regex.IsMatch(password);
            try
            {
                if (password.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Password should not be empty");
                }
                if (password.Equals(null))
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Password should not be null");
                }
                if (result)
                {
                    Console.WriteLine(password + " ----->Valid");
                    return password;
                }
                else
                {

                    throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "Passwordshould be valid");
                }
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }


        };
    }
}