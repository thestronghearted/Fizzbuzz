var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

String Fizzbuzz = "FizzBuzz Application numbers: 1 - 100\n";

for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0) //if a multiple of 3
    {
        Fizzbuzz = Fizzbuzz + "Fizz";
        if (i % 5 == 0) //and a multiuple of 5
        {
            Fizzbuzz = Fizzbuzz + "Buzz"; //FizzBuzz
        }
    }
    else if (i % 5 == 0) // a multiple of 5
    {
        Fizzbuzz = Fizzbuzz + "Buzz " + i.ToString();
    }
    else //just show number
    {
        Fizzbuzz = Fizzbuzz + i.ToString();
    }
    Fizzbuzz = Fizzbuzz + "\n"; //used for spacing
}

app.MapGet("/", () => Fizzbuzz);

app.Run();
