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
        string pattern = "^[A-Za-z]{2,}$";


        public void Validating()
        {
            Console.WriteLine("--------------------------");
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
            if (res)
            {
                Console.WriteLine("Valid");
                return firstName;
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            return default;
        }
        public static string ValidatingLastName(string lastName)
        {
            string pattern = "^[A-Z][a-z]{2,}$";
            Regex regex = new Regex(pattern);
            bool res1 = regex.IsMatch(lastName);
            if (res1)
            {
                Console.WriteLine("Valid");
                return lastName;
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            return default;

        }
        public static string ValidatingEmailId(string email)
        {

            string emailPattern = (@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");
            Regex regex = new Regex(emailPattern);
            // for (int i = 0; i < emailInput.Length; i++)
            //{
            bool result = regex.IsMatch(email);
            if (result)
            {
                Console.WriteLine(email + " ----->Valid");
                return email;
            }
            else
            {
                Console.WriteLine(email + " ----->Invalid");
            }

            return default;
        }

        public static string ValidatingPhoneNum(string phoneNum)
        {
            string[] phoneNumInput = { "91 7852234896", " 91 9865741548", "919865795312", "91@123", "A865" };
            string phoneNumPattern = @"^[0-9]+[\s]+[0-9]{10}$";
            Regex regex = new Regex(phoneNumPattern);

            bool result = regex.IsMatch(phoneNum);
            if (result)
            {
                Console.WriteLine(phoneNum + " ----->Valid");
                return phoneNum;
            }
            else
            {
                Console.WriteLine(phoneNum + " ----->InValid");
            }
            return default;
        }


        public static string ValidatingPassWord(string password)
        {
            string[] passwordInput = { "Shalini@12", "sakAthi_32", "raksha123", "prathee" };
            string passwordPattern = @"(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?!.*[<>`])(?=[^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*[.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\][^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*$).{8,}$";

            Regex regex = new Regex(passwordPattern);

            bool result = regex.IsMatch(password);
            if (result)
            {
                Console.WriteLine(password + " ----->Valid");
                return password;
            }
            else
            {
                Console.WriteLine(password + " ----->InValid");
            }

            return default;
        }
    }
}

