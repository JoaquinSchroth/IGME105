//Joaquin Schroth
//09/10/2023
//a program that prints the stats of a character to the console

namespace PE3_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables//////////
            string CharName = "Hugh Jerazz";
            //Characters star with 50 points
            const int START_P = 50;
            //Str is 20% of total starting points
            int Str = Convert.ToInt32(START_P * 0.2);
            //Dex is half of Str
            int Dex = Str / 2;
            //INT is always 7
            const int INT = 7;
            //Vit is Dex+Int minus 2
            int Vit = (Dex+INT) - 2;
            //Luc is the remaining points
            int Luc = START_P - (Str+Dex+INT+Vit);
            //Sum of all Stats' points
            int Total = Str + Dex + INT + Vit + Luc;

            //prints character name and all stats + the total to the console
            Console.WriteLine("Allottable Points: " + START_P);
            Console.WriteLine("Name: " + CharName);
            Console.WriteLine("STR - " + Str);
            Console.WriteLine("DEX - " + Dex);
            Console.WriteLine("INT - " + INT);
            Console.WriteLine("VIT - " + Vit);
            Console.WriteLine("LUC - " + Luc);
            Console.WriteLine("TOTAL: " + Total);

            Console.ReadLine();
        }
    }
}