using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }

    static void PromptUserBirthYear(out int x)
    {
        Console.Write("What is your birth year? ");
        x= int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int x)
    {
        x = x * x;
        return x;
    }


    static void DisplayResult(string name, int squared, int birth_year)
    {
        Console.WriteLine($"Your name is {name} and your squared number is {squared}");
        int Current_Year = 2026;
        int age = Current_Year - birth_year;
        Console.WriteLine($"You are {age} years old");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string Name = PromptUserName();
        int number = PromptUserNumber();
        int year;
        PromptUserBirthYear(out year);
        int squared = SquareNumber(number);

        DisplayResult(Name, squared, year);


    }
}