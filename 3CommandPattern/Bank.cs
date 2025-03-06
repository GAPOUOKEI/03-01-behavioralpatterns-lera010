using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _3CommandPattern
{/// <summary>
/// класс invoker то есть исполнитель
/// </summary>
    internal class Bank
    {
        ICommand command;

        public Bank() { }

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void ExecuteIncome()
        {
            command.Execute();
        }
        public void ExecuteExpenditure()
        {
            command.Undo();
        }
    }
}
