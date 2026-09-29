using System;

class Program
{
    static void Main(string[] args)
    {
        int magic_number;
        int user_number;
        
        Random randomGenerator = new Random();
        magic_number = randomGenerator.Next(1,100);

        do
        {
        Console.Write("What is your guess? ");
        user_number = int.Parse(Console.ReadLine());

        if (user_number > magic_number)
        Console.WriteLine("Lower");
        else if (user_number < magic_number)
        Console.WriteLine("Higher");
        else
        Console.Write("You guessed it!!");

        } while (user_number != magic_number );


    }
}