using System;
using System.Reflection.Metadata;

class Program
    {
    static double AddNumbers(double x, int y)
        {
            return x + y;
        }

    static void DisplayGreeting(string name)
    {
        Console.WriteLine($"Welcome {name} pleased to meet you");
    }
    
    static void Main(string[] args)
    {
        
        DisplayGreeting("Bob");


        double answer = AddNumbers(12.234, 10);
        Console.WriteLine(answer);
    //    bool done;

    //    do
    //     {
    //         Console.Write("are we done (y/n): ");
    //         done = Console.ReadLine().ToLower() == "y";

    //     } while(!done);

    // for(double i=0; i < 1; i+=0.01)
    //     {
    //         Console.WriteLine(i);
    //     }




    // List<string> myFriends = new List<string> {"Bob", "Betty", "Bubba"};
    // myFriends.Add("James");

    // foreach(string name in myFriends)
    //     {
    //         Console.WriteLine(name);
         }

}