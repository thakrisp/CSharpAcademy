Console.WriteLine("Please enter your name");
var userName = Console.ReadLine();
//var userName = "Ryan";

GameEngineHelpers.ShowMenu(userName);

internal static class GameEngine{

    internal static List<Game> listOfGames = new()
    {
        new Game{ Name = "Ryan", Score = 3, Date = DateTime.Now.AddDays(1), Type = GameType.Multiplication }
    };

    public static void AdditionGame(string userName)
    {
        Console.Clear();
        Console.WriteLine("Ready to play the Addition game?\n");

        var random = new Random();

        Game newGame = new Game();

        newGame.Name = userName;
        newGame.Score = 0;
        newGame.Date = DateTime.Now;
        newGame.Type = GameType.Addition;

        //var name = username;
        //var score = 0;
        //var date = DateTime.Now;

        for (var i = 0; i < 1; i++)
        {
            var firstNum = random.Next(0,99);
            var secondNum = random.Next(0,99);

            Console.WriteLine($"what is {firstNum} + {secondNum}?");

            Console.WriteLine("Your answer: ");
            string userAnswer = Console.ReadLine();

            if(GameEngineHelpers.ValidateUserInput(userAnswer) == firstNum + secondNum)
            {
                newGame.Score++;
            }

        }

        listOfGames.Add(newGame);

        Console.Clear();
        Console.WriteLine($"\nuserName: {newGame.Name}, score: {newGame.Score} out of 5, on {newGame.Date}\n");
        GameEngineHelpers.ShowMenu(userName);
    }
    public static void SubtractionGame(string userName)
    {
        Console.Clear();
        Console.WriteLine("Ready to play the Subtration game?\n");

        var random = new Random();

        Game newGame = new Game();

        newGame.Name = userName;
        newGame.Score = 0;
        newGame.Date = DateTime.Now;
        newGame.Type = GameType.Subtraction;

        for (var i = 0; i < 1; i++)
        {
            var firstNum = random.Next(0, 99);
            var secondNum = random.Next(0, 99);

            Console.WriteLine($"what is {firstNum} - {secondNum}?");

            Console.WriteLine("Your answer: ");
            string userAnswer = Console.ReadLine();

            if (GameEngineHelpers.ValidateUserInput(userAnswer) == firstNum - secondNum)
            {
                newGame.Score++;
            }

        }

        listOfGames.Add(newGame);

        Console.Clear();
        Console.WriteLine($"\nuserName: {newGame.Name}, score: {newGame.Score} out of 5, on {newGame.Date}\n");
        GameEngineHelpers.ShowMenu(userName);
    }
    public static void MultiplicationGame(string userName)
    {
        Console.Clear();
        Console.WriteLine("Ready to play the Multiplication game?");

        var random = new Random();

        Game newGame = new()
        {
            Name = userName,
            Score = 0,
            Date = DateTime.Now,
            Type = GameType.Multiplication
        };

        for (var i = 0; i < 1; i++)
        {
            var firstNum = random.Next(0, 99);
            var secondNum = random.Next(0, 99);

            Console.WriteLine($"what is {firstNum} * {secondNum}?");

            Console.WriteLine("Your answer: ");
            string userAnswer = Console.ReadLine();

            if (GameEngineHelpers.ValidateUserInput(userAnswer) == firstNum * secondNum)
            {
                newGame.Score++;
            }

        }

        listOfGames.Add(newGame);

        Console.Clear();
        Console.WriteLine($"\nuserName: {newGame.Name}, score: {newGame.Score} out of 5, on {newGame.Date}\n");
        GameEngineHelpers.ShowMenu(userName);
    }
    public static void DivisionGame(string userName)
    {
        Console.WriteLine("Ready to play the Division game?");
        Console.Clear();
        Console.WriteLine("Ready to play the Addition game?\n");

        var random = new Random();

        Game newGame = new Game();

        newGame.Name = userName;
        newGame.Score = 0;
        newGame.Date = DateTime.Now;
        newGame.Type = GameType.Division;

        for (var i = 0; i < 1; i++)
        {
            var firstNum = random.Next(0, 99);
            var secondNum = random.Next(0, 99);

            if(secondNum == 0)
            {
                GameEngineHelpers.ValidateDivisionNumbers(secondNum);
            }

            Console.WriteLine($"what is {firstNum} / {secondNum}?");

            Console.WriteLine("Your answer: ");
            string userAnswer = Console.ReadLine();

            int total = firstNum / secondNum;
            if (GameEngineHelpers.ValidateUserInput(userAnswer) == total)
            {
                newGame.Score++;
            }

        }

        listOfGames.Add(newGame);

        Console.Clear();
        Console.WriteLine($"\nuserName: {newGame.Name}, score: {newGame.Score} out of 5, on {newGame.Date}\n");
        GameEngineHelpers.ShowMenu(userName);
    }
}