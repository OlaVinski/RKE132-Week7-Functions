Console.WriteLine("Enter the operation (+/-):");
char userOperator = Char.Parse(Console.ReadLine());

Console.WriteLine("Enter a:");
int firstNum = int.Parse(Console.ReadLine());

Console.WriteLine("Enter b:");
int secondNum = int.Parse(Console.ReadLine());

switch (userOperator)
{
    case '+':
        Addition(firstNum, secondNum);
        break;
    case '-':
        Subtraction(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("invalid operator");
        break;
}

static void Addition(int a, int b) //võtab argumentidena sisse a ja b
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void Subtraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}

//void = vahemälusse ei jää peale arvutust mitte midagi