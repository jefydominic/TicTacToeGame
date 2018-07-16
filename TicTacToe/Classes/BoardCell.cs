
namespace TicTacToe.Classes
{
    //Represent a cell in Board
    public class BoardCell
    {
        //Cell value X or O
        public char Value
        {
            get;
            set;
        }
        //Cell color
        public System.Drawing.Color cellColor
        {
            get;
            set;
        }
        //Cell position in board
        public PlayPosition CellPos
        {
            get;
            set;
        }
    }
}
