//Joaquin schroth
//09/24/2023
//this is a homeowrk assignment and it has 2 activities
//for activity 1 we ask the user for inputs and then give some facts and stuff based on them
//for activity 2 we ask for a bunch of inputs from the user which then are used to write a story

namespace SchrothJ_HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--- Activity 1 Variables ---\\
            //Activity 1 Vars
            string firstName = "";
            string lastName = "";
            string nickname = "";
            double age = 0;
            int nameDifference = 0;
            //Earth orbit around sun speed
            const int AvgOrbitalSpeedMPH = 66616;
            double milesAroundSun = 0;

            //--- Activity 2 Variables ---\\
            string animal = "";
            string name = "";
            string goodFeeling = "";
            string badFeeling = "";
            string adjective = "";
            string edgyWord = "";
            int num1 = 0;
            int num2 = 0;
            int num3 = 9;
            double percentage = 0.0;
            const int RandomConstant = 7;
            double demonLevel = 0;
            int blows = 0;
            double animalNumber = 0;
            //sory i dont really have the time to change stuff i read this part way too late
            float halfYear = 182.625f;

            //--- Activity 1 Console Output ---\\
            //asks the user for inputs
            Console.WriteLine("Insert your name and age(decimals allowed)");
            AskForInput("First Name: ", ref firstName);
            AskForInput("Last Name: ", ref lastName);
            AskForInput("Age: ", ref age);
            //outputs the user's name and last name based on their inputs
            Console.WriteLine($"\nWelcome {firstName} {lastName}!");
            //creates their nickname with the first 3 letters of their first
            //and 3 last letters of their last, then prints it
            nickname = (firstName.Substring(0, 3)) + lastName.Substring(lastName.Length - 3);
            Console.WriteLine($"Your new nickname is {nickname}!");
            //prints out some facts about the user determined by their inputs
            Console.WriteLine("\nDid you know?");
            nameDifference = firstName.Length - lastName.Length; //the difference between the length of both names
            Console.WriteLine($"Your first name is {nameDifference} characters longer than your last name!");
            milesAroundSun = AvgOrbitalSpeedMPH * YearsToHours(age); //multiplies the constant speed by the time(hours)
            Console.WriteLine($"The Earth goes arond the sun at a speed of {AvgOrbitalSpeedMPH} MPH");
            Console.WriteLine($"You've travelled {milesAroundSun} Miles around the sun " +
                              $"during your {age} years on earth!");

            //--- Activity 2 Console Input ---\\
            //asks for inputs from the user to set variables
            Console.WriteLine("\n\nNow give me some details to create a story");
            AskForInput("Enter an animal: ", ref animal);
            AskForInput("Enter a name: ", ref name);
            AskForInput("Enter a good feeling: ", ref goodFeeling);
            AskForInput("Enter a bad feeling: ", ref badFeeling);
            AskForInput("Enter a bad adjective: ", ref adjective);
            AskForInput("Enter an edgy nickname: ", ref edgyWord);
            AskForInput("Enter a whole number from 1-10: ", ref num1);
            AskForInput("Enter another whole number from 1-10: ", ref num2);
            AskForInput("Enter and another whole number from 1-100: ", ref num3);
            AskForInput("Enter apercentage in the form of a decimal(i.e. 0.33 = 33%): ", ref percentage);
            
            //--- Activity 2 Setting Up Vars ---\\
            //making all answers into full caps
            animal = animal.ToUpper();
            name = name.ToUpper();
            goodFeeling = goodFeeling.ToUpper();
            badFeeling = badFeeling.ToUpper();
            adjective = adjective.ToUpper();
            edgyWord = edgyWord.ToUpper();
            //setting the demon king's level to be higher than the hero's always
            demonLevel = num3 + (num3 * percentage);
            //setting the number of blows they shared
            blows = RandomConstant * num1 * num2;
            //the amount of animals that fall from the sky, a percentage of the blows they shared
            animalNumber = blows * percentage + RandomConstant;

            //--- Activity 2 Full Story console Output ---\\
            //literally just outputs the whole story using the data inputted
            Console.WriteLine($"\n\nOnce upon a time, in the {goodFeeling} kingdom a Hero named {name} was born.");
            Console.WriteLine($"The hero's sole goal was to slay the {adjective} Demon King, with his trusted weapon " +
                              $"the \"{edgyWord}\", \nhowever what most people didnt know about {name} " +
                              $"was that {name} is incredibly {badFeeling}.\n" +
                              $"However this did not stop the Hero from moving forward, and after defeating " +
                              $"the demon king's {num1} strongest subordinates, \nhe finally reached the Demon King.\n" +
                              $"It was a hard battle, with the hero being only level {num3} and the Demon King " +
                              $"being level {demonLevel}, \nhowever {name} managed to get his hands on " +
                              $"the {num2} sacred relics which evened the playing field.\n" +
                              $"With them having exchanged over {blows} blows, the battle was " +
                              $"finally coming to an end.\n" +
                              $"The Hero, {name}, knowing this was his last chance musters up all his power for " +
                              $"a single final blow, \nand the Demon King matching him does the same, and at " +
                              $"the moment theyre about to collide, \nsuddenly {animalNumber} {animal}s fall from the " +
                              $"sky and destroyed the world, \nguess the hero wasnt able to save the world after all");
            Console.WriteLine($"\nTHE END!!! Did you like it? cuz i didnt, the ending was truly {adjective}!");
            Console.ReadLine(); //aesthetics
        }

        //--- User Input Getters ---\\
        //these methods were made so i could ask for input in 1 line
        static void AskForInput(string prompt, ref string userInput)
        {
            Console.Write(prompt); // prompt the user for the variable
            userInput = Console.ReadLine();
        }
        //overload for doubles
        static void AskForInput(string prompt, ref double userInput)
        {
            Console.Write(prompt);
            userInput = double.Parse(Console.ReadLine());
        }
        //overload for ints
        static void AskForInput(string prompt, ref int userInput)
        {
            Console.Write(prompt);
            userInput = int.Parse(Console.ReadLine());
        }

        //converts from years to hours
        static double YearsToHours(double years)
        {
            const double DaysInYear = 365.25; //365 days in a year (365.25 acounting for leap years)
            const int HoursInDay = 24; //24 hours in a day
            double days = years * DaysInYear;
            double hours = days * HoursInDay;
            return hours; //returns the hours converted from years
        }
    }
}