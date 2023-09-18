//Joaquin Schroth    
//14/09/2023
//this program tests out a bunch of different functions
//and helps us practice reading documentation and doing operations in variables

using System.Threading.Tasks.Dataflow;

namespace PE4_MathMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--- Variables ---\\
            string playerName = "Bobby McBobberson";
            int hoursPlayed = 274;
            
            //Point One Coords
            int xOne = -13;
            int yOne = 51;
            //Point Two Coords
            int xTwo = 17;
            int yTwo = 28;
            //Distance between point 1 and 2
            double distance = Math.Sqrt(Math.Pow((xTwo-xOne),2)+Math.Pow((yTwo-yOne),2));
            int roundDist = (int) Math.Round(distance);
            double roundDist3f = Math.Round(distance, 3);

            //Arithmetic Operator Vars
            double numA = 7.9;
            double numB = 2.25;
            //sum of numA and numB
            double sumOfDoubles = numA + numB;
            //sum of truncated numA and numB
            int sumOfInts = ((int) numA) + ((int) numB);
            
            //Trigonometry vars
            double degrees = 60;
            double radians = degrees * (Math.PI / 180);

            //--- Console Output ---\\
            Console.WriteLine("--- DDITION --");
            Console.WriteLine("Number A: " + numA);
            Console.WriteLine("Number B: " + numB);
            Console.WriteLine(numA + " + " + numB + " = " + sumOfDoubles);
            Console.WriteLine("Now I'll add just the whole number parts: ");
            Console.WriteLine(((int) numA) + " + " 
                            + ((int) numB) + " = " 
                            + sumOfInts);

            Console.WriteLine("--- DIVISION and MODULUS ---");
            Console.WriteLine(playerName + " has played a game for " 
                            + hoursPlayed + " hours.\n" 
                            + "They have played for "
                            //first it subtracts the extra hours and then converts
                            //to days, the subtracted remainder is the extra hours
                            + ((hoursPlayed-(hoursPlayed%24))/24) + " Days and " 
                            + (hoursPlayed % 24) + " Hours.");

            Console.WriteLine("--- SINE and COSINE ---");
            //prints out the sine and cosine of 60 degrees
            Console.WriteLine(degrees + " degrees is " + radians + " radians.");
            Console.WriteLine("The sine is " + (Math.Sin(radians)));
            Console.WriteLine("The sine is " + (Math.Cos(radians)));

            Console.WriteLine("-- DISTANCE ---");
            //prints out the coordinates of 2 points and give you the distance between them
            Console.WriteLine("Point One: (" + xOne + ", " + yOne + ")");
            Console.WriteLine("Point Two: (" + xTwo + ", " + yTwo + ")");
            Console.WriteLine("The distance between these points is " + distance);

            Console.WriteLine("--- ROUNDING ---");
            //prints out therounded distance from point to point
            Console.WriteLine("The distance is " + distance);
            Console.WriteLine("That is approximately " + roundDist + " units, or "
                            + roundDist3f + " to be more precise.");

            Console.WriteLine("--- COMPARISON ---");
            //prints out thelarger between 2 numbers
            Console.WriteLine("Let's compare 2 numbers: " + numA + "and" + numB);
            Console.WriteLine((Math.Max(numA, numB)) + " is the larger value.");
        }
    }
}