using Microsoft.Win32.SafeHandles;
using System;
//Joaqin Schroth
//08/30/2023
//it prnts out a character's stats
//btw for a hidden secret type "password" and then enter ._.
namespace PE2_StatementsExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prints char name
            Console.WriteLine("Name: " + "Hugh Jazz \n");
            //multiplying by 0.2 which is the same as 20%
            Console.WriteLine("STR - " + (50*0.2));
            //taking first value and dividing it by 2
            Console.WriteLine("DEX - " + (50*0.2)/2);
                                       //7
            Console.WriteLine("INT - " + 7);
            //this looks really ugly
            //just adds stat 2 and 3 and then subtracts 2
            Console.WriteLine("VIT - " 
                                + (((50*0.2)/2)+7-2));
                                //holy sh## this is long
                                //itd be better with variables
                                //anyways...
                                //it subtracts everything from 50
            Console.WriteLine("LUC - " + (50-(
                                            +(50*0.2)
                                            +((50*0.2)/2)
                                            +(7)
                                            +(((50*0.2)/2)+7-2)
                                            )));
            //prints out the total
            Console.WriteLine("\nTOTAL: " + "50");
            SecretThing();
        }

        public static void SecretThing()
        {
            //stuff
            String CustomHeader = "Custom Character Builder 1.0";
            char[] CharSentence = CustomHeader.ToCharArray();

            String CharName = "Unnamed";
            int Total = 50;
            int Str = 0;
            int Dex = 0;
            int Int = 0;
            int Vit = 0;
            int Luc = 0;
            String Code;
            Code = Console.ReadLine();
            if (Code == "password")
            {
                for(int x = 0; x < 3; x++)
                {
                    Console.Clear();
                    Console.Write("Loading");
                    Thread.Sleep(300);
                    Console.Write(".");
                    Thread.Sleep(300);
                    Console.Write(".");
                    Thread.Sleep(300);
                    Console.Write(".");
                    Thread.Sleep(300);
                }
                Console.Clear();
                foreach(char HeaderChar in CharSentence)
                {
                    Thread.Sleep(100);
                    Console.Write(HeaderChar);
                }
                Thread.Sleep(200);
                Console.WriteLine("\nPlease Insert character name");
                CharName = Console.ReadLine();
                Reset();
                ChangeStat();
            }

            void PrintStats()
            {
                Console.WriteLine("\nAllottable Points: " + Total + "/50");
                Console.WriteLine("Name: " + CharName);
                Console.WriteLine("STR - " + Str);
                Console.WriteLine("DEX - " + Dex);
                Console.WriteLine("INT - " + Int);
                Console.WriteLine("VIT - " + Vit);
                Console.WriteLine("LUC - " + Luc);
            }

            void Reset()
            {
                Console.Clear();
                Console.WriteLine(CustomHeader);
                PrintStats();
            }

            void ChangeStat()
            {
                String ChosenStat = "";
                int StatChange = 0;                
                Console.WriteLine("Insert the stat you wish to change(i.e. S, I, D)");
                ChosenStat = Console.ReadLine();
                Console.WriteLine("Insert number of points to assign(i.e. -2, 1, 10)");
                StatChange = Convert.ToInt32(Console.ReadLine());
                if (StatChange > 0) 
                {
                    if (Total - StatChange < 0) 
                    {
                        Console.WriteLine("ERROR Please try again.");
                        ChangeStat();
                        return;
                    }
                    if (ChosenStat == "S" || ChosenStat == "s")
                    {
                        Str += StatChange;
                        Total -= StatChange;
                        Reset();
                        ChangeStat();
                        return;
                    } 
                    else if (ChosenStat == "D" || ChosenStat == "d")
                    {
                        Dex += StatChange;
                        Total -= StatChange;
                        Reset();
                        ChangeStat();
                        return;
                    } 
                    else if (ChosenStat == "I" || ChosenStat == "i")
                    {
                        Int += StatChange;
                        Total -= StatChange;
                        Reset();
                        ChangeStat();
                        return;
                    } 
                    else if (ChosenStat == "V" || ChosenStat == "v")
                    {
                        Vit += StatChange;
                        Total -= StatChange;
                        Reset();
                        ChangeStat();
                        return;
                    } 
                    else if (ChosenStat == "L" || ChosenStat == "l")
                    {
                        Luc += StatChange;
                        Total -= StatChange;
                        Reset();
                        ChangeStat();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("ERROR Please try again.");
                        ChangeStat();
                        return;
                    }
                }

                else if (StatChange < 0) 
                {
                    if (Total - StatChange > 50) 
                    {
                        Console.WriteLine("ERROR Please try again.");
                        ChangeStat();
                        return;
                    }
                    if (ChosenStat == "S" || ChosenStat == "s")
                    {
                        if (Str + StatChange < 0)
                        {
                            Console.WriteLine("ERROR Please try again.");
                            ChangeStat();
                            return;
                        }
                        Str += StatChange;
                        Total -= StatChange;
                        Reset();
                        ChangeStat();
                        return;
                    } 
                    else if (ChosenStat == "D" || ChosenStat == "d")
                    {
                        if (Dex + StatChange < 0)
                        {
                            Console.WriteLine("ERROR Please try again.");
                            ChangeStat();
                            return;
                        }
                        Dex += StatChange;
                        Total -= StatChange;
                        Reset();
                        ChangeStat();
                        return;
                    }
                    else if (ChosenStat == "I" || ChosenStat == "i")
                    {
                        if (Int + StatChange < 0)
                        {
                            Console.WriteLine("ERROR Please try again.");
                            ChangeStat();
                            return;
                        }
                        Int += StatChange;
                        Total -= StatChange;
                        Reset();
                        ChangeStat();
                        return;
                    }
                    else if (ChosenStat == "V" || ChosenStat == "v")
                    {
                        if (Vit + StatChange < 0)
                        {
                            Console.WriteLine("ERROR Please try again.");
                            ChangeStat();
                            return;
                        }
                        Vit += StatChange;
                        Total -= StatChange;
                        Reset();
                        ChangeStat();
                        return;
                    }
                    else if (ChosenStat == "L" || ChosenStat == "l")
                    {
                        if (Luc + StatChange < 0)
                        {
                            Console.WriteLine("ERROR Please try again.");
                            ChangeStat();
                            return;
                        }
                        Luc += StatChange;
                        Total -= StatChange;
                        Reset();
                        ChangeStat();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("ERROR Please try again.");
                        ChangeStat();
                        return;
                    }
                }
            }
        }
    }
}