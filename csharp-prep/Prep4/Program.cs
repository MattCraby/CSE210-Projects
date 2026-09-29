using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int user_number;
        int sum = 0;
        float average;
        int max = -10000000;
        int length =0;

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        do
        {
            Console.Write("Enter number: ");
            user_number = int.Parse(Console.ReadLine());
            if (user_number != 0)
            {
            numbers.Add(user_number);
            }
        } while (user_number != 0);

        foreach(int number in numbers)
            { sum += number;

            if (number > max)
                max = number;
            length ++;
           }

           average = (float)sum/ length;
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {max}");


    }
}