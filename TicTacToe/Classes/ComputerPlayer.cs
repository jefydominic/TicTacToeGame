using TicTacToe.Classes.Interfaces;

namespace TicTacToe.Classes
{
    //This class is for computer type player
    //In single mode one player is computer 
    public class ComputerPlayer:IPlayer
    {
        //Constructors
        public ComputerPlayer()
        {
            Type = PlayerType.Computer;
        }
        public ComputerPlayer(string name)
        {
            PlayerName = name;
            Type = PlayerType.Computer;
        }
        //Player score
        public int Score
        {
            get;
            set;
        }
        //Player type
        public PlayerType Type
        {
            get;
            set;
        }
        //Player Name
        public string PlayerName
        {
            get;
            set;
        }
        //Find next best move of computer type player
        public PlayPosition GetNextMove(IGameBoard board)
        {
            PlayPosition pos = board.getNextBestPlay();

            return pos;
        }
    }
}
