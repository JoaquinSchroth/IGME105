//Joaquin Schroth
//09/18/2023
//a remake of PE 4 with more advanced techniques, specifically user inputs

namespace PE6_InputParsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--- Variables ---\\
            string playerName;
            int hoursPlayed;
            //Point One Coords
            int xOne;
            int yOne;
            //Point Two Coords
            int xTwo;
            int yTwo;

            //Distance between point 1 and 2
            double distance;
            int roundDist;
            double roundDist3f;

            //Arithmetic Operator Vars
            double numA;
            double numB;
            //sum of numA and numB
            double sumOfDoubles;
            //sum of truncated numA and numB
            int sumOfInts;

            //Trigonometry vars
            double degrees;
            double radians;

            //user input reading
            string userInput;

            //--- Console Output ---\\
            Console.WriteLine("--- ADDITION --");
            Console.Write("What is the first number?: ");
            userInput = Console.ReadLine();
            numA = Double.Parse(userInput);
            Console.Write("What is the second number?: ");
            userInput = Console.ReadLine();
            numB = Double.Parse(userInput);
            sumOfDoubles = numA + numB;
            sumOfInts = ((int)numA) + ((int)numB);
            Console.WriteLine(numA + " + " + numB + " = " + sumOfDoubles);
            Console.WriteLine("Now I'll add just the whole number parts: ");
            Console.WriteLine(((int)numA) + " + "+ ((int)numB) + " = " + sumOfInts);

            Console.WriteLine("--- DIVISION and MODULUS ---");
            Console.Write("What is the player's name?: ");
            userInput = Console.ReadLine();
            playerName = userInput;
            Console.Write("How many hours have they logged?: ");
            userInput = Console.ReadLine();
            hoursPlayed = Int32.Parse(userInput);
            Console.WriteLine(playerName + " has played a game for "
                            + hoursPlayed + " hours.\n"
                            + "They have played for "
                            //first it subtracts the extra hours and then converts
                            //to days, the subtracted remainder is the extra hours
                            + ((hoursPlayed - (hoursPlayed % 24)) / 24) + " Days and "
                            + (hoursPlayed % 24) + " Hours.");

            Console.WriteLine("--- SINE and COSINE ---");
            //prints out the sine and cosine of 60 degrees
            Console.Write("Enter an angle in degrees: ");
            userInput = Console.ReadLine();
            degrees = Int32.Parse(userInput);
            radians = degrees * (Math.PI / 180);
            Console.WriteLine(degrees + " degrees is " + radians + " radians.");
            Console.WriteLine("The sine is " + (Math.Sin(radians)));
            Console.WriteLine("The sine is " + (Math.Cos(radians)));

            Console.WriteLine("-- DISTANCE ---");
            Console.WriteLine("Calculate the distance between 2 points on a 2D coordiante plane.");
            Console.Write("Enter Point 1 X: ");
            userInput = Console.ReadLine();
            xOne = Int32.Parse(userInput);
            Console.Write("Enter Point 1 Y: ");
            userInput = Console.ReadLine();
            yOne = Int32.Parse(userInput);
            Console.Write("Enter Point 2 X: ");
            userInput = Console.ReadLine();
            xTwo = Int32.Parse(userInput);
            Console.Write("Enter Point 2 Y: ");
            userInput = Console.ReadLine();
            yTwo = Int32.Parse(userInput);
            //prints out the coordinates of 2 points and give you the distance between them
            Console.WriteLine("Point One: (" + xOne + ", " + yOne + ")");
            Console.WriteLine("Point Two: (" + xTwo + ", " + yTwo + ")");
            distance = Math.Sqrt(Math.Pow((xTwo - xOne), 2) + Math.Pow((yTwo - yOne), 2));
            Console.WriteLine("The distance between these points is " + distance);

            Console.WriteLine("--- ROUNDING ---");
            //prints out therounded distance from point to point
            roundDist = (int)Math.Round(distance);
            roundDist3f = Math.Round(distance, 3);
            Console.WriteLine("The distance is " + distance);
            Console.WriteLine("That is approximately " + roundDist + " units, or "
                            + roundDist3f + " to be more precise.");

            Console.WriteLine("--- COMPARISON ---");
            //prints out thelarger between 2 numbers
            Console.WriteLine("Let's compare 2 numbers: " + numA + " and " + numB);
            Console.WriteLine((Math.Max(numA, numB)) + " is the larger value.");

            ////--- Extra Variables ---\\
            //string favGame;
            //string favColor;
            //int favNum;

            ////--- Extra ---\\
            //Console.Write("Insert your favorite game: ");
            //favGame = Console.ReadLine();
            //Console.Write("Insert your favorite color: ");
            //favColor = Console.ReadLine();
            //Console.Write("Insert Favorite Number: ");
            //favNum = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Your Favorite game is " + favGame);
            //Console.WriteLine("and your Favorite color is " + favColor);
            //Console.WriteLine("Your Favorite Number +1 is " + (favNum+1));
            
            Console.ReadLine();
        }
    }
}