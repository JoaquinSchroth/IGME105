//Joaquin Schroth
//10/24/2023
//this program generates a random number and asks the user to gues what it is
//they get 8 tries, this program uses while loops and random numbers, we also
//use the new form of parsing we learned, so it lets us test out our bew knowledge

namespace PE19_NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--- Variables ---\\
            Random rnd = new Random();//new Random type object
            int randomNum = rnd.Next(101);//creates a number between 0 and 100 inclusive
            Console.WriteLine(randomNum);//console out of random num chosen for testing
            int userInput = 0;//where the user's guess is saved

            //--- Planning ---\\
            //ask for a number. inside a while loop and ask again if its
            //not a usable input or a wrong guess for the number
            //of course before that we should generate the corect number
            //and then prompt the player for a number

            //--- Console Output ---\\
            Console.WriteLine("Guess the random number, yo have 8 tries\n");
            for (int attempts = 1; attempts <= 8; attempts++)
            {//will repeat 8 times and end the loop after
                while (true)
                {//will repeat until they give a usable input
                    Console.Write($"Guess #{attempts}: ");
                    //getting and parsing input, at the same time checking if its parseable
                    bool success = int.TryParse(Console.ReadLine(), out userInput);
                    if (success) {break;}//if its usable inout it break the loop to continue
                    Console.WriteLine("Invalid input, try again.");
                }
                //if the guess is lower than the actual number prints this and continues
                if (userInput < randomNum)
                    Console.WriteLine("Too low!\n");
                //if the guess is higher than the actual number prints this and continues
                else if (userInput > randomNum)
                    Console.WriteLine("Too High!\n");
                else
                {//ends the program after telling you wou won
                    Console.WriteLine($"Correct!!! You won in {attempts} turns.");
                    Console.ReadLine();
                    return;//ends program
                }
            }
            //only runs if you exited the loop without ending the program
            Console.WriteLine($"You ran out of turns, the number was: {randomNum}.");
            Console.ReadLine();
        }//End of Main
    }
}