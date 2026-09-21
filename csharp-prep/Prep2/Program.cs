using System;

class Program
{
    static void Main(string[] args)
    {
        int grade;

        Console.Write("Hello, please enter your grade percentage");
        string input = Console.ReadLine();
        grade = int.Parse(input);

        if (grade >= 90)
            Console.Write("Your Grade is an A");
        else if (grade >= 80 && grade < 90)
            Console.Write("Your Grade is a B");
        else if (grade >= 70 && grade <80)
            Console.Write("Your grade is a C");
        else if (grade >= 60 && grade <70)
            Console.Write("Your grade is a D");
        else if (grade <60)
            Console.Write("Your grade is an F");

        if (grade >= 70)
            Console.Write("Congrats, you passed the class!!!");
        else 
            Console.Write("It doesn't look like you passed, better luck next time!!");

    }
}