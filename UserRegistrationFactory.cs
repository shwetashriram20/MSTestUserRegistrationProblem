using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;

namespace UserRegisteration
{
    public class UserRegistrationFactory
    {
        public object CreateObjectForRegexSample(string className, string constructor)
        {
            string p = @"." + constructor + "$";
            Match result = Regex.Match(className, p);
            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type regexSampleType = assembly.GetType(className);
                    var res = Activator.CreateInstance(regexSampleType);
                    return res;
                }
                catch (Exception)
                {
                    throw new CustomException(CustomException.ExceptionType.NO_SUCH_CLASS, "No class found");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.NO_CONSTRUCTOR_FOUND, "No constructor found");
            }
        }
        public object CreateParameterizedConstructor(string classname, string constructorname, string message)
        {
            Type type = typeof(RegexSample);
            if (type.Name.Equals(classname) || type.FullName.Equals(classname))
            {
                if (type.Name.Equals(constructorname))
                {
                    ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) });
                    object objectConstructor = constructorInfo.Invoke(new object[] { message });
                    return objectConstructor;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.NO_CONSTRUCTOR_FOUND, "No constructor found");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.NO_SUCH_CLASS, "No class found");
            }

        }
    }
}

