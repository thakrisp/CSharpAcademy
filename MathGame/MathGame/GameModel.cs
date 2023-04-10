internal class Game
{
    internal string Name { get; set; }

    internal int Score { get; set; }

    internal GameType Type { get; set; }

    internal DateTime Date { get; set; }

}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}