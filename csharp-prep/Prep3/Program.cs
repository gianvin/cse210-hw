using System;

Console.WriteLine("What is the magic number? 18");
Console.Write("What is your guess? ");
string guess = Console.ReadLine();
int number = int.Parse(guess);

string word = "";

if (number < 18)
{
    word = "higher";
}
else if (number > 18)
{
    word = "lower";
}
else
{
    word = "You guessed it!";
}
Console.WriteLine($"{word}");
do
{
    Console.Write("What is your guess? ");
    guess = Console.ReadLine();
} while (number == 18);
    Console.Write("You guessed it");
