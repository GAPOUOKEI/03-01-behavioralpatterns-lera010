using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2StatePattern.States
{
    internal class RewindMusic : IState
    {
        public void Music()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("плеер перематывается");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public override string ToString()
        {
            return "перемотки";
        }
    }
}
