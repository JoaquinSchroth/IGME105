//Joaquin Schroth
//18/10/2023
//Activity 1: Artillery Golf
//write the code to simulate a game of “Artillery Golf”. 
//Given a distance to the hole (in meters), and the user’s 
//guess of an angle and speed of the cannonball, the code will 
//calculate how far away the cannonball will land.
//Activity 2: Leaps Tall Buildings in a Single Bound
//write a small program that determines the required velocity 
//for Superman to clear a tall building on various planets 
//with different gravitational constants

using System.Diagnostics;
using System.Drawing;

namespace SchrothJ_HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--- Cannon Variables ---\\
            int targetDistance = 751; //meters
            int attempts = 1; //number of attempts left
            double velocity = 0; //meters/sec
            double angle = 0; //degrees
            double distanceTravelled = 0; //distancetravelled after calculations
            double distancetoTarget = 0; //distance from the target

            //--- Superman Variables ---\\
            int buildingHeight = 660;
            double gravityConstant = 0;
            double requiredVelocity = 0;
            string userinput = "";

            //--- Cannon Console Output ---\\
            Console.WriteLine("Welcome to Artillery Golf!!!");
            Console.WriteLine($"Your goal is to hit a target {targetDistance} meters away.\n");

            while (attempts <= 10) 
            { //while you still have lees than 10 attempts
                Console.WriteLine($"\n\nAttempt {attempts} ----------------------------------");
                Console.WriteLine("Enter the cannon's angle and initial velocity: ");
                while (true) 
                {//repeat until theres a usable input
                    AskForInput("Angle (between 0 and 90 degrees): ", ref angle);
                    if (angle >= 0 && angle <= 90) {break;}
                    Console.WriteLine("Invalid Angle, please try again.");
                }
                Console.WriteLine(); //spacing
                while (true)
                {//repeat until theres a usable input
                    AskForInput("Initial Velocity (positive number): ", ref velocity);
                    if (velocity >= 0) {break;}
                    Console.WriteLine("Invalid Initial velocity, please try again.");
                }
                
                Console.WriteLine("\nThank you!");
                //all this prints out the result
                Console.WriteLine($"A cannonball fired with an initial velocity of {velocity} m/s");
                Console.WriteLine($"At an angle of {angle} degrees from the ground");
                
                //calculates the distance using a custom method
                distanceTravelled = CalculateDistance(angle, velocity);
                //siple distance calculcation between result and target
                distancetoTarget = targetDistance - distanceTravelled;
                
                Console.WriteLine($"Will strike the ground {distanceTravelled} meters away.");
                Console.WriteLine($"Youre {distancetoTarget} meters away from the target. ");
                
                //if its a succesful hit it breaks out of the while loop
                if (distancetoTarget >= targetDistance - 0.5 
                    && distancetoTarget <= targetDistance + 9.5)
                { Console.Write("A successful hit!!!"); break; }
                else Console.Write("Try Again!");
                
                attempts++; //number of attempts goes up as number of iterations of the loop go up
            }

            switch (attempts)
            {
                case 1: //if they did it on their first attempt
                    Console.WriteLine("\nWow you did it on your first try, thanks for playing!!!");
                    break;

                case <= 10: //if they managed to hit the target
                    Console.WriteLine("\nThanks for playing!");
                    break;

                default: //if they failed to hit the target
                    Console.Write("\nRan out of attempts, but thanks for playing!");
                    break;
            }

            Console.Write("\nPress any key to continue . . .");
            Console.ReadLine();

            //--- Superman Console Output ---\\
            Console.WriteLine($"\nYour target building height is {buildingHeight} feet.   ");
            Console.WriteLine("Enter the graviational constant for the planet on " +
                              "which Superman is currently attempting this jump.\n" +
                              "Units should be in feet/second^2.");
            while (true)
            {
                while (true)
                {//repeat until theres a usable input
                    AskForInput("\nGravitational Constant: ", ref gravityConstant);
                    if (gravityConstant > 0) { break; }
                    Console.WriteLine("Must be a positive number, please try again.");
                }
                
                //calculates the required velocity to jump over
                requiredVelocity = Math.Pow(2.0 * gravityConstant * buildingHeight, 0.5);
                Console.WriteLine($"Superman must jump with an initial elocity of " +
                                  $"at least {requiredVelocity} feet/second\n");

                while (true) 
                {
                    Console.Write("Would you like to try another value? (Y/N): ");
                    userinput = Console.ReadLine().ToUpper();
                    if (userinput == "N") 
                    {//ends the program if they say no
                        Console.WriteLine("\n\nThanks!");
                        Console.ReadLine();
                        return;
                    }
                    //breaks the while loop to reiterate thrugh the previous while loop
                    //only if the user wants to go again
                    else if (userinput == "Y")
                        break; 
                    //if they put an incorrect input they try again
                    else Console.WriteLine("Inavlid input.");
                }
            }
        }// End of Main

        static double CalculateDistance(double a, double v)
        {
            a = a * (Math.PI / 180.0); //convert to radians
            double vSqrd = Math.Pow(v, 2); //velocity squared
            double aSin = Math.Sin(a); //sin of a
            double aCos = Math.Cos(a); //cos of a
            double length = 2.0; //cannon barrel length (always 2)
            double flightTime = ((v * aSin) + Math.Pow((vSqrd 
                * Math.Pow(aSin, 2) + 20.0 * length * aSin), 0.5)) / 10.0;
            //returns the distance resulted
            return v * aCos * flightTime;
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
    }
}