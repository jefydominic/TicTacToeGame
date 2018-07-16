using System;
using TicTacToe.Classes.Interfaces;

namespace TicTacToe.Classes
{
    //It represents a game board, allboard rules defined in this class
    public class GameBoard : IGameBoard
    {
        #region Private Variables
        //Game over flag
        bool _GameOver;

        //Who won
        char _whoWon;

        //Array of board cell
        BoardCell[][] _arrBoard;
        #endregion

        #region Constructor
        //Constructor, to initialize game board
        public GameBoard()
        {
            _arrBoard = new BoardCell[3][];

            for(int i=0;i<3; i++)
            {
                _arrBoard[i] = new BoardCell[3];

                for (int j = 0; j < 3; j++)
                {
                    _arrBoard[i][j] = new BoardCell();
                    _arrBoard[i][j].Value = ' ';//initialize with space value
                    _arrBoard[i][j].cellColor = System.Drawing.Color.White;

                    _arrBoard[i][j].CellPos = new PlayPosition(i, j);
                }
            }
        }
        #endregion

        #region Properties
        //Game over flag
        public bool GameOver
        {
            get
            {
                return _GameOver;
            }
        }
        public BoardCell[][] Values//returing complete board cells
        {
            get
            {
                return _arrBoard;
            }
        }
        //Return who won the game
        public char whoWon
        {
            get
            {
                return _whoWon;
            }
        }
        #endregion

        #region Private Methods
        //find out one missing free cell from 3 cell objects
        private BoardCell findEmptyCell(BoardCell cell1, BoardCell cell2, BoardCell cell3, char playChar)
        {
            if(cell1.Value == playChar && cell1.Value == cell2.Value & cell3.Value == ' ')
            {
                return cell3;
            }
            if (cell1.Value == playChar && cell1.Value == cell3.Value & cell2.Value == ' ')
            {
                return cell2;
            }
            if (cell2.Value == playChar && cell2.Value == cell3.Value & cell1.Value == ' ')
            {
                return cell1;
            }
            return null;
        }
        //Find next move for a play char X or O
        private PlayPosition FindNextMove(char playChar)
        {
            BoardCell cell = null;
            PlayPosition posBest = null;

            do
            {
                for (int i = 0; i < 3; i++)
                {
                    cell = findEmptyCell(_arrBoard[0][i], _arrBoard[1][i], _arrBoard[2][i], playChar);//|1 |2 |3

                    if (cell != null)
                    {
                        posBest = cell.CellPos;
                        break;
                    }
                }

                if (posBest != null)
                    break;

                cell = findEmptyCell(_arrBoard[0][0], _arrBoard[1][1], _arrBoard[2][2], playChar);//\
                if (cell != null)
                {
                    posBest = cell.CellPos;
                    break;
                }
                cell = findEmptyCell(_arrBoard[0][2], _arrBoard[1][1], _arrBoard[2][0], playChar);// /
                if (cell != null)
                {
                    posBest = cell.CellPos;
                    break;
                }

                for (int i = 0; i < 3; i++)
                {
                    cell = findEmptyCell(_arrBoard[i][0], _arrBoard[i][1], _arrBoard[i][2], playChar);//--1 --2 --3
                    if (cell != null)
                    {
                        posBest = cell.CellPos;
                        break;
                    }
                }

            } while (false);

            return posBest;
        }
        //Find out random play position
        private PlayPosition findRandomPlayPosition()
        {
            PlayPosition posBest = null;

            PlayPosition[] freepos = new PlayPosition[9];
            int nosFree = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_arrBoard[i][j].Value == ' ')
                    {
                        freepos[nosFree] = new PlayPosition();
                        freepos[nosFree].X = i;
                        freepos[nosFree].Y = j;
                        nosFree++;
                    }
                }
            }
            if (nosFree > 0)
            {
                Random rnd = new Random();

                int temp = rnd.Next(0, nosFree - 1);

                posBest = freepos[temp];
            }

            return posBest;
        }
        #endregion

        #region Public Members
        //Set character at a cell location
        public void SetAt(int x, int y, char chXO)
        {
            _arrBoard[x][y].Value = chXO;
        }
        //Clear complete board for new game
        public void clearBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _arrBoard[i][j].Value = ' ';//initialize with space or empty
                    _arrBoard[i][j].cellColor = System.Drawing.Color.White;
                }
            }

            _whoWon = ' ';
            _GameOver = false;
        }
        //Get next play position for computer type player
        public PlayPosition getNextBestPlay()
        {
            PlayPosition posBest = null;

            posBest = FindNextMove((char)PlayChars.Second);//Winning move

            if (posBest != null)
                return posBest;

            posBest = FindNextMove((char)PlayChars.First);//Defend move

            if (posBest != null)
                return posBest;

            posBest = findRandomPlayPosition();//Find a random play

            return posBest;
        }
        //Find out game is over
        public bool IsGameOver()
        {
            do
            {
                //Check vertical lines
                for (int i = 0; i < 3; i++)
                {
                    if ((_arrBoard[0][i].Value == _arrBoard[1][i].Value) && (_arrBoard[1][i].Value == _arrBoard[2][i].Value) && (_arrBoard[2][i].Value != ' ')) //|1
                    {
                        _GameOver = true;
                        _arrBoard[0][i].cellColor = System.Drawing.Color.LightBlue;
                        _arrBoard[1][i].cellColor = System.Drawing.Color.LightBlue;
                        _arrBoard[2][i].cellColor = System.Drawing.Color.LightBlue;

                        _whoWon = _arrBoard[2][i].Value;

                        break;
                    }
                }
                if (_GameOver)
                    break;

                //Check diagonal lines
                if ((_arrBoard[0][0].Value == _arrBoard[1][1].Value) && (_arrBoard[1][1].Value == _arrBoard[2][2].Value) && (_arrBoard[2][2].Value != ' '))// \
                {
                    _GameOver = true;
                    _arrBoard[0][0].cellColor = System.Drawing.Color.LightBlue;
                    _arrBoard[1][1].cellColor = System.Drawing.Color.LightBlue;
                    _arrBoard[2][2].cellColor = System.Drawing.Color.LightBlue;

                    _whoWon = _arrBoard[2][2].Value;
                    break;
                }
                else if ((_arrBoard[0][2].Value == _arrBoard[1][1].Value) && (_arrBoard[1][1].Value == _arrBoard[2][0].Value) && (_arrBoard[2][0].Value != ' '))// /
                {
                    _GameOver = true;
                    _arrBoard[0][2].cellColor = System.Drawing.Color.LightBlue;
                    _arrBoard[1][1].cellColor = System.Drawing.Color.LightBlue;
                    _arrBoard[2][0].cellColor = System.Drawing.Color.LightBlue;

                    _whoWon = _arrBoard[2][0].Value;
                    break;
                }
                //Check horizontal lines
                for (int i = 0; i < 3; i++)
                { 
                    if ((_arrBoard[i][0].Value == _arrBoard[i][1].Value) && (_arrBoard[i][1].Value == _arrBoard[i][2].Value) && (_arrBoard[i][2].Value != ' '))// --1
                    {
                        _GameOver = true;
                        _arrBoard[i][0].cellColor = System.Drawing.Color.LightBlue;
                        _arrBoard[i][1].cellColor = System.Drawing.Color.LightBlue;
                        _arrBoard[i][2].cellColor = System.Drawing.Color.LightBlue;

                        _whoWon = _arrBoard[i][2].Value;

                        break;
                    }
                    
                }
            } while (false);

            return _GameOver;
        }
        #endregion
    }
}
