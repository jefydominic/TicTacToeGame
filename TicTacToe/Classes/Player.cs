using TicTacToe.Classes.Interfaces;

namespace TicTacToe.Classes
{
    //This class represents normal player
    public class Player : IPlayer
    {
        //Constructor
        public Player()
        {
            Type = PlayerType.GeneralPlayer;
        }
        public Player(string name)
        {
            PlayerName = name;
            Type = PlayerType.GeneralPlayer;
        }

        //Score
        public int Score
        {
            get;
            set;
        }
        //Player type - General or Computer
        public PlayerType Type
        {
            get;
            set;
        }
        //Player name
        public string PlayerName
        {
            get;
            set;
        }
        //Find next move
        public PlayPosition GetNextMove(IGameBoard board)
        {
            return null;
        }
    }
}
