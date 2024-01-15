using System;
using System.ComponentModel.Design;
using System.Diagnostics;


namespace Math_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {


            welcome(getName());
            menu();



        }
        static void menu()
        {

            Console.WriteLine("Enter a GAME number:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Division");
            Console.WriteLine("3. muliplication");
            Console.WriteLine("4. Substruction");
            Console.WriteLine("5. Random Game!");
            Console.WriteLine("6. Quit From the Game");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AdditionGame(" welcome to Addition game");
                    break;
                case "2":
                    DividionGame(" welcome to Substruction game");
                    break;
                case "3":
                    multiplicationGame("welcome to Multiplication game");
                    break;
                case "4":
                    substructionGame("welcome to Substruction game");
                    break;
                case "5":
                    CallRandom();
                    break;
                case "6":
                    Console.WriteLine("END GAME");
                    break;

                default:
                    Console.WriteLine("invalid input");
                    Environment.Exit(1);
                    break;
            }
        }


        static string getName()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            return name;
        }

        static void welcome(string name)
        {
            Console.Clear();
            Console.Title = "math game";

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("********************************************");
            Console.WriteLine($"*      Welcome {name} to " +
                                 " the MATH GAME    *");
            Console.WriteLine("********************************************");
            Console.WriteLine();

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Explore a wide range of opperations. Happy gaming!");
            Console.ResetColor();
        }

        static void AdditionGame(string msg)
        {
            Stopwatch stopwatch = new Stopwatch();

            int levelRange = Level();
            Random random = new Random();
            int score = 0;

            Console.WriteLine("enter number of rounds you want:");
            int rounds = int.Parse(Console.ReadLine());

            stopwatch.Start();

            for (int i = 0; i < rounds; i++)
            {
                Console.Clear();
                Console.WriteLine(msg);
                var numOne = random.Next(1, levelRange);
                var numTwo = random.Next(1, levelRange);

                Console.WriteLine($"{numOne} + {numTwo}");
                Console.WriteLine("Enter your nswer");
                string answer = Console.ReadLine();

                int result;
                if (int.TryParse(answer, out result))
                {
                    if (result == (numTwo + numOne))
                    {
                        Console.WriteLine("right answer, press any key to the move next");
                        Console.ReadLine();
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("wrong answer, press any key to the move next");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("YOU didn't enter a number! , your gained zero point for this question, press any key to move next");
                    Console.ReadLine();
                }
                if (i == rounds - 1)
                {
                    stopwatch.Stop();

                    Console.WriteLine($" GAME END , you score is {score} out of {rounds} and total time you took to solve the questions is: {stopwatch.Elapsed.ToString(@"mm\:ss\.fff")}");
                    Console.WriteLine("");

                    Console.WriteLine("PRESS 1 TO RETUEN TO MENU");
                    string option = Console.ReadLine();
                    if (option == "1")
                    {
                        menu();
                    }

                }
            }


        }

        static void substructionGame(string msg)
        {
            Stopwatch stopwatch = new Stopwatch();

            int levelRange = Level();
            Random random = new Random();
            int score = 0;

            Console.WriteLine("enter number of rounds you want:");
            int rounds = int.Parse(Console.ReadLine());

            stopwatch.Start();

            for (int i = 0; i < rounds; i++)
            {
                Console.Clear();
                Console.WriteLine(msg);
                var numOne = random.Next(1, levelRange);
                var numTwo = random.Next(1, levelRange);

                Console.WriteLine($"{numOne} - {numTwo}");
                Console.WriteLine("Enter your nswer");
                string answer = Console.ReadLine();

                int result;
                if (int.TryParse(answer, out result))
                {
                    if (result == (numTwo - numOne))
                    {
                        Console.WriteLine("right answer, press any key to the move next");
                        Console.ReadLine();
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("wrong answer, press any key to the move next");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("YOU didn't enter a number! , your gained zero point for this question, press any key to move next");
                    Console.ReadLine();
                }
                if (i == rounds - 1)
                {
                    stopwatch.Stop();

                    Console.WriteLine($" GAME END , you score is {score} out of {rounds} and total time you took to solve the questions is: {stopwatch.Elapsed.ToString(@"mm\:ss\.fff")}");
                    Console.WriteLine("");
                    Console.WriteLine("PRESS 1 TO RETUEN TO MENU");
                    string option = Console.ReadLine();
                    if (option == "1")
                    {
                        menu();
                    }

                }
            }


        }


        static int[] GetDivisionNumbers(int levelRange)
        {

            Random random = new Random();
            int numOne = random.Next(1, levelRange);
            int numTwo = random.Next(1, levelRange);

            var result = new int[2];

            while (numOne % numTwo != 0)
            {
                numOne = random.Next(1, levelRange);
                numTwo = random.Next(1, levelRange);

            }
            result[0] = numOne;
            result[1] = numTwo;
            return result;

        }
        static void DividionGame(string msg)
        {
            Stopwatch stopwatch = new Stopwatch();

            int levelRange = Level();

            int score = 0;

            Console.WriteLine("enter number of rounds you want:");
            int rounds = int.Parse(Console.ReadLine());
            stopwatch.Start();

            for (int i = 0; i < rounds; i++)
            {
                Console.Clear();
                Console.WriteLine(msg);


                int[] nummbers = GetDivisionNumbers(levelRange);

                Console.WriteLine($"{nummbers[0]} / {nummbers[1]}");
                Console.WriteLine("Enter your nswer");
                string answer = Console.ReadLine();

                int result;
                if (int.TryParse(answer, out result))
                {
                    if (result == (nummbers[0] / nummbers[1]))
                    {
                        Console.WriteLine("right answer , press any key to the next question");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("wrong answer , press any key to the next question");
                    }
                }
                else
                {
                    Console.WriteLine("YOU didn't enter a number! , your gained zero point for this question, press any key to the next question");
                }
                if (i == rounds - 1)
                {
                    stopwatch.Stop();

                    Console.WriteLine($" GAME END , you score is {score} out of {rounds} and total time you took to solve the questions is: {stopwatch.Elapsed.ToString(@"mm\:ss\.fff")}");
                    Console.WriteLine("");
                    Console.WriteLine("PRESS 1 TO RETUEN TO MENU");
                    string option = Console.ReadLine();
                    if (option == "1")
                    {
                        menu();
                    }
                }

            }

        }

        static void multiplicationGame(string msg)
        {
            Stopwatch stopwatch = new Stopwatch();

            int levelRange = Level();
            Random random = new Random();
            int score = 0;

            Console.WriteLine("enter number of rounds you want:");
            int rounds = int.Parse(Console.ReadLine());
            stopwatch.Start();

            for (int i = 0; i < rounds; i++)
            {
                Console.Clear();
                Console.WriteLine(msg);
                var numOne = random.Next(1, levelRange);
                var numTwo = random.Next(1, levelRange);

                Console.WriteLine($"{numOne} * {numTwo}");
                Console.WriteLine("Enter your nswer");
                string answer = Console.ReadLine();

                int result;
                if (int.TryParse(answer, out result))
                {
                    if (result == (numTwo * numOne))
                    {
                        Console.WriteLine("right answer, press any key to the move next");
                        Console.ReadLine();
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("wrong answer, press any key to the move next");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("YOU didn't enter a number! , your gained zero point for this question, press any key to move next");
                    Console.ReadLine();
                }
                if (i == rounds - 1)
                {
                    stopwatch.Stop();

                    Console.WriteLine($" GAME END , you score is {score} out of {rounds} and total time you took to solve the questions is: {stopwatch.Elapsed.ToString(@"mm\:ss\.fff")}");
                    Console.WriteLine("");
                    Console.WriteLine("PRESS 1 TO RETUEN TO MENU or 0 TO EXIT");
                    string option = Console.ReadLine();
                    if (option == "1")
                    {
                        menu();
                    }
                    else if (option == "0")
                    {
                        Environment.Exit(1);
                    }
                }
            }


        }

        static int Level()
        {

            Console.WriteLine("Enter the level you want:");
            Console.WriteLine("1.Easy");
            Console.WriteLine("2.intermediate");
            Console.WriteLine("3.Hard");
            Console.WriteLine("4.Extra Hard");
            string level = Console.ReadLine();
            switch (level)
            {
                case "1":
                    return 9;
                case "2":
                    return 99;
                    ;
                case "3":
                    return 999;
                case "4":
                    return 9999;
                default:
                    Console.WriteLine("invalid input we will defaault set your level to easy ");
                    return 9;
            }


        }

        static void CallRandom()
        {
            Random random = new Random();
            int select = random.Next(0, 4);
            switch (select)
            {
                case 0: AdditionGame("you random game is addition"); break;
                case 1: multiplicationGame("you random game is multiplication"); break;
                case 2: DividionGame("you random game is division"); break;
                case 3: substructionGame("you random game is substruction"); break;
            }
        }
    }
}
