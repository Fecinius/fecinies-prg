using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleShipsTwoPointOu
{
    internal class Program
    {
       
        public static char[,] FillBoard(char[,]board)
        {
            // Create a 10x10 integer array initialized to 0
            
            char letters = 'A';
            char numbers = '1';
            // Optionally initialize board values explicitly (not needed as default is 0)
            for (int i = 0; i < board.GetLength(0); i++)
            {
                
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (i==0 && j >0)
                    {
                        board[i, j] = letters; // top letters (coordinates)
                        letters++;
                    }
                    else if(j==0 && i>0)
                    {
                        board[i, j] = numbers; // side numbers (coordinates)
                        numbers++;
                    }
                    else
                    {
                        board[i, j] = '0'; // Default value for water
                    }
                    
                }

            }
            board[0,0] = '#';//not used square
            return board;
        }
        public static bool IsValidInput(string position, string orientation, int shipLength, int boardSize, Dictionary<char, int> letterToNumber)//chat GPT
        {
            if (string.IsNullOrEmpty(position) || position.Length != 2 || orientation.Length > 2)
            {
                return false; // Position is too short
            }


            int firstCoordinate = 0;
            int secondCoordinate = 0;

            for (int i = 0; i < position.Length; i++)
            {
                if (!letterToNumber.ContainsKey(position[i]) && !char.IsDigit(position[i]))
                {
                    return false;
                }
                else if (letterToNumber.ContainsKey(position[i]))
                {
                    firstCoordinate = letterToNumber[position[i]];

                }
                else if (char.IsDigit(position[i]))
                {
                    secondCoordinate = position[i] - '0';
                }


            }



            // Check if the ship fits within the board boundaries based on orientation

            if (orientation.Length > 1)
            {

                if (orientation == "R" && firstCoordinate + shipLength > boardSize)
                    return false;

                else if (orientation == "L" && firstCoordinate - shipLength < 1)
                    return false;

                else if (orientation == "U" && secondCoordinate - shipLength < 1)
                    return false;

                else if (orientation == "O" && secondCoordinate + shipLength > boardSize)
                    return false;
            }
            return true; // All checks passed
        }

        public static char[,] BoardTyper(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
            return board;
        }

        public static char[,] BoardInitialization(char[,] boardPlayer, Dictionary<char,int> letterToNumber) 
        {
            int shipNumber = 5;
            int shipLenght = shipNumber;
            Console.WriteLine("you have -1x Aircraft Carrier (size 1 x 5)\r\n- 1x Battleship (size 1 x 4)\r\n- 1x Cruiser (size 1 x 3)\r\n- 1x Submarine (size 1 x 3)\r\n- 1x Destroyer (size 1 x 2))");
            Console.WriteLine("place ur ships from biggest to smallest (in the order writen)");
            while (shipNumber > 0)
            {
                int firstCoordinate = 0;
                int secondCoordinate = 0;
                string userPlacement=" ";
                string rotation=" ";
                bool validityCheck = false;
                //while (userer)
                while(!validityCheck)
                {
                    Console.WriteLine("Write coordinates:");
                    userPlacement = Console.ReadLine().ToUpper();
                    Console.WriteLine("now set the orientation:");
                    string userRotation = Console.ReadLine().ToUpper();
                    validityCheck = IsValidInput(userPlacement, rotation, shipLenght, 10, letterToNumber);
                }
              
                
                
                for (int i = 0; i < userPlacement.Length; i++)
                {
                    char curentChar = userPlacement[i];

                    if (char.IsDigit(curentChar))
                    {
                        firstCoordinate = curentChar -'0' ;
                    }
                    else if (letterToNumber.ContainsKey(curentChar))
                    {
                        secondCoordinate = letterToNumber[curentChar];
                    }


                }
                if (rotation.Length == 1)
                {
                    if (rotation == "R")
                    {
                        for (int j = 0; j < shipLenght; j++)
                        {
                            boardPlayer[firstCoordinate , secondCoordinate  + j] = 'Q';
                        
                        }
                    }
                    else if (rotation == "L")
                    {
                        for (int j = 0; j < shipLenght; j++)
                        {
                            boardPlayer[firstCoordinate , secondCoordinate - j] = 'Q';
                        }
                    }
                    else if (rotation == "U")
                    {
                        for (int j = 0; j < shipLenght; j++)
                        {
                            boardPlayer[firstCoordinate - j, secondCoordinate ] = 'Q';
                        }
                    }
                    else if (rotation == "O")
                    {
                        for (int j = 0; j < shipLenght; j++)
                        {
                            boardPlayer[firstCoordinate +j , secondCoordinate] = 'Q';
                        }
                    }
                }
                BoardTyper(boardPlayer);
                if (shipNumber != 3) 
                {
                    shipLenght--;
                }
                
                shipNumber--;
            }
            return boardPlayer;
        }
        //public static char[,] BoardInitializationComputer(char[,] boardComputer)
        
            
        

        static void Main(string[] args)
        {
            char[,] boardPlayer = new char[11, 11];
            char[,] boardComputer = new char[11, 11];
            string lol = "l";
            Console.WriteLine(lol.Length);
            Dictionary<char, int> letterToNumber = new Dictionary<char, int>
            {
                {'A', 1},
                {'B', 2},
                {'C', 3},
                {'D', 4},
                {'E', 5},
                {'F', 6},
                {'G', 7},
                {'H', 8},
                {'I', 9},
                {'J', 10}
            };
            FillBoard(boardPlayer);
            FillBoard(boardComputer);
 

            BoardTyper(boardPlayer);
            
           
            Console.WriteLine("Time to innitialize the player board.\nWrite the coordinates of the ship, along with the orientation.For example:\n(1,B) this would place a ship on 1,B. on the second row type roation of the ship. ex R will place ship orianted to the right other direction are U(upp)L(left)O(down).\nTo point ships Horizontali,type 2 directions next to eachother (LD=left down) \n(on the boar ':' represents number 10 (i couldnt figure out any other way to make the side labels work)");
        
            BoardInitialization(boardPlayer,letterToNumber);
            Console.WriteLine("\n\nPlayers board:");
            BoardTyper(boardPlayer);

        }
    }
}
