// See https://aka.ms/new-console-template for more informationConsole.WriteLine("Hello, World!");

Console.WriteLine("Welcome the caclulator");

Boolean endGame = false;

while (!endGame)
{
    Console.WriteLine("A - addition");
    Console.WriteLine("S - subtract");
    Console.WriteLine("M - Multiplication");
    Console.WriteLine("D - Division");
    Console.WriteLine("E - End");
    Console.WriteLine("What type of calculation would you like to do?");

    char CalculationType = char.ToUpperInvariant(Console.ReadKey().KeyChar);

    if (CalculationType.Equals('E'))
    {
        Console.WriteLine("Thank you for using our app");
        //endGame = true;
        return;
    }

    while (!Enum.IsDefined(typeof(CalculationTypeEnum), char.ToString(CalculationType)))
    {
        Console.WriteLine("Please enter a calculation type");
        CalculationType= Console.ReadKey().KeyChar;
    }

    double num1 = double.MaxValue;
    double num2 = double.MaxValue;

    while (num1.Equals(double.MaxValue) || double.IsNaN(num1))
    {
        Console.WriteLine("Please enter the first number");
        try
        {
            num1 = Double.Parse(Console.ReadLine());

        } catch
        {
            Console.WriteLine("Invalid number");
        }
    }

    while (num2.Equals(double.MaxValue) || double.IsNaN(num2))
    {
        Console.WriteLine("Please enter the Second number");
        try
        {
            num2 = Double.Parse(Console.ReadLine());
        } catch
        {
            Console.WriteLine("Invalid number");
        }
    }

    while(num2.Equals(0) && CalculationType.Equals('D'))
    {
        Console.WriteLine("For division please enter a divisor that isnt 0");
        Console.WriteLine("Enter a new number 2");
        num2 = Double.Parse(Console.ReadLine());
    }

    switch(CalculationType)
    {
        case 'A':
            {
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                break;
            }
        case 'S':
            {
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                break;
            }
        case 'M':
            {
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                break;

            }
        case 'D':
            {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                break;
            }
        default:
            {
                throw new InvalidOperationException();
            }
    }

}


public enum CalculationTypeEnum
{
    A, S, M, D, E
}