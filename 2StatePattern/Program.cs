namespace _2StatePattern
{
    internal class Program
    {
        /* Напишите приложение воспроизведения музыки, которое имеет состояния (останавливается, воспроизводится, приостановлено,
перемотка). Пользователь может управлять состоянием плеера.*/
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.WriteLine(player);
            player.Music();
            Console.WriteLine("------------------------------------");

            player.ChangeState(new States.RewindMusic());
            Console.WriteLine(player);
            player.Music();
            Console.WriteLine("------------------------------------");

            player.ChangeState(new States.PauseMusicState());
            Console.WriteLine(player);
            player.Music();
            Console.WriteLine("------------------------------------");

            player.ChangeState(new States.StopMusicState());
            Console.WriteLine(player);
            player.Music();
        }
    }
}
