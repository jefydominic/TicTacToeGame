
namespace TicTacToe.Classes.Interfaces
{
    //Player Turn number
    public enum PlayerNumber { Unknown = 0, FirstPlayer = 1, SecondPlayer = 2 }

    //interface for game class
    public interface IGame
    {
        //Player count
        int PlayerCount
        {
            get;
        }
        //Return complete players
        IPlayer[] Players
        {
            get;
        }
        //return last played player
        IPlayer LastPlayer
        {
            get;
        }
        //Won player
        IPlayer wonPlayer
        {
            get;
        }
        //return game over status
        bool gameOver
        {
            get;
        }
        //Next play player number
        PlayerNumber NextPlayer
        {
            get;
        }
        //Set player objects
        void setPlayer(IPlayer player, int index);

        //Start new game
        void newGame();

        //Play a postion
        void Play(PlayPosition playPos);
        
        //Return complete game board
        IGameBoard GameBoard
        {
            get;
        }
    }
}
