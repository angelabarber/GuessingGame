// See https://aka.ms/new-console-template for more information
Console.WriteLine("How's about guessing a number instead of biting me...");

int response = int.Parse(Console.ReadLine());



int secretNumber = 42;

while (response != secretNumber)
{
    Console.WriteLine("WRONG! Guess Again");
    response = int.Parse(Console.ReadLine());
}

Console.WriteLine("You betcha, here's a hot dish!");


