using System;
using System.Collections.Generic;

namespace TicTacToe.Classes.Interfaces
{
    //Interface for game board
    public interface IGameBoard
    {
        //returing board values
        BoardCell[][] Values
        {
            get;
        }
        //Set value at a cell
        void SetAt(int x, int y, char chXO);
        //Clear complete board
        void clearBoard();
        //Find and return game over status
        bool IsGameOver(); 
        //Return who won the game
        char whoWon
        {
            get;
        }
        //find out next best play
        PlayPosition getNextBestPlay();
        bool GameOver
        {
            get;
        }
    }
}
