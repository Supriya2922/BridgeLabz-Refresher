using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logical_Programs
{
    internal class TicTacToe
    {
        public static char[] board = new char[10];
        public static char userchoice;
        public static char compchoice;
        public static void ticTacToe()
        {
            createEmptyBoard();
            choose();
            bool check = false;
            while (true)
            {
                playerTurn();
                computerTurn();
                showBoard();
                check=checkFreeSpace();
                checkWinner();
            }
        }
        private static void createEmptyBoard()
        {
            for(int i=1;i<board.Length;i++)
            {
                board[i] = ' ';
            }
        }
        private static void choose()
        {
            Console.WriteLine("Enter your choice (X/O):");
            userchoice =Convert.ToChar(Console.ReadLine());
            compchoice = (userchoice == 'X') ? 'O' : 'X';
        }
        private static void showBoard()
        {
            Console.WriteLine(board[1] + "|" + board[2] + "|" + board[3]);
            Console.WriteLine("------");
            Console.WriteLine(board[4] + "|" + board[5] + "|" + board[6]);
            Console.WriteLine("------");
            Console.WriteLine(board[7] + "|" + board[8] + "|" + board[9]);
        }
        public static void playerTurn()
        {
            bool check = checkFreeSpace();
            if (check == false) return;

            int playermove;
                while (true)
                {
                    Console.WriteLine("Choose a place[1-9]:");
                    playermove= Convert.ToInt32(Console.ReadLine());
                    if (board[playermove] == ' ')
                        break;
                }
                board[playermove] = userchoice;
            
        }
        public static bool checkFreeSpace()
        {
            bool avail = false;
            int n = 0;
            for(int i=1;i<board.Length;i++) {
                if (board[i] == ' ') {
                avail = true;
                    n++;
                }
            }
            if (avail == false){
                Console.WriteLine("Cannot make another move as Board is full");
                return avail;
               
            }
            else
            {
                Console.WriteLine(n + " free spaces/moves available");
            }
            return avail;

        }
        private static void checkWinner()
        {
            if ((board[1]==userchoice && board[2]==userchoice && board[3]==userchoice)||
                (board[4] == userchoice && board[5] == userchoice && board[6] == userchoice)||
                 (board[7] == userchoice && board[8] == userchoice && board[9] == userchoice)||
                 (board[1] == userchoice && board[5] == userchoice && board[3] == userchoice)||
                 (board[1] == userchoice && board[5] == userchoice && board[9] == userchoice)||
                 (board[1] == userchoice && board[4] == userchoice && board[7] == userchoice)||
                 (board[2] == userchoice && board[5] == userchoice && board[8] == userchoice)||
                 (board[3] == userchoice && board[6] == userchoice && board[9] == userchoice))
            {
                showBoard();
                Console.WriteLine("Congragulations !You won the game");
                Environment.Exit(0);
            }
            else if((board[1] == compchoice && board[2] == compchoice && board[3] == compchoice) ||
                (board[4] == compchoice && board[5] == compchoice && board[6] == compchoice) ||
                 (board[7] == compchoice && board[8] == compchoice && board[9] == compchoice) ||
                 (board[1] == compchoice && board[5] == compchoice && board[3] == compchoice) ||
                 (board[1] == compchoice && board[5] == compchoice && board[9] == compchoice)||
                 (board[1] == compchoice && board[4] == compchoice && board[7] == compchoice) ||
                 (board[2] == compchoice && board[5] == compchoice && board[8] == compchoice)||
                 (board[3] == compchoice && board[6] == compchoice && board[9] == compchoice)
                )
            {
                showBoard();
                Console.WriteLine("Computer won the game!Better luck next time:(");
                Environment.Exit(0);
            }
            


        }
        private static void computerTurn()
        {
            bool check = checkFreeSpace();
            if (check == false) return;
            int m;
            while (true)
            {
                Random r = new Random();
                m = r.Next(1, 10);
                if (board[m] == ' ')
                {
                    break;
                }
            }
                Console.WriteLine("Computer choose ->" + m);
                board[m] = compchoice;
            
        }

    }
}
