//Joaquin schroth
//09/08/2023
//a homewor to get us more used to switch statements and basic game like story branching
//Note: honestly this lacks comments and its just a lot of text
//i started writing the story and i just wanted it to have all my ideas
//its honestly way too long and the code looks really bad and is confusing, 
//this is mostly because i did this in a rush and didnt plan out everything before coding
//which was a mistake especially for a branching story type project, i also apologize
//but i didnt read the part about the scene being the same at the start even after choices
//and then the rest being different, i did it differently... btw this story is really bad and bs 
//so please dont judge it too hard, also sorry its so much text... it should work perfectly though

using System.Collections;
using System.ComponentModel.Design;

namespace SchrothJ_HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--- Variables ---\\
            bool hasWeapon = false;
            int time = 6;
            bool scratch = false;
            string choice = "";


            //--- Console Output ---\\
            Console.Write(//story output
                "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                "Scene 1 - Home \n\n" +
                "It is very early in the morning, the sun is barely out. \n" + 
                "you hear a bunch of noise coming from outside, but youre still tired \n" + 
                "since you were playing games until late last night.\n" +
                "Time: 6AM\n" +
                "Will you keep sleeping? (yes/no) \n> "
            );

            switch(choice = Console.ReadLine().Trim().ToUpper())//changes output based on input
            {
                case "YES":
                    Console.WriteLine(//story output
                        "\nYou wake up a few hours later, you notice the noise from earlier is gone\n" +
                        "and wonder what it was... ignoring that you notice your hunger and decide\n" +
                        "to go outside, after changing your clothes you put on your headphones and start\n" +
                        "walking towards the nearby convenience store... \nTime: 6PM"
                    );
                    time = 18;
                    break;

                case "NO":
                    Console.Write(//story output
                        "\"Ugh fine, guess ill wake up, " +
                        "what's all this noise for anyways?\"\n" +
                        "You walk outside your apartmnt with your eyes half closed...\n" +
                        "\"Huh?\"\n" +
                        "You see blood splattered all over the floor outside, the suddenly" +
                        "\n you hear a scream from the room next to yours. \n" +
                        "You immediately take out your phone and try to contact the police, \n" +
                        "however, the police doesnt answer any of your calls, \n " +
                        "you notice their door is open and immediately grab a bat fpr safety and\n" +
                        "runfor the door, as soon as you open the door in the poorly lit room you see\n" +
                        "a man forcefully on top of a woman, with no hesitation you charge at him\n" +
                        "and hit him with the bat, pushing him off the woman, as quickly as possible\n" +
                        "you help the woman up and run out the apartment with her, once youre outside\n" +
                        "you look back into the apartment, with the wind having moved the blinds you see\n" +
                        "the man on the floor, covered in blood, so much blood, with torn up clothes.\n" +
                        "Time: 7AM\n" +
                        "What will you do? (A: Run away, B: Ask if the woman is alright)\n> "
                    );
                    time = 7;
                    hasWeapon = true;
                    switch (choice = Console.ReadLine().Trim().ToUpper())//changes output based on input
                    {
                        case "A":
                            Console.Write(//story output
                                "You immediately put the pieces together... and start running for your life" +
                                "\"F*********CK!!!\"\n" +
                                "\"Its a f**king zombie apocalypse!!!\"\n" +
                                "you look back and see the woman covered in blood chasing you\n" +
                                "Time: 7AM\n"
                            );
                            time = 7;
                            hasWeapon = true;
                            scratch = false;
                            break;

                        case "B":
                            Console.Write(//story output
                                "You notice the woman is oddly quet, so you turn back to ask if shes okay.\n" +
                                "\"Are you oka-\"\n" +
                                "The woman pushes you to the ground and thats when you finally realizewhats started\n" +
                                "The thing only happens in games and movies, the one virus worse than covid...\n" +
                                "A zombie apocalypse." +
                                "You somehow manage to push her off you with sheer adrenaline and start running.\n" +
                                "Time: 7AM\n"
                            );
                            hasWeapon = true;
                            scratch = true;
                            time = 7;
                            break;
                        default:
                            Console.WriteLine("BAD INPUT, do it right, dumb*ss");
                            return;
                    }
                    break;
                default:
                    Console.WriteLine("BAD INPUT, do it right, dumb*ss");
                    return;
            }
            switch(time)
            {
                case 7:
                    Console.Write(//story output
                        "\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                        "scene 2 - Outside\n\n" +
                        "You look back and see the woman still chasing you, you take some sharp turns\n" +
                        "and finally lose her after a while." +
                        "you think of running to the convenience store to get some supplies and find people.\n" +
                        "After a while you finally arrive. \nTime: 8AM\n" +
                        "The convenience store in half destroyed and through the broken windows you see\n" +
                        "the convenience store's worker and another person trying to defend themselves from\n" +
                        "2 zombies\n" +
                        "Time: 8AM\n" +
                        "Do you want to go help? (yes/no) \n> "
                    );
                    choice = Console.ReadLine();
                    Console.WriteLine("what you want doesnt matter, youll save them anyways");
                    break;

                case 18:
                    Console.Write(//story output
                        "\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                        "scene 2 - Outside\n\n" +
                        "Focused on the music you dont " +
                        "notice much about whats around you, \nand when you finally see the convenience store\n" +
                        "up ahead you notice something is wrong, you atop in your tracks. \n\"Huh?\"\n" +
                        "You look around more and notice there are a bunch of bloodstains splattered\n" +
                        "around many places, and there are no peope around, you wonder what the f is happening\n" +
                        "\"What the f is happening?\"" +
                        "\nTime: 7PM" +
                        "What will you do? (A: Look around, B: Go inside) \n> "
                    );
                    switch(choice = Console.ReadLine().Trim().ToUpper())//changes output based on input
                    {
                        case "A":
                            Console.Write(//story output
                                "You look around the store carefully and notice a crowbar on the ground behind the store\n" +
                                "you take it just in case, but right after taking it something suddenly starts approaching\n" +
                                "you from behind, you look back and see that its covered in blood, this finally confirming\n" +
                                "what you were already thinking about, the reason there no people and evrything is seeminlgly\n" +
                                "in chaos, its a zombie apocalypse!!!\n" +
                                "you take the crowbar and hit the zombie until it dies, at least you have a weapon, but\n" +
                                "youll need supplies, so you carefully head into the convenience store.\n" +
                                "Time: 8PM\n"
                            );
                            time = 20;
                            hasWeapon = true;
                            break;
                        case "B":
                            Console.Write(//story output
                                "Not fully understanding whats going on, you go into the convnience store...\n" +
                                "Time: 7PM"
                            );
                            time = 19;
                            break;
                        default:
                            Console.WriteLine("BAD INPUT, do it right, dumb*ss");
                            return;
                    }
                    break;
                default:
                    Console.WriteLine("BAD INPUT, do it right, dumb*ss");
                    return;
            }
            Console.WriteLine(
                "\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                "Scene 3 - Convenience Store\n"
            );
            if (time >= 18 && hasWeapon)
                Console.WriteLine(//story output
                    "You go into th convenience store with your crowbar in hand, you slowly but surely\n" +
                    "take out the 3 zombies in the store, however you didnt notice the time, by the time\n" +
                    "you finished collecting your supplies it had already become nightime...\n" +
                    "you hadnt noticed yet but with the convenience store being the brightest source\n " +
                    "of light around, all the zombies in the area were attracted, by the time you noticed \n" +
                    "it was already way too late, youd been surrounded by countless zombies and no matter\n" +
                    "how many of them you killed, more just kept coming...\n" +
                    "In the end you couldnt save youself, if only you had woken up earlier..." +
                    "Time: 9PM" +
                    "Ending 1/4"
                );
            else if (time >= 18 && !hasWeapon)
                Console.WriteLine(//story output
                    "You look around for a bit inside the store when suddenly youre jumped by 4 people\n" +
                    "cosplaying as zombies, You died without ever understanding what was going on...\n" +
                    "How are you this much of an airhead?\n" +
                    "Time: 8PM\n" +
                    "Ending 2/4"
                );
            else if (time < 18 && scratch)
                Console.WriteLine(//story output
                    "you go into the store and quickly take care of the 2 zombies attacking them,\n" +
                    "while fighting them your arm started hurting and then started feeling really\n" +
                    "numb, you managed to save them but once you take a look at your arm, its got\n" +
                    "some scratches on it, you remember the time when the woman pinned you down,\n" +
                    "maybe you didnt notice it before because of the adrenalin. \n\"Fuck!\"\n" +
                    "You get the 2 survivors to lock you in the bathroom while they escape.\n" +
                    "You become a zombie and live trapped in a bathroom for the rest of time..." +
                    "If only you'd noticed the woman was a zombie sooner...\n" +
                    "Time: 11AM" +
                    "\nEnding 3/4"
                );
            else if (time < 18 && !scratch)
                Console.WriteLine(//story output
                    "you go into the store and quickly take care of the 2 zombies attacking them,\n" +
                    "after scavenging for supplies from the store, the 3 of you decide to leave in\n" +
                    "search of a safer place... is this the end? or is it the beginning...\n" +
                    "Time: 10AM\n" +
                    "Ending 4/4 (its not the beginning of anything, its just bs)"
                );
            Console.ReadLine();
        }
    }
}
