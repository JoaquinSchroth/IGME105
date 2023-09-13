//Joaquin Schroth    
//
//

namespace PE4_MathMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName;
            double hoursPlayer = 274.0;
            //Point One Coords
            int xOne = -13;
            int yOne = 51;
            //Point Two Coords
            int xTwo = 17;
            int yTwo = 28;
            //Arithmetic Operator Vars
            double numA = 7.9;
            double numB = 2.25;
            double sumOfDoubles = numA + numB;
            int sumOfInts = ((int) numA) + ((int) numB);
            //Trigonometry vars
            double degrees = 60;
            double radians = degrees * (Math.PI / 180);

            //Printing stuff to the console
            Console.WriteLine("--- DDITION --");
            Console.WriteLine("Number A: " + numA);
            Console.WriteLine("Number B: " + numB);
            Console.WriteLine(numA + " + " + numB + " = " + sumOfDoubles);
            Console.WriteLine("Now I'll add just the whole number parts: ");
            Console.WriteLine(((int) numA) + " + " 
                            + ((int) numB) + " = " 
                            + sumOfInts);
            Console.WriteLine("--- DIVISION and MODULUS ---");



        }
    }
}