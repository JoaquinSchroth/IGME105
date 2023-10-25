//Joaquin Schroth
//10/20/2023
//

namespace PE17_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--- Variables ---\\
            string[] names;//array of names
            int numOfNames = 0;//how many names there should be
            string userChoice = "";//user's inputted choice
            
            //--- Console Output ---\\
            Console.Write("Welcome to the character name collector!\n" +
                          "How many characters are you entering today? ");
            numOfNames = int.Parse(Console.ReadLine());
            names = new string[numOfNames];

            for (int x = 0; x < numOfNames; x++)
            {
                Console.Write($"Name #{x+1}: ");
                names[x] = Console.ReadLine();
            }
            Console.WriteLine("All names have been entered.");

            
            while (true)
            {
                Console.Write(
                "\nChoose from one of the following\n" +
                "choices:" +
                "\t\n- PRINT all names" +
                "\t\n- Name SEARCH" +
                "\t\n- HOW MANY names start with ‘B’" +
                "\t\n- QUIT the program" +
                "\nYour choice: ");

                switch (userChoice = Console.ReadLine().ToUpper())
                {
                    case "PRINT":
                        Console.WriteLine("\nYou chose PRINT!!!");
                        Print(names);
                        break;

                    case "SEARCH":
                        Console.WriteLine("\nYou chose SEARCH!!!");
                        Console.Write("Name to search for: ");
                        userChoice = Console.ReadLine();
                        if (Search(names, userChoice))
                            Console.WriteLine($"Yes, {userChoice} is in the array.");
                        else Console.WriteLine($"No, {userChoice} is not in the array.");
                        break;

                    case "HOW MANY":
                        Console.WriteLine("\nYou chose HOW MANY!!!");
                        Console.WriteLine($"{StartsWithB(names)} names start with 'B'");
                        break;

                    case "QUIT":
                        Console.WriteLine("Goodbye!");
                        Console.ReadLine();
                        return;
                }
            }
            Console.ReadLine();
        }//end of main

        public static void Print(string[] names)
        {
            foreach (string name in names) Console.WriteLine(name);
        }

        public static bool Search(string[] names, string name)
        {
            foreach (string str in names)
                if (str == name) 
                    return true;
            return false;
        }

        public static int StartsWithB(string[] names)
        {
            int countB = 0;
            foreach (string name in names)
                if (name.Substring(0, 1).Contains("B"))
                    countB++;
            return countB;
        }
    }
}