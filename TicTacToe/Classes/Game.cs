using System;
using TicTacToe.Classes.Interfaces;

namespace TicTacToe.Classes
{
    public enum PlayChars { First = 'X', Second = 'O' }//Now i am hardcoding charaters for first and second player
    //This class represnet present TicTacToe game
    public class Game: IGame
    {
        #region Private Variables
        //String Player turn like 1st or 2nd player
        PlayerNumber _playTurn;
        
        //Number of moves
        int _nosMoves;
        
        //Whoes last turn
        PlayerNumber _lastTurn;
        
        //Won player
        PlayerNumber _wonPlayer;
        
        //Game board
        IGameBoard _gameBoard;
        
        //AllPlayers
        IPlayer[] _players;

        //Game over flag
        bool _gameOver;
        #endregion

        #region Constructor
        //Constructor, game board injected from Front end
        public Game(IGameBoard gameBoard)
        {
            _nosMoves = 0;
            _playTurn = PlayerNumber.FirstPlayer;
            _lastTurn = 0;
            _wonPlayer = 0;

            if (gameBoard == null)
                throw new ArgumentNullException(nameof(gameBoard));

            _gameBoard = gameBoard;

            _players = new IPlayer[2];
        }
        #endregion

        #region Properties
        //Player count
        public int PlayerCount
        {
            get
            {
                return 2;//This game supports 2 players
            }
        }
        //Array of players
        public IPlayer[] Players
        {
            get
            {
                return _players;
            }
        }
        //Last played player
        public IPlayer LastPlayer
        {
            get
            {
                return _players[((int)_lastTurn)-1];
            }
        }
        //win player
        public IPlayer wonPlayer
        {
            get
            {
                if(_wonPlayer == 0)
                    return null;
                else
                    return _players[((int)_wonPlayer) - 1];
            }
        }
        //Game over flag
        public bool gameOver
        {
            get
            {
                return _gameOver;
            }
        }
        //Next play player number
        public PlayerNumber NextPlayer
        {
            get
            {
                return _playTurn;
            }
        }
        #endregion

        #region Private Methods

        #endregion

        #region Public Methods
        //to set players
        public void setPlayer(IPlayer player, int index)
        {
            _players[index] = player;
        }
        //Start a new game
        public void newGame()
        {
            _gameBoard.clearBoard();

            _nosMoves = 0;
            _playTurn = PlayerNumber.FirstPlayer;
            _lastTurn = 0;
            _wonPlayer = 0;
            _gameOver = false;
        }
        //Play a position
        public void Play(PlayPosition playPos)
        {
            _nosMoves++;

            _lastTurn = _playTurn;

            if (_playTurn == PlayerNumber.FirstPlayer)//First Player turn
            {
                _gameBoard.SetAt(playPos.X, playPos.Y, (char)PlayChars.First);
                _playTurn = PlayerNumber.SecondPlayer;
            }
            else if (_playTurn == PlayerNumber.SecondPlayer)//Second player turn
            {
                _gameBoard.SetAt(playPos.X, playPos.Y, (char)PlayChars.Second);
                _playTurn = PlayerNumber.FirstPlayer;
            }

            //Check game is over only after 5 play moves.
            if(_nosMoves >= 5)
            {
                if(_gameBoard.IsGameOver())
                    _gameOver = true;
            }
            
            //If game is over then update WhoWon and score
            if(_nosMoves == 9 || _gameOver)
            {
                _gameOver = true;

                if (_gameBoard.whoWon == (char)PlayChars.First)
                {
                    _wonPlayer = PlayerNumber.FirstPlayer;
                }
                else if (_gameBoard.whoWon == (char)PlayChars.Second)
                {
                    _wonPlayer = PlayerNumber.SecondPlayer;
                }

                if(_wonPlayer > 0)
                    _players[((int)_wonPlayer) - 1].Score++;
            }

        }
        //return current game board
        public IGameBoard GameBoard
        {
            get
            {
                return _gameBoard;
            }
        }
        #endregion
    }
}
