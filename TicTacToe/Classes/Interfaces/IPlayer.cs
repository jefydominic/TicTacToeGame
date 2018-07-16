using System;
using System.Collections.Generic;

namespace TicTacToe.Classes.Interfaces
{
    public enum PlayerType { GeneralPlayer = 1, Computer=2};
    //Interface of Player
    public interface IPlayer
    {
        //score
        int Score
        {
            get;
            set;
        }
        PlayerType Type//1-General player, 2-computer
        {
            get;
            set;
        }
        //Player Name
        string PlayerName 
        {
            get;
            set;
        }
        //Find out Next best move for a player
        PlayPosition GetNextMove(IGameBoard board);
    }
}
