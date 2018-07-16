using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Classes
{
    //Position of play
    public class PlayPosition
    {
        //Constructors
        public PlayPosition()
        {

        }
        public PlayPosition(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X
        {
            get;
            set;
        }

        public int Y
        {
            get;
            set;
        }

    }
}
