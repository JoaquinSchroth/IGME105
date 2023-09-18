//JJoaquin Schroth
//15/09/2023
//does a bunch of stuff with strings and substrings

namespace PE5_sTRINGS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--- vARIABLES ---\\
            //just setting names for eveything
            string playerName = "Dash";
            string charName = "Chonkerino";
            string gameName = "Return of the Catfather";
            string weaponName = "Paws of Steel";
            //the UPPERCASE versio of the names
            string upperPlayer = playerName.ToUpper();
            string upperChar = charName.ToUpper();
            string upperGame = gameName.ToUpper();
            //differencebetween the length of both names
            //the example given was wrong? it said -5 instead of -6
            int difference = playerName.Length - charName.Length;
            //weirdest way of determining level...
            int level = Math.Abs(playerName.Length + difference);
            //takin pieces from other strings to make the sidekick's name
            char playerLetter1 = upperPlayer[0];
            string gameLetter2 = (gameName.Substring(0, 2)).ToLower();
            string charLetter2 = (charName.Substring(0, 2)).ToLower();
            string weaponName3 = (weaponName.Substring(0, 3)).ToLower();
            char weaponLastLetter = weaponName[weaponName.Length - 1];
            // the long af final combination of all the substrings
            string sideName = playerLetter1+gameLetter2+charLetter2+weaponName3+weaponLastLetter;

            //--- Console Output ---\\
            Console.WriteLine("Welcome " + playerName);
            Console.WriteLine("\nYour Game's Name is " + gameName);
            Console.WriteLine("Your Character's Name is " + charName);
            Console.WriteLine(charName + " wields the weapon " + weaponName);
            Console.WriteLine("Your name is " + playerName.Length + " characters long.");
            Console.WriteLine(upperPlayer + " is " + difference 
                            + " letters longer than " + upperChar);
            Console.WriteLine("Your character " + upperChar + " would start at level " + level);
            Console.WriteLine("Let’s come up with a sidekick name from " + upperGame + "...");
            Console.WriteLine("Your Sidekick's name would be " + sideName);

            Console.ReadLine();
        }
    }
}