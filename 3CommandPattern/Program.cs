

namespace _3CommandPattern
{
    internal class Program
    {
        /* Разработайте приложение для отслеживания расходов и доходов, где пользователи могут добавлять и удалять
записи с помощью команд и отменять изменения.*/
        static void Main(string[] args)
        {
            Bank pult = new Bank();
            Transaction transaction = new Transaction();
            pult.SetCommand(new TransactionCommand(transaction));
            pult.ExecuteIncome();
            pult.ExecuteExpenditure();
        }
    }
}
