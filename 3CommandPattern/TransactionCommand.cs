using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3CommandPattern
{/// <summary>
/// класс client создающий команды
/// </summary>
    internal class TransactionCommand : ICommand
    {
        Transaction transaction;
        public TransactionCommand(Transaction tran)
        {
            transaction = tran;
        }
        public void Execute()
        {
            transaction.Income();
        }
        public void Undo()
        {
            transaction.Expenditure();
        }
    }
}
