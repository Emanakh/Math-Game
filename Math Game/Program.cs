namespace Math_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            welcome();

            getName();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AdditionGame(" welcome to Addition game");
                    break;
                case "2":
                    Console.WriteLine("Substruction");
                    break;
                case "3":
                    muliplicationGame("Multiplication");
                    break;
                case "4":
                    Console.WriteLine("Divison");
                    break;
                case "5":
                    Console.WriteLine("END GAME");
                    break;
                default:
                    Console.WriteLine("invalid input");
                    Environment.Exit(1);
                    break;
            }

            static string getName()
            {
                Console.WriteLine("Enter your name:");
                string name = Console.ReadLine();
                return name;
            }

            static void welcome()
            {
                Console.Clear();
                Console.Title = "math game";

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("********************************************");
                Console.WriteLine("*      Welcome to " +
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
                Console.WriteLine(msg);
                Random random = new Random();
                int score = 0;

                Console.WriteLine("enter number of rounds you want:");
                int rounds = int.Parse(Console.ReadLine());

                for (int i = 0; i < rounds; i++)
                {
                    var numOne = random.Next(1, 9);
                    var numTwo = random.Next(1, 9);

                    Console.WriteLine($"{numOne} + {numTwo}");
                    Console.WriteLine("Enter your nswer");
                    string answer = Console.ReadLine();

                    int result;
                    if (int.TryParse(answer, out result))
                    {
                        if (result == (numTwo + numOne))
                        {
                            Console.WriteLine("right answer");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("wrong answer");
                        }
                    }
                    else
                    {
                        Console.WriteLine("YOU didn't enter a number!");
                    }
                    if (i == rounds - 1) { Console.WriteLine($"GAME OVER , you score is {score} out of {rounds}"); }
                }


            }


            static void muliplicationGame(string msg)
            {
                Console.WriteLine(msg);
                Random random = new Random();
                int score = 0;

                Console.WriteLine("enter number of rounds you want:");
                int rounds = int.Parse(Console.ReadLine());

                for (int i = 0; i < rounds; i++)
                {
                    var numOne = random.Next(1, 9);
                    var numTwo = random.Next(1, 9);

                    Console.WriteLine($"{numOne} * {numTwo}");
                    Console.WriteLine("Enter your nswer");
                    string answer = Console.ReadLine();

                    int result;
                    if (int.TryParse(answer, out result))
                    {
                        if (result == (numTwo * numOne))
                        {
                            Console.WriteLine("right answer");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("wrong answer");
                        }
                    }
                    else
                    {
                        Console.WriteLine("YOU didn't enter a number!");
                    }
                    if (i == rounds - 1) { Console.WriteLine($"GAME OVER , you score is {score} out of {rounds}"); }
                }


            }

        }
    }
}
