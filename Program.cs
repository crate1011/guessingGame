using System;

Console.WriteLine("HI! Guess the secret number!");
Console.Write("What's your guess?");

string input = Console.ReadLine();

int numberGuess = int.Parse(input);

Console.WriteLine(numberGuess);