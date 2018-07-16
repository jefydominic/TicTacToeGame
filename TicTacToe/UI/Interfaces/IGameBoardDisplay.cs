using System.Windows.Forms;

namespace TicTacToe.Classes.Interfaces
{
    //Interface for a board
    public interface IGameBoardDisplay
    {
        //Display complete board
        void displayBoard(IGameBoard board);
        //Display a cell
        void displayACell(IGameBoard board, int x, int y);
        //Get play position from control
        PlayPosition getPlayPosition(Control sender);
        //Disable a cell
        void disableACell(IGameBoard board, int x, int y);
        //Disable complete board
        void disableBoard(IGameBoard board);
        //Enable a cell
        void enableACell(IGameBoard board, int x, int y);
        //Enable complete board
        void enableBoard(IGameBoard board);
        //Display game result
        void displayResult(GameResult result);

    }
}
