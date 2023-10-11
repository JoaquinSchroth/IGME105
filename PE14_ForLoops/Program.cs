//Joaquin schroth
//09/10/2023
//his program demonstrates multiple loops that handle numerical data and draws “art” to the
//console window with nested for loops and while loops

using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace PE14_ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            string userInput = ""; //where the user input is saved
            int width = 0;
            int height = 0;

            //--- While Loop ---\\
            Console.WriteLine("0-10 While: ");
            while (x <= 10) {
                Console.Write(x + " "); //outputs the current loop number with a space
                x++; //add 1
            } x = 0; //reset to 0

            //--- Do-While Loop ---\\
            Console.WriteLine("\n\n0-10 Do-While: ");
            do {
                Console.Write(x + " "); //outputs the current loop number with a space
                x++; //add 1
            } while (x <= 10);
            x = 0;//reset to 0

            //--- For Loop ---\\
            Console.WriteLine("\n\n0-10 For: ");
            for (x = 0; x <= 10; x++) {
                Console.Write(x + " "); //outputs the current loop number with a space
                x++; //add 1
            } x = 0; //reset to 0

            //--- Reversed For Loop ---\\
            Console.WriteLine("\n\n0-10 For: ");
            for (x = 100; x >= 90; x--) {
                Console.Write(x + " "); //outputs the current loop number with a space
            } x = 0; //reset to 0

            //--- Multiples of 5 Loop ---\\
            Console.WriteLine("\n\nMultiples of 5 For: ");
            for (x = 0; x <= 10; x++) {
                Console.Write((x*5) + " "); //outputs the current loop number multiplied by 5
            } x = 0; //reset to 0

            //--- Skip Multiples of 5 Loop ---\\
            Console.WriteLine("\n\nMultiples of 5 For: ");
            for (x = 0; x <= 20; x++) {
                if (x % 5 == 0) x++; //if its a multiple of 5 it adds 1 to skip to the next number
                Console.Write(x + " "); //outputs the current loop number with a space
            }x = 0; //reset to 0

            //just some formatting console output
            Console.WriteLine("------------------------------------------------------------------\n");
            Console.Write("\nWant to draw art? Enter ‘continue’ or ‘quit’: ");

            while (true)
            {
                userInput = Console.ReadLine().ToLower();
                switch (userInput)
                {
                    case "continue":
                        Console.Write("Enter a width (3 or more): ");
                        while (true)
                        {//loops until they give a usable input
                            width = int.Parse(Console.ReadLine());
                            if (width >= 3) break;//asks again if its a bad input
                            else Console.Write("Number must be 3 or greater. Enter a width:");
                        }

                        Console.Write("Enter a height (3 or more): ");
                        while (true)
                        {//loops until they give a usable input
                            height = int.Parse(Console.ReadLine());
                            if (height >= 3) break;//asks again if its a bad input
                            else Console.Write("Number must be 3 or greater. Enter a height:");
                        }
                        drawRectangle(width, height, true);
                        drawRectangle(width, height, false);
                        Console.Write("\nWant to draw art? Enter ‘continue’ or ‘quit’: ");
                        break;

                    case "quit"://closes the program after saying goodbye
                        Console.WriteLine("Goodbye!");
                        return;
                    
                    default://happens if they do a wrong input
                        Console.Write("I don’t recognize that. Enter ‘continue’ or ‘quit’: ");
                        break;
                }
            }

            //this method makes a rectangle with 3 variables
            //the fill variable is to make either just the borders or a full one
            void drawRectangle(int width, int height, bool fill)
            {
                Console.WriteLine("");
                switch (fill)//checks what type of rectangle to draw
                {
                    case true://if the rectangle should be filled
                        for (int i = 0; i <= height; i++) {
                            for (int u = 0; u <= width; u++){
                                Console.Write("O");//just print a bunch of 0s
                            }
                            Console.Write("\n");//indents to make the height of the rectangle
                        }
                        break;

                    case false://if the rectangle should be borders only
                        for (int i = 0; i <= height; i++){
                            for (int u = 0; u <= width; u++){
                                if ((i > 0 && i < height) && !(u == 0 || u == width))    
                                    Console.Write(" ");//prints a space if not a border
                                else Console.Write("O");
                            }
                            Console.Write("\n");//indents to make the height of the rectangle
                        }
                        break;
                }
            }

        }
    }
}