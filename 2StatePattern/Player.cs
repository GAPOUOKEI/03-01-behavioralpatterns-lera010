using _2StatePattern.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2StatePattern
{
    internal class Player
    {

        #region StatePattern
        private IState currentState; // текущее состояние плеера
        public void Music() =>
            currentState.Music();

        public Player()
        {
            currentState = new PlayMusicState();
        }

        public void ChangeState(IState state) => currentState = state;
        #endregion

        public override string ToString()
        {
            return $"Плеер находится в состоянии {currentState}";
        }
    }
}
