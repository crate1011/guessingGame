using System;

void HardDifficulty()
{
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
}
void MediumDifficulty()
{
    int guessCounter = 1;
    int guessesLeft = 6;
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
        }

    }
}
void EasyDifficulty()
{
    int guessCounter = 1;
    int guessesLeft = 8;
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
                }
            }
        }

    }
}

void CheaterDifficulty()
{
    int guessCounter = 1;
    Console.WriteLine("HI! Guess the secret number!");
    Console.Write($"What's your guess? You're on guess number ({guessCounter}) with (infinit) remaining");

    string input = Console.ReadLine();

    int numberGuess = int.Parse(input);

    int secretNumber = new Random().Next(1, 100);


    void tryAgain()
    {
        guessCounter++;
        Console.WriteLine("You Shall Not Pass!!!");
        if (numberGuess > secretNumber)
        {
            Console.WriteLine("You Guessed Too High");
        }
        else
        {
            Console.WriteLine("You Guessed Too Low");
        }
        Console.Write($"What's your guess? You're on guess number({guessCounter}) with (infinit) remaining");
        input = Console.ReadLine();
        numberGuess = int.Parse(input);
        if (numberGuess == secretNumber)
        {
            Console.WriteLine("You Guessed It!!!");
        }
        else
        {
            tryAgain();
        }
    }

    if (numberGuess == secretNumber)
    {
        Console.WriteLine("You Guessed It!!!");
    }
    else
    {
        tryAgain();
    }
}

Console.Write("Choose your difficulty. (H/M/E)");

string difficulty = Console.ReadLine();

if (difficulty == "H")
{
    HardDifficulty();
}
else if (difficulty == "M")
{
    MediumDifficulty();
}
else if (difficulty == "E")
{
    EasyDifficulty();
}
else
{
    CheaterDifficulty();
}
