using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1TemplateMethod
{
    internal class Email : Validator
    {
        public override void LengthValidate(string email)
        {
            string[] emailstr = email.Split("@");
            if (String.IsNullOrEmpty(email))
            {
                Console.WriteLine("email не может быть пустым");
            }
            if (emailstr[0].Length < 8)
            {
                Console.WriteLine("длина до @ меньше 8");
            }
        }

        public override void SpecSimbolsValidate(string email)
        {
            string[] emailstr = email.Split("@");
            if (!(emailstr[1].Equals("mail.ru") || emailstr[1].Equals("yandex.ru") || emailstr[1].Equals("gmail.com")))
            {
                Console.WriteLine("доменное имя не содержит mail.ru или yandex.ru или gmail.com");
            }
            if (!email.Contains('@'))
            {
                Console.WriteLine("email должен содержать символ @");
            }
        }
    }
}
