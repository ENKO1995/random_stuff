using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Program
    {
        public int x = 9;
        public static int y = 20;

        public static bool p1Won = false;
        public static bool p1Turn = true;
        public static bool GameEnded = false;


        public static string[] field = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static void Main(string[] args)
        {
            while (!GameEnded)
            {
                RunGame();
                //Console.ReadKey();
            }
        }
        static void RunGame()
        {
            DrawField();

            //Input
            if (p1Turn)
            {
                Console.WriteLine("\nPlayer 1 (X):   Type in the field number!");
            }
            else
            {
                Console.WriteLine("\nPlayer 2 (O):    Type in the field number!");
            }

            string input = Console.ReadLine();
            if (!CheckInput(input))
            {
                return;
            }
            int value = int.Parse(input) - 1;

            switch (input)
            {
                case "1":
                    if (p1Turn)
                    {
                        field[value] = "X";
                        p1Turn = !p1Turn;
                    }
                    else
                    {
                        field[value] = "O";
                        p1Turn = !p1Turn;
                    }
                    break;
                case "2":
                    if (p1Turn)
                    {
                        field[value] = "X";
                        p1Turn = !p1Turn;
                    }
                    else
                    {
                        field[value] = "O";
                        p1Turn = !p1Turn;
                    }
                    break;
                case "3":
                    if (p1Turn)
                    {
                        field[value] = "X";
                        p1Turn = !p1Turn;
                    }
                    else
                    {
                        field[value] = "O";
                        p1Turn = !p1Turn;
                    }
                    break;
                case "4":
                    if (p1Turn)
                    {
                        field[value] = "X";
                        p1Turn = !p1Turn;
                    }

                    else
                    {
                        field[value] = "O";
                        p1Turn = !p1Turn;
                    }
                    break;
                case "5":
                    if (p1Turn)
                    {
                        field[value] = "X";
                        p1Turn = !p1Turn;
                    }
                    else
                    {
                        field[value] = "O";
                        p1Turn = !p1Turn;
                    }
                    break;
                case "6":
                    if (p1Turn)
                    {
                        field[value] = "X";
                        p1Turn = !p1Turn;
                    }
                    else
                    {
                        field[value] = "O";
                        p1Turn = !p1Turn;
                    }
                    break;
                case "7":
                    if (p1Turn)
                    {
                        field[value] = "X";
                        p1Turn = !p1Turn;
                    }
                    else
                    {
                        field[value] = "O";
                        p1Turn = !p1Turn;
                    }
                    break;
                case "8":
                    if (p1Turn)
                    {
                        field[value] = "X";
                        p1Turn = !p1Turn;
                    }
                    else
                    {
                        field[value] = "O";
                        p1Turn = !p1Turn;
                    }
                    break;
                case "9":
                    if (p1Turn)
                    {
                        field[value] = "X";
                        p1Turn = !p1Turn;
                    }
                    else
                    {
                        field[value] = "O";
                        p1Turn = !p1Turn;
                    }
                    break;

                default:
                    break;
            }
        }

        static void DrawField()
        {
            Console.Clear();


            Console.Clear();
            //for (int i = 0; i < field.Length; i++)
            //{
            //    Console.Write($"{field[i]} ");
            //    if ((i + 1) % 3 == 0) Console.WriteLine("\n");
            //}


            Console.WriteLine($"{field[0]} |  {field[1]}  |  {field[2]}");
            Console.WriteLine($"-------------");
            Console.WriteLine($"{field[3]} |  {field[4]}  |  {field[5]} ");
            Console.WriteLine("-------------");
            Console.WriteLine($"{field[6]} |  {field[7]}  |  {field[8]} ");
        }
        static bool CheckInput(string _input)
        {
            int value;
            bool isNumeric = int.TryParse(_input, out value);

            if (!isNumeric || value < 1 || value > 9)
            {
                // input is not a number or is outside the range of 1-9
                Console.WriteLine("\n Invalid input \n Press any key to continue");
                Console.ReadKey();
                return false;
            }
            if (field[value - 1] == "X" || field[value - 1] == "O")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\n This Field is already occupied");
                Console.ReadKey();
                Console.BackgroundColor = ConsoleColor.Black;
                return false;
            }

            // input is within the range of 1-9
            return true;
        }
        static bool WinCondition(string[] _field)
        {
            // Check rows
            for (int i = 0; i <= 6; i += 3)
            {
                if (_field[i] == _field[i + 1] && _field[i + 1] == _field[i + 2])
                {
                    return true;
                }
            }

            // Check columns
            for (int i = 0; i <= 2; i++)
            {
                if (_field[i] == _field[i + 3] && _field[i + 3] == _field[i + 6])
                {
                    return true;
                }
            }

            // Check diagonals
            if (_field[0] == _field[4] && _field[4] == _field[8])
            {
                return true;
            }
            if (_field[2] == _field[4] && _field[4] == _field[6])
            {
                return true;
            }

            // No winning combination found
            return false;
        }

    }



}
