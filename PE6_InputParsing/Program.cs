namespace PE6_InputParsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--- Variable ---\\
            string favGame;
            string favColor;
            int favNum;
            

            //--- Extra ---\\
            Console.Write("Insert your favorite game: ");
            favGame = Console.ReadLine();
            Console.Write("Insert your favorite color: ");
            favColor = Console.ReadLine();
            Console.Write("Insert Favorite Number: ");
            favNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your Favorite game is " + favGame);
            Console.WriteLine("and your Favorite color is " + favColor);
            Console.WriteLine("Your Favorite Number +1 is " + (favNum+1));

            //--- Console Output ---\\







            Console.ReadLine();
        }
    }
}