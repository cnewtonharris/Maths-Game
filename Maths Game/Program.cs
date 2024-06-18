using System;
using System.Runtime.Versioning;

namespace MathsGame
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            var keepPlaying = true;

            GetName();
            Menu();           
            
        }
        static void GetName()
        {
            var timeNow = DateTime.Now;
            Console.WriteLine("Welcome to the Maths Game");
            Console.WriteLine("What is your name?");
            var playerName = Console.ReadLine();
            Console.WriteLine($"Hi {playerName}, it is {timeNow}.");
        }
        static void Menu()
        {
            Console.WriteLine("Please choose what game you would like to play:\nA = Addition\nS = Subtraction\nM = Multiplication\nD = Division\nQ = Quit Playing");
            var pChoice = Console.ReadLine().Trim().ToLower();

            //switch statement with options for each game
            switch (pChoice)
            {
                case "a":
                    AdditionGame();
                    break;

                case "s":
                    SubtractionGame();
                    break;

                case "m":
                    MultiplicationGame();
                    break;

                case "d":
                    DivisionGame();
                    break;

                case "q":
                    Console.WriteLine("Thank you for playing the Maths Game!");
                    break;
            }
        }
        static void AdditionGame()
        {
            Console.WriteLine("You have chose the Addition game.");
            var keepPlaying = true;
            do
            {
                Random random = new Random();
                var firstNumber = random.Next(1, 101);
                var secondNumber = random.Next(1, 101);
                var sumResult = firstNumber + secondNumber;
                Console.WriteLine($"What is {firstNumber} + {secondNumber}?");
                var pAnswer = Convert.ToInt32(Console.ReadLine());
                var playAgain = "";
                if (pAnswer == sumResult)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine($"Incorrect, the answer is {sumResult}");
                }
                Console.WriteLine("Would you like you play again, enter Y or N?");
                playAgain = Console.ReadLine().Trim().ToLower();
                if (playAgain == "y")
                {
                    keepPlaying = true;
                }
                else
                {
                    Console.WriteLine("Thank you for playing the Maths Game!");
                    keepPlaying = false;
                }
            } while (keepPlaying == true);
        }

        static void SubtractionGame()
        {
            Console.WriteLine("You have chose the Subtraction game.");
            var keepPlaying = true;
            do
            {
                Random random = new Random();
                var firstNumber = random.Next(1, 101);
                var secondNumber = random.Next(1, 101);
                var sumResult = firstNumber - secondNumber;
                Console.WriteLine($"What is {firstNumber} - {secondNumber}?");
                var pAnswer = Convert.ToInt32(Console.ReadLine());
                var playAgain = "";
                if (pAnswer == sumResult)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine($"Incorrect, the answer is {sumResult}");
                }
                Console.WriteLine("Would you like you play again, enter Y or N?");
                playAgain = Console.ReadLine().Trim().ToLower();
                if (playAgain == "y")
                {
                    keepPlaying = true;
                }
                else
                {
                    Console.WriteLine("Thank you for playing the Maths Game!");
                    keepPlaying = false;
                }
            } while (keepPlaying == true);
        }

        static void MultiplicationGame()
        {
            Console.WriteLine("You have chose the Multiplication game.");
            var keepPlaying = true;
            do
            {
                Random random = new Random();
                var firstNumber = random.Next(1, 101);
                var secondNumber = random.Next(1, 101);
                var sumResult = firstNumber * secondNumber;
                Console.WriteLine($"What is {firstNumber} * {secondNumber}?");
                var pAnswer = Convert.ToInt32(Console.ReadLine());
                var playAgain = "";
                if (pAnswer == sumResult)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine($"Incorrect, the answer is {sumResult}");
                }
                Console.WriteLine("Would you like you play again, enter Y or N?");
                playAgain = Console.ReadLine().Trim().ToLower();
                if (playAgain == "y")
                {
                    keepPlaying = true;
                }
                else
                {
                    Console.WriteLine("Thank you for playing the Maths Game!");
                    keepPlaying = false;
                }
            } while (keepPlaying == true);
        }

        static void DivisionGame()
        {
            Console.WriteLine("You have chose the Division game.");
            var keepPlaying = true;
            do
            {
                Random random = new Random();
                var firstNumber = random.Next(1, 101);
                var secondNumber = random.Next(1, 101);
                var sumResult = firstNumber / secondNumber;
                if ((firstNumber % secondNumber) == 0 && (firstNumber != secondNumber))
                {
                    Console.WriteLine($"What is {firstNumber} / {secondNumber}?");
                    var pAnswer = Convert.ToInt32(Console.ReadLine());
                    var playAgain = "";
                    if (pAnswer == sumResult)
                    {
                        Console.WriteLine("Correct!");
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect, the answer is {sumResult}");
                    }
                    Console.WriteLine("Would you like you play again, enter Y or N?");
                    playAgain = Console.ReadLine().Trim().ToLower();
                    if (playAgain == "y")
                    {
                        keepPlaying = true;
                    }
                    else
                    {
                        Console.WriteLine("Thank you for playing the Maths Game!");
                        keepPlaying = false;
                    }
                }
            } while (keepPlaying == true);
        }
    }
}