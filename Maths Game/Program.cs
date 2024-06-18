using System;

namespace MathsGame
{
    class Program
    {
        static void Main(string[] args)
        {   
            var timeNow = DateTime.Now;
            var keepPlaying = true;

            Console.WriteLine("Welcome to the Maths Game");
            Console.WriteLine("What is your name?");
            var playerName = Console.ReadLine();
            Console.WriteLine($"Hi {playerName}, it is {timeNow}. Please choose what game you would like to play");
            Console.WriteLine("A = Addition\nS = Subtraction\nM = Multiplication\nD = Division\nQ = Quit Playing");
            var pChoice = Console.ReadLine().Trim().ToLower();
            
            //switch statement with options for each game
            switch (pChoice)
            {
                case "a":
                    Console.WriteLine("You have chose the Addition game.");
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
                            keepPlaying = false;
                        }
                    } while (keepPlaying == true);
                    break;

                case "s":
                    Console.WriteLine("You have chose the Subtraction game.");
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
                            keepPlaying = false;
                        }
                    } while (keepPlaying == true);
                    break;

                case "m":
                    Console.WriteLine("You have chose the Multiplication game.");
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
                            keepPlaying = false;
                        }
                    } while (keepPlaying == true);
                    break;

                case "d":
                    Console.WriteLine("You have chose the Division game.");
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
                                keepPlaying = false;
                            }
                        } 
                    } while (keepPlaying == true);
                    break;

                case "q":
                    Console.WriteLine("Thank you for playing the Maths Game!");
                    break;
            }
        }
    }
}