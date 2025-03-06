namespace _1TemplateMethod
{
    internal class Program
    {
        /* Напишите утилиту для проверки данных на соответствие определенным условиям, используя шаблонный метод для
реализации общего процесса проверки.*/
        static void Main(string[] args)
        {
            Login login = new Login();
            Password password = new Password();
            Email email = new Email();

            login.Validate("le1");
            password.Validate("password1");
            email.Validate("hbvhsbdf@mail.ru");
        }
    }
}
