// ***************************************************************************
// Joaquin schroth
// 10/20/2023
// Static methods starter file
// Purpose: Practice with writing static methods
// ***************************************************************************

using System.Numerics;
using System.Runtime.ExceptionServices;

namespace Methods_STARTER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Leave these variables here!
            // Setup variables necessary for testing all 6 methods
            bool success = false;
            int biggest = 0;
            string word = "";

            #region Method Tests in Main - Method #1 Testing
            DisplayHeadline("Makes Ten");

            success = MakesTen(9, 10);
            Console.WriteLine(
                "Do the values 9 and 10 add to 10? OR is one of the numbers 10? {0}",
                success);

            success = MakesTen(9, 9);
            Console.WriteLine(
                "Do the values 9 and 9 add to 10? OR is one of the numbers 10? {0}",
                success);

            success = MakesTen(1, 9);
            Console.WriteLine(
                "Do the values 1 and 9 add to 10? OR is one of the numbers 10? {0}",
                success);
            #endregion

            #region Method Tests in Main - Method #2 Testing
            DisplayHeadline("Largest");

            biggest = Largest(1, 2, 3);
            Console.WriteLine(
                "The largest value of 1, 2, and 3 is: {0}",
                           biggest);

            biggest = Largest(1, 3, 2);
            Console.WriteLine(
                "The largest value of 1, 3, and 2 is: {0}",
                           biggest);

            biggest = Largest(3, 2, 1);
            Console.WriteLine(
                "The largest value of 3, 2, and 1 is: {0}",
                           biggest);

            biggest = Largest(2, 1, 2);
            Console.WriteLine(
                "The largest value of 2, 1, and 2 is: {0}",
                           biggest);

            biggest = Largest(3, 3, 1);
            Console.WriteLine(
                "The largest value of 3, 3, and 1 is: {0}",
                           biggest);

            biggest = Largest(5, 5, 5);
            Console.WriteLine(
                "The largest value of 5, 5, and 5 is: {0}",
                           biggest);
            #endregion

            #region Method Tests in Main - Method #3 Testing
            DisplayHeadline("Not String");

            word = NotString("candy");
            Console.WriteLine("Your string 'candy' is now: {0}", word);

            word = NotString("x");
            Console.WriteLine("Your string 'x' is now: {0}", word);

            word = NotString("not bad");
            Console.WriteLine("Your string 'not bad' is now: {0}", word);

            word = NotString("nothing");
            Console.WriteLine("Your string 'nothing' is now: {0}", word);
            #endregion

            #region Method Tests in Main - Method #4 Testing
            DisplayHeadline("Remove Index");

            word = RemoveIndex("kitten", 1);
            Console.WriteLine("Your string 'kitten' removing 1 is now: {0}", word);

            word = RemoveIndex("kitten", 0);
            Console.WriteLine("Your string 'kitten' removing 0 is now: {0}", word);

            word = RemoveIndex("kitten", 5);
            Console.WriteLine("Your string 'kitten' removing 5 is now: {0}", word);

            word = RemoveIndex("kitten", 6);
            Console.WriteLine("Your string 'kitten' removing 6 is now: {0}", word);

            word = RemoveIndex("kitten", -1);
            Console.WriteLine("Your string 'kitten' removing -1 is now: {0}", word);

            word = RemoveIndex("a", 0);
            Console.WriteLine("Your string 'a' removing 0 is now: {0}", word);

            word = RemoveIndex("an", 0);
            Console.WriteLine("Your string 'an' removing 0 is now: {0}", word);
            #endregion

            #region Method Tests in Main - Method #5 Testing
            DisplayHeadline("Print Letters");

            PrintLetters("rabbit");
            PrintLetters("Hello");
            PrintLetters("");
            PrintLetters("Halloween!");
            #endregion

            #region Method Tests in Main - Method #6 Testing
            DisplayHeadline("Distance");

            double distance = Distance(0, 0, 0, 0);
            Console.WriteLine("The distance between (0, 0) and (0, 0) is: " + distance);

            distance = Distance(1, 0, 4, 4);
            Console.WriteLine("The distance between (1, 0) and (4, 4) is: " + distance);

            distance = Distance(10, 2, 3, 5);
            Console.WriteLine("The distance between (10, 2) and (3, 5) is: " + distance);
            #endregion
        }// End of Main - All static methods must be written AFTER this

        #region Sample Static Method!
        // Public static methods should be written between the Main method
        //    and the end of Program class curly brace. 

        /// <summary>
        /// Prints a formatted headline in the console window.
        /// </summary>
        /// <param name="textToDisplay">The text that should be displayed. Must not exceed 55 characters.</param>
        public static void DisplayHeadline(string textToDisplay)
        {
            // Determine the length of the string
            // Then create a string with all dashes of the appropriate length.
            string allDashes = "-------------------------";
            for(int i = 0; i < textToDisplay.Length; i++)
            {
                allDashes += "-";
            }

            // Print the resulting output
            Console.WriteLine();
            Console.WriteLine(allDashes);
            Console.WriteLine($"-------- {textToDisplay} method --------");
            Console.WriteLine(allDashes);
        }
        #endregion

        #region Static Methods to Write #1 - MakesTen
        // PUBLIC STATIC METHODS FOR STUDENTS TO WRITE:

        /// <summary>
        /// Given 2 integers, determine whether one of them is 10 or if their sum is 10.
        /// </summary>
        /// <param name="number1">First value</param>
        /// <param name="number2">Second value</param>
        /// <returns>True when one value is 10 or if the sum of values is 10. False otherwise.</returns>
        //checks if either one of 2 numbers given is ten or i their sum is 10
        public static bool MakesTen(int number1, int number2)
        {
            if (number1 == 10 || number2 == 10) return true;//checks if either is 10
            else if (number1 + number2 == 10) return true;//checks if sum is 10
            else return false;//if not 10 or sum to 10 returns false
        }
        #endregion

        #region Static Methods to Write #2 - Largest
        /// <summary>
        /// Returns the largest of three integers.
        /// </summary>
        /// <param name="number1">First value</param>
        /// <param name="number2">Second value</param>
        /// <param name="number3">Third value</param>
        /// <returns>Largest of the three integers.</returns>
        //returns the largest of 3 numbers
        public static int Largest(int number1, int number2, int number3)
        {
            int largest = number1;//sets largest to the first
            if (number2 > largest) largest = number2;//changes to the second if larger
            if (number3 > largest) largest = number3;//changes to the third if larger
            return largest;//returns the largest number
        }
        #endregion

        #region Static Methods to Write #3 - NotString
        //takes in a string and if it doesnt start with notit adds not to the start
        public static string NotString(string input)
        {
            //if its less than 3 characters
            if (input.Length < 3) return "not " + input;
            //if in the first 3 characters of the string 
            else if (input.Substring(0, 4).Contains("not ")) return input;
            //if it doesnt already have it or is smaller than 3 chars, it adds not
            else return "not " + input;
        }
        #endregion

        #region Static Methods to Write #4 - RemoveIndex
        //takes in a string and index and removes the char the the specified
        //index if the char isnt empoty or the index is within range
        public static string RemoveIndex(string input, int index)
        {
            //returns if index is out of range
            if (index >= input.Length || index < 0) 
                return "Index is out of range";
            //removs the character at the specified index
            string result = input.Remove(index, 1);
            //if empty returns <empty>
            if (result.Length == 0) return "<empty>";
            //it returns the string without the char at index
            else return result;
        }
        #endregion

        #region Static Methods to Write #5 - PrintLetters
        //takes in a string and prints it with dashes in between
        public static void PrintLetters(string input)
        {
            int loopIndex = 1;//the current index of the loop
            //for each character in input, it wirites the char with a -
            foreach (char chara in input) {
                Console.Write(chara); //prints char
                //breaks loop on last character so it doesnt write -
                if (loopIndex == input.Length) {
                    Console.Write("\n");//formatting
                    break;//breaks loop
                } Console.Write("-"); //prints - if not on the last letter
                loopIndex++;//increases index
            }
        }
        #endregion

        #region Static Methods to Write #6 - Distance
        //takes in 4 values(2 points) and calculkates the distance between them
        public static double Distance(double x1, double y1, double x2, double y2)
        {
            double distX = Math.Abs(x1-x2);
            double distY = Math.Abs(y1-y2);
            double distance = Math.Sqrt((distX*distX) + (distY*distY));
            return distance;
        }
        #endregion
    }// End of Program class - All static methods must be written BEFORE this
}// End of Namespace