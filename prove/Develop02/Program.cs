using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        int response = 0;

        Journal Journal = new Journal();

        while (response != 5)
        {
            response = myMenu.ProcessMenu();
            switch(response)
            {
                case 1:
                    Journal.CreateEntry();
                    break;
                case 2:
                    Journal.DisplayJournal();
                    break;
                case 3:
                    Console.Write("What do you want to save this as? ");
                    Journal.WriteToFile(Console.ReadLine());
                    break;
                case 4:
                    Console.Write("Enter journal file name: ");
                    Journal.ReadFromFile(Console.ReadLine());
                    break;
                case 5:
                    Console.WriteLine("Quit");
                    break;
            }
        }
    }
}