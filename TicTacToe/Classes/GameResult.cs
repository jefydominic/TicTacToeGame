using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Classes.Interfaces;

namespace TicTacToe.Classes
{
    //This object is for returning game status or result to User interface (UI)
    public class GameResult
    {
        //Constructor
        public GameResult()
        {
            WhoWon = null;
            GameOver = false;
            LastPlayedPosition = null;
        }
        //Game board data
        public IGameBoard GameBoard
        {
            get;
            set;
        }
        //who won the game
        public IPlayer WhoWon
        {
            get;
            set;
        }
        //Game over flag
        public bool GameOver
        {
            get;
            set;
        }
        //Last played position
        public PlayPosition LastPlayedPosition
        {
            get;
            set;
        }
        //Array of players
        public IPlayer[] Players
        {
            get;
            set;
        }
    }
}
