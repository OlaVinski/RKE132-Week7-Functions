//arvutab allahindlust
//total < kui 10, siis allahindlus on - 1%
//total >= 10 && 20 < 20 - 5%
//total >= 20 - 10%

Console.WriteLine("Provide total: ");
int userInput = Int32.Parse(Console.ReadLine());

double discount = CalculateDiscount(userInput);

Console.WriteLine($"Your discount is: {discount} %");

double newTotal = CalculateNewTotal(userInput, discount);

Console.WriteLine($"Your updated total with {discount}%: {newTotal}");

static double CalculateDiscount(int total)
{
    if(total < 10)
    {
        return 1;
    }
    else if(total >= 10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}
//double on siis andmed ühe komakohaga ehk võib kirjutada return 1,0 jne

static double CalculateNewTotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;
} 

//static tähendab iseseisvat funktsiooni