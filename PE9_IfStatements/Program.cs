//Joaquin schroth
//09/26/2023
//this is made to learn about conditionals and simple game AI

namespace PE9_IfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--- Variables ---\\
            string npcSense = "";
            string magicType = "";

            //--- Pseudo Code ---\\
            //introduce the program
            //ask for what the npc sensed
            //if they sensed a mage
            //----attack with abow
            //if they sensed an archer
            //----attack with a sword
            //if they sensed a swordsman
            //----attack with either fire or lightning
            //----if neither self destruct
            //if something else is sensed
            //----ponder the meaning of life
            //END
            
            //--- Console Output ---\\
            Console.WriteLine("Character: NPC");
            Console.WriteLine("Your choices are:  'swordsman' 'archer' 'mage'");
            Console.Write("\nWhat does the NPC in your game sense? ");
            //get cleaned up user input
            npcSense = Console.ReadLine().ToLower().Trim();
            if (npcSense == "archer") //archers lose to swords
                Console.WriteLine("NPC Attacks with a sowrd!");
            else if (npcSense == "mage") //mages lose to bows
                Console.WriteLine("NPC Attacks with a bow!");
            else if (npcSense == "swordsman") { //swordsmen lose to magic
                Console.Write("\nAttack with 'fire' or 'lightning'? ");
                //get cleaned up player input
                magicType = Console.ReadLine().ToLower().Trim();
                if (magicType == "fire")
                    Console.WriteLine("NPC Attacks with Fire!");
                else if (magicType == "lightning")
                    Console.WriteLine("NPC Attacks with Lihtning!");
                else { //if their choice is anything other than fire or lightning
                    Console.WriteLine("NPC gathers its magic and self destructs!");
                }
            } else { //if the npc senses something different from options
                Console.WriteLine("The NPC ponders the meaning of life...");
            }

            Console.ReadLine();
        }
    }
}