using System;

Console.WriteLine("HI! Guess the secret number!");
Console.Write("What's your guess? ");

string input = Console.ReadLine();

int numberGuess = int.Parse(input);

int secretNumber = 42;

void tryAgain()
{
    Console.WriteLine("You Shall Not Pass!!!");
    Console.Write("What's your guess? ");
    input = Console.ReadLine();
    numberGuess = int.Parse(input);
}

if (numberGuess == secretNumber)
{
    Console.WriteLine("You Guessed It!!!");
}
else
{
    tryAgain();
    if (numberGuess == secretNumber)
    {
        Console.WriteLine("You Guessed It!!!");
    }
    else
    {
        tryAgain();
        if (numberGuess == secretNumber)
        {
            Console.WriteLine("You Guessed It!!!");
        }
        else
        {
            tryAgain();
            if (numberGuess == secretNumber)
            {
                Console.WriteLine("You Guessed It!!!");
            }
        }
    }

}