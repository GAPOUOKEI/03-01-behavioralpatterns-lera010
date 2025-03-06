using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1TemplateMethod
{
    internal class Password : Validator
    {
        public override void LengthValidate(string password)
        {
            if(password.Length < 8)
                Console.WriteLine("Длина пароля меньше 8, измените его");
        }

        public override void SpecSimbolsValidate(string password)
        {
            
            if (!(password.Contains('!') || password.Contains('/') || password.Contains('.')))
                Console.WriteLine("В пароле отсутствует хотя бы один специальный символ(!, /, .)");

            var hasNumber = new Regex(@"[0-9]");
            if (!hasNumber.IsMatch(password))
            {
                Console.WriteLine("Пароль должен содержать хотя бы одну цифру");
            }
        }
    }
}
