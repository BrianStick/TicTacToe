using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Gamers!");


            var board = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8' };
        

            char currentPlayer = 'x';
            while (true)
            {

                Console.WriteLine("{0}|{1}|{2}", board[0], board[1], board[2]);
                Console.WriteLine("-----------");
                Console.WriteLine("{0}|{1}|{2}", board[3], board[4], board[5]);
                Console.WriteLine("------------");
                Console.WriteLine("{0}|{1}|{2}", board[6], board[7], board[8]);

                Console.WriteLine($"Player {currentPlayer}, please enter a new move:");
                string userInput = Console.ReadLine();
                var move = int.Parse(userInput);
                
                //if move x is on board o cant be in the same box
                board[move] = currentPlayer;

                //check for the win
                if (board[0] == currentPlayer && board[1] == currentPlayer && board[2] == currentPlayer)
                {
                    //they won!
                    Console.WriteLine("You won!");
                    break;

                }
                if (board[3] == currentPlayer && board[4] == currentPlayer && board[5] == currentPlayer)
                {
                    //they won!
                    Console.WriteLine("You won!");
                    break;

                }
                if (board[6] == currentPlayer && board[7] == currentPlayer && board[8] == currentPlayer)
                {
                    //they won!
                    Console.WriteLine("You won!");
                    break;

                }
                if (board[0] == currentPlayer && board[3] == currentPlayer && board[6] == currentPlayer)
                {
                    //they won!
                    Console.WriteLine("You won!");
                    break;

                }
                if (board[1] == currentPlayer && board[4] == currentPlayer && board[7] == currentPlayer)
                {
                    //they won!
                    Console.WriteLine("You won!");
                    break;

                }
                if (board[2] == currentPlayer && board[5] == currentPlayer && board[8] == currentPlayer)
                {
                    //they won!
                    Console.WriteLine("You won!");
                    break;

                }
                if (board[2] == currentPlayer && board[4] == currentPlayer && board[6] == currentPlayer)
                {
                    //they won!
                    Console.WriteLine("You won!");
                    break;

                }
                if (board[0] == currentPlayer && board[4] == currentPlayer && board[8] == currentPlayer)
                {
                    //they won!
                    Console.WriteLine("You won!");
                    break;

                }



                //crap ton of if statements
                //if there is a win Break

                //check if there's no more possible moves
                //if there are no possible break;

                bool isBoardFull = true;

                foreach (var spot in board)
                {
                    if (spot != 'x' && spot != 'o')
                    {
                        isBoardFull = false;
                        break;
                    }
                }

                if (isBoardFull)
                {
                    Console.WriteLine("Game Over Tie!");
                    break;
                }




                //switch turns
                if (currentPlayer == 'x')
                {
                    currentPlayer = 'o';

                }
                else
                {
                    currentPlayer = 'x';

                }





            }

            Console.ReadLine();


        }
    }
}

