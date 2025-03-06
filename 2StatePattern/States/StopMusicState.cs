using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2StatePattern.States
{
    internal class StopMusicState : IState
    {
        public void Music()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("плеер остановлен");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public override string ToString()
        {
            return "остановки";
        }
    }
}
