using System;
int guessCounter = 1;
int guessesLeft = 4;
Console.WriteLine("HI! Guess the secret number!");
Console.Write($"What's your guess? You're on guess number({guessCounter}) ({guessesLeft}) remaining");

string input = Console.ReadLine();

int numberGuess = int.Parse(input);

int secretNumber = new Random().Next(1, 100);

void tryAgain()
{
    guessCounter++;
    guessesLeft--;
    Console.WriteLine("You Shall Not Pass!!!");
    if (numberGuess > secretNumber)
    {
        Console.WriteLine("You Guessed Too High");
    }
    else
    {
        Console.WriteLine("You Guessed Too Low");
    }
    Console.Write($"What's your guess? You're on guess number({guessCounter}) ({guessesLeft}) remaining");
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