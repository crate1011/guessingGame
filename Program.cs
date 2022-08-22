using System;

Console.WriteLine("HI! Guess the secret number!");
Console.Write("What's your guess? ");

string input = Console.ReadLine();

int numberGuess = int.Parse(input);

int secretNumber = 42;

if (numberGuess == secretNumber)
{
    Console.WriteLine("You Guessed It!!!");
}
else
{
    Console.WriteLine("You Shall Not Pass!!!");
}