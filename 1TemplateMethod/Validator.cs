using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1TemplateMethod
{
    internal abstract class Validator
    {
        public abstract void LengthValidate(string smth);
        public abstract void SpecSimbolsValidate(string smth);
        public void Validate(string toCheck)
        {
            LengthValidate(toCheck);
            SpecSimbolsValidate(toCheck);
        }

    }
}
