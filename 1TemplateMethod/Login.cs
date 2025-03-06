using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1TemplateMethod
{
    internal class Login : Validator
    {
        public override void LengthValidate(string login)
        {
            if (login.Length < 4)
                Console.WriteLine("Длина вашего логина меньше 4, измените его");

        }

        public override void SpecSimbolsValidate(string login)
        {
            var hasNumber = new Regex(@"[0-9]");
            if (!hasNumber.IsMatch(login))
            {
                Console.WriteLine("Логин должен содержать хотя бы одну цифру");
            }
        }
    }
}
