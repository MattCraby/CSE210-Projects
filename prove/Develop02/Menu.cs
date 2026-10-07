using System.Net;

class Menu
{
    

        public int ProcessMenu()
    {
        int Response = 0;


        while (Response < 1 || Response >5)
        {
            Console.WriteLine("Welcome to the Journaling Program");
            Console.WriteLine("Create, Display, Save, and Read Journal Entries");
            Console.WriteLine("1. Create new joiurnal entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save journal file");
            Console.WriteLine("4. Read journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("> ");

            Response = int.Parse(Console.ReadLine());
            
        }
            return Response;

    }
}