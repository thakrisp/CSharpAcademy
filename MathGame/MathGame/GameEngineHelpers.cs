public static class GameEngineHelpers
{
    public static int ValidateDivisionNumbers(int secondNum)
    {
        Random random = new();

        do
        {
            secondNum = random.Next(1, 99);
        } while (secondNum != 0);

        return secondNum;
    }

    public static void PrintGameHistory(string userName)
    {
        IEnumerable<Game> gameHistory = GameEngine.listOfGames;

        foreach (var game in gameHistory)
        {
            Console.WriteLine($"{game.Name} - {game.Type}: {game.Score}{(game.Score == 1 ? "pt" : "pts")} on {game.Date}");
        }
        Console.WriteLine("\n");
        Console.WriteLine("Press any key to show the menu");
        Console.ReadKey();
        Console.Clear();
        ShowMenu(userName);
    }

    public static int ValidateUserInput(string userAnswer)
    {
        while (string.IsNullOrEmpty(userAnswer) || !Int32.TryParse(userAnswer, out _))
        {
            Console.WriteLine("Your answer needs to be an integer. Try again.");
            userAnswer = Console.ReadLine();
        }

        return Int32.Parse(userAnswer);
    }

    public static void ShowMenu(string userName)
    {

        Console.WriteLine($"Welcome to the Game {userName}, it is now {DateTime.Now}");

        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine("Enter the game you want to play");
        Console.WriteLine("H - game history");
        Console.WriteLine("A - Addition game");
        Console.WriteLine("S - Subraction game");
        Console.WriteLine("M - Multiplication game");
        Console.WriteLine("D - Division game");
        Console.WriteLine("Q - Quit game");
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine("\n");
        Console.WriteLine("What type of game do you want to play?");
        char gameValue = (char)Console.ReadKey().Key;
        Console.WriteLine("\n");

        switch (gameValue)
        {
            case 'H':
                Console.Clear();
                Console.WriteLine("View game history");
                GameEngineHelpers.PrintGameHistory(userName);
                break;
            case 'A':
                Console.Clear();
                GameEngine.AdditionGame(userName);
                break;
            case 'S':
                Console.Clear();
                GameEngine.SubtractionGame(userName);
                break;
            case 'M':
                Console.Clear();
                GameEngine.MultiplicationGame(userName);
                break;
            case 'D':
                Console.Clear();
                GameEngine.DivisionGame(userName);
                break;
            case 'Q':
                Console.Clear();
                Console.WriteLine("Thank you for playing");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid key entry");
                break;
        }
    }
}