
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3CommandPattern
{
    internal class Transaction
    {/// <summary>
     /// класс receiver - получатель
     /// </summary>

        public void Income()//доход
        {
            Console.WriteLine($"поступление на счет");
        }

        public void Expenditure()//расход
        {
            Console.WriteLine($"снятие со счета");
        }
    }
}
