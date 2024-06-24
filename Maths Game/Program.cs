using System.Xml.Schema;

var games = new List<string>();

GetName();
Menu();

//Provides the date and requests input of the users name

void GetName()
{
    var timeNow = DateTime.Now;
    Console.WriteLine("Welcome to the Maths Game");
    Console.WriteLine("What is your name?");
    var playerName = Console.ReadLine();
    Console.WriteLine($"Hi {playerName}, it is {timeNow}.");
}

void Menu()
{
    var gameOn = true;
    do
    {
        Console.Clear();
        Console.WriteLine("Please choose what game you would like to play:\nV = View Previous Games History\nA = Addition\nS = Subtraction\nM = Multiplication\nD = Division\nQ = Quit Playing");
        var pChoice = Console.ReadLine().Trim().ToLower();

        //switch statement with options for each game
        switch (pChoice)
        {
            case "v":
                GetGames();
                break;
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
                gameOn = false;
                break;
        }
    } while (gameOn);
}
void AdditionGame()
{
    Console.WriteLine("You have chose the Addition game.");
    var score = 0;
    Random random = new Random();

    for (int i = 0; i < 5; i++)
    {
        var firstNumber = random.Next(1, 101);
        var secondNumber = random.Next(1, 101);

        Console.WriteLine($"What is {firstNumber} + {secondNumber}?");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Correct! Type any key for the next question");
            score++;
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"Incorrect, Type any key for the next question");
            Console.ReadKey();
            Console.Clear();
        }
        if (i == 4)
        {
            Console.WriteLine($"Game Over, Your final score is {score}, Press any key to play again");
            Console.ReadKey();
        }
    }

    AddToHistory(score, "Addition");

}

void SubtractionGame()
{
    Console.WriteLine("You have chose the Subtraction game.");
    Random random = new Random();
    var score = 0;

    for (int i = 0; i < 5; i++)
    {

        var firstNumber = random.Next(1, 101);
        var secondNumber = random.Next(1, 101);

        Console.WriteLine($"What is {firstNumber} - {secondNumber}?");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("Correct! Type any key for the next question");
            score++;
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"Incorrect, Type any key for the next question");
            Console.ReadKey();
            Console.Clear();
        }
        if (i == 4)
        {
            Console.WriteLine($"Game Over, Your final score is {score}, Press any key to play again");
            Console.ReadLine();
        }
        
    }
    AddToHistory(score, "Subtraction");
}

void MultiplicationGame()
{
    Console.WriteLine("You have chose the Multiplication game.");
    Random random = new Random();
    var score = 0;
    for (int i = 0; i < 5; i++)
    {
        var firstNumber = random.Next(1, 101);
        var secondNumber = random.Next(1, 101);


        Console.WriteLine($"What is {firstNumber} * {secondNumber}?");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("Correct! Type any key for the next question");
            score++;
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"Incorrect, Type any key for the next question");
            Console.ReadKey();
            Console.Clear();
        }
        if (i == 4)
        {
            Console.WriteLine($"Game Over, Your final score is {score}, Press any key to play again");
            Console.ReadLine();
        }
        
    }
    AddToHistory(score, "Multiplication");
}

void DivisionGame()
{
    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        Console.WriteLine($"What is {firstNumber} / {secondNumber}?");
        var result = Console.ReadLine();
        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Correct! Type any key for the next question");
            score++;
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"Incorrect, Type any key for the next question");
            Console.ReadKey();
            Console.Clear();
        }
        if (i == 4)
        {
            Console.WriteLine($"Game Over, Your final score is {score}, Press any key to play again");
            Console.ReadLine();
        }
    }AddToHistory(score, "Division");
}

void AddToHistory(int gameScore, string gameType)
{
    games.Add($"{DateTime.Now} - {gameType}: {gameScore} pts");
}
int[] GetDivisionNumbers()
{
    var Random = new Random();
    var firstNumber = Random.Next(1, 100);
    var secondNumber = Random.Next(1, 100);
    var result = new int[2];

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = Random.Next(1, 100);
        secondNumber = Random.Next(1, 100);
    }
    result[0] = firstNumber;
    result[1] = secondNumber;
    return result;
}
void GetGames()
{
    Console.Clear();
    Console.WriteLine("Games History");
    foreach (var game in games)
    {

        Console.WriteLine(game);
    }
    Console.WriteLine("Press any key to return to the Main Menu.");
    Console.ReadKey();
}