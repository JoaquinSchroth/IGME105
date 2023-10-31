//Joaquin Schroth
//10/20/2023
//work

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
            numOfNames = int.Parse(Console.ReadLine());//gets number of names int
            names = new string[numOfNames];//makes an array with a specific size

            for (int x = 0; x < numOfNames; x++)
            {//asks for the input of names the same amount of time as array size
                Console.Write($"Name #{x+1}: ");
                names[x] = Console.ReadLine();
            }
            Console.WriteLine("All names have been entered.");
            
            while (true)
            {//repeats until QUIT is chosen
                Console.Write(//prints out options
                "\nChoose from one of the following\n" +
                "choices:" +
                "\t\n- PRINT all names" +
                "\t\n- Name SEARCH" +
                "\t\n- HOW MANY names start with ‘B’" +
                "\t\n- QUIT the program" +
                "\nYour choice: ");

                switch (userChoice = Console.ReadLine().ToUpper())
                {//asks for input and formats it a little for use
                    case "PRINT"://when they choose print
                        Console.WriteLine("\nYou chose PRINT!!!");
                        Print(names);//prints names inside array
                        break;

                    case "SEARCH"://when they choose search
                        Console.WriteLine("\nYou chose SEARCH!!!");
                        Console.Write("Name to search for: ");
                        userChoice = Console.ReadLine();//name to search for
                        if (Search(names, userChoice))//searches for the name
                            Console.WriteLine($"Yes, {userChoice} is in the array.");
                        else Console.WriteLine($"No, {userChoice} is not in the array.");
                        break;

                    case "HOW MANY"://when they choose how many
                        Console.WriteLine("\nYou chose HOW MANY!!!");
                        //prints out how many names start with B
                        Console.WriteLine($"{StartsWithB(names)} names start with 'B'");
                        break;

                    case "QUIT"://when they choose quit
                        Console.WriteLine("Goodbye!");//says goodbye
                        Console.ReadLine();
                        return;//ends the program
                }
            }
        }//end of main

        //prints all items in a specified array
        public static void Print(string[] names)
        {//goes through every item in the array and prints it
            foreach (string name in names)
                Console.WriteLine(name);
        }

        public static bool Search(string[] names, string name)
        {//if any of iterated items in the array equals the given name returns true
            foreach (string str in names)
                if (str == name) 
                    return true;
            return false;
        }

        public static int StartsWithB(string[] names)
        {
            int countB = 0;//numbe of Bs
            //iterates through every item and adds 1 if theres a B
            foreach (string name in names)
                if (name.Substring(0, 1).Contains("B"))
                    countB++;
            return countB;//returns the number of Bs
        }
    }
}