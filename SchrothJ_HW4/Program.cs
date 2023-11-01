//Joaquin Schroth
//10/28/2023
//this is homework assignment 4 and its purpose is probably to test our knowledge
//on the topics weve learned so far and help us get accustomed to using stuff
//in this program specifically we do a bunch of calculations for grades and stuff 
//using arrays and this homework seems to be mostly for learning arrays and methods
//
// Iwould like to use a grace period for this assignment, i didnt complete it ontime so... yeah

namespace SchrothJ_HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--- Variables ---\\
            int numOfGrades = 0;//number of grades
            string[] assiNames;//array with assignment names
            double[] assiGrades;//array with assignment grades
            int changeIndex = 0;//the index at which they want to change a grade

            while (true)
            {//this while asks for the number of assignments they wish to save
                Console.Write("How many assignments are you saving? ");
                bool success = int.TryParse(Console.ReadLine(), out numOfGrades);//user input
                if (success && numOfGrades > 0) break;//if they give a valid input
                Console.WriteLine("(Must be a positive non-zero integar)");//not a valid input
            }
            
            Console.WriteLine($"You are saving {numOfGrades} assignments.");
            //initializing the arrays with the specified size inputted
            assiNames = new string[numOfGrades];
            assiGrades = new double[numOfGrades];
            
            for (int i = 0; i < numOfGrades; i++)
            {//asks for the name and grade of each assignment in the arrays
                Console.Write($"\nEnter name for assignment #{i+1}: ");
                assiNames[i] = Console.ReadLine();
                while (true)
                {//asks for the rade input
                    Console.Write($"Enter grade for {assiNames[i]}: ");
                    bool success = double.TryParse(
                        Console.ReadLine(), out assiGrades[i]);
                    //if its a double and is between 0-100
                    if (success && assiGrades[i] >= 0 && assiGrades[i] <= 100)
                        break;//breaks if its a usable input
                    Console.WriteLine("(Must be between 0 and 100.)");//else just prints this
                }
            }
            
            //--- Grade Report Output ---\\
            Console.WriteLine("\nAll grades were entered!\n");
            Console.WriteLine("Grade Report: ");
            //prints the assignment names and grades for each one
            PrintArray(assiNames, assiGrades);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Average: " + CalculateAverage(assiGrades));

            while (true)
            {//asks for an index until a valid one is given
                Console.Write("\nWhat grade do you want to replace? ");
                bool success = int.TryParse(Console.ReadLine(), out changeIndex);
                //if its an int and within the index range
                if (success && 1 <= changeIndex && numOfGrades >= changeIndex){
                    changeIndex--;//subtracts 1 because the array index starts at 0
                    break;
                }
                //prints this out if it doesnt  get a usable index
                Console.WriteLine($"Index must be between 1 and {numOfGrades}. Try again.");
            }
            
            while (true)
            {//asks for inpu until it gets a usable input alue for the grade
                Console.Write($"What is the new value for {assiNames[changeIndex]}? ");
                bool success = double.TryParse(
                    Console.ReadLine(), out assiGrades[changeIndex]);
                if (success && assiGrades[changeIndex] >= 0 && assiGrades[changeIndex] <= 100)
                    break;//only happens after theyve put in a usable input, 
                Console.WriteLine("(Must be between 0 and 100.)");
            }
            //prints out which grade was changed and to what
            Console.WriteLine($"\nReplacing grade at index {changeIndex+1}" +
                              $" with {assiGrades[changeIndex]}");
            
            //prints out the final report with all the info we calculated
            PrintFinalReport(assiNames, assiGrades);

            Console.Read();
        }//End of main

        /// <summary>
        /// it prints the names and grades of each assignment
        /// </summary>
        /// <param name="names"></param>
        /// <param name="grades"></param>
        public static void PrintArray(string[] names, double[] grades)
        {
            int arrLength = names.Length;//the length of the array
            for (int x = 0; x < arrLength; x++)//repeat once for each item in array
                //prints it with the index +1 because indexstarts at 0
                Console.WriteLine($"  {x + 1}. {names[x]}: {grades[x]}");
        }

        /// <summary>
        /// it calculates the average of every number in an array of doubles
        /// </summary>
        /// <param name="grades"></param>
        /// <returns></returns>
        public static double CalculateAverage(double[] grades)
        {
            double total = 0;//the sum of all items in array
            //adds all items together
            foreach (double num in grades) total += num;
            return total / grades.Length;//returns the total divided by the amount of items
        }

        /// <summary>
        /// it returns the amount of items in an array bigger than their average value
        /// </summary>
        /// <param name="grades"></param>
        /// <returns></returns>
        public static int AboveAverage(double[] grades)
        {
            int gradeAbove = 0;//number of items above average
            //checks eachitem and if its above average it adds 1 to the count
            foreach (double grade in grades)
                if (grade > CalculateAverage(grades)) gradeAbove++;
            return gradeAbove; //returns the number of values above average
        }

        /// <summary>
        /// returns the highest number in an array
        /// </summary>
        /// <param name="grades"></param>
        /// <returns></returns>
        public static double Highest(double[] grades)
        {
            double highest = 0;//sets it to the lowest possible grade
            //check every item and if its bigger it replaces the num
            foreach (double grade in grades) if (highest < grade) highest = grade;
            return highest;//returns biggest number
        }
        
        /// <summary>
        /// returns the lowest number in an array
        /// </summary>
        /// <param name="grades"></param>
        /// <returns></returns>
        public static double Lowest(double[] grades)
        {
            double lowest = 100;//sets it to the highest possible grade first
            //checks each grade and if its lower it sets the numberto it
            foreach (double grade in grades) if (lowest > grade) lowest = grade;
            return lowest;//returns the lowest value
        }

        /// <summary>
        /// checks if there are duplicate values in an array
        /// </summary>
        /// <param name="grades"></param>
        /// <returns></returns>
        public static bool HasDuplicates(double[] grades)
        {
            int count = 0;//number of matching numbers in array
            //checks every value inside the array once
            foreach (double grade1 in grades)
            {
                //checks every value inside the array once
                foreach (double grade2 in grades)
                    if (grade1 == grade2) count++;//checks for matching values
                // 1 would mean it matched withitself, while 2 or more means it repeats
                if (count >= 2) return true;//thus if its more than 1 it returns true
                else count = 0;//else it resets the counter to 0 to try with the next grade
            }
            return false;//if it didnt return true before, it returns false
        }

        /// <summary>
        /// fully pints out to the console the final report
        /// this report has all the calculations and formatting for the info we need
        /// </summary>
        /// <param name="names"></param>
        /// <param name="grades"></param>
        public static void PrintFinalReport(string[] names, double[] grades)
        {
            //this is all just console output
            Console.WriteLine("\nFinal Grade Report: ");
            PrintArray(names, grades);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Final Average: " + CalculateAverage(grades) + "\n");
            Console.WriteLine(AboveAverage(grades) + " grades are above average.");
            Console.WriteLine();
            Console.WriteLine($"The highest grade is {Highest(grades)}.");
            Console.WriteLine($"The lowest grade is {Lowest(grades)}.\n");
            if (HasDuplicates(grades))
                Console.WriteLine($"A grade appears more than once in this set of grades.");
            else Console.WriteLine($"All grades are unique.");
        }

    }
}