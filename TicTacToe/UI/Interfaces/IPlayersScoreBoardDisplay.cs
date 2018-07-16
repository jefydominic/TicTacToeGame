using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Classes;

namespace TicTacToe
{
    //Interface for player board display
    public interface IPlayersScoreBoardDisplay
    {
        //Set game type
        void setGameType(GameType type);
        //return players
        string[] getPlayerNames();
        //show player score
        void showGameScore(GameResult rslt);
    }
}
