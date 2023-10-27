//Joaquin schroth
//10/23/2023
//practicing with 1D arrys and static methods

namespace PE18_ArrayAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // makes an array with 4 colors and prints it out
            string[] colors = {"green", "red", "blue", "yellow"};
            PrintArray(colors);
            Console.WriteLine();

            // Init an array of 3 elements with the value “your starting data”
            string[] stringArray1 = new string[3];
            FillArray(stringArray1, "your starting data");
            PrintArray(stringArray1);
            Console.WriteLine();

            // Initialize an array of size 6 with “other starting data” 
            string[] stringArray2 = CreateAndFillArray("other  starting data", 6);
            PrintArray(stringArray2);
            Console.WriteLine();

            // Create array of strings
            int[] numbers = new int[]{41, 7, 19, 299, 8743, 2, 55};
            PrintArray(numbers);
            Console.WriteLine();

            // Find the smallest value
            int smallest = FindSmallestValue(numbers);
            Console.WriteLine("Smallest value is " + smallest);
            Console.WriteLine();

            // Find the largest value
            int largest = FindLargestValue(numbers);
            Console.WriteLine("Largest value is " + largest);
            Console.WriteLine();

            // Search for values
            bool exists = SearchForValue(numbers, 299);
            Console.WriteLine("Does array contain 299 ? " + exists);
            exists = SearchForValue(numbers, 8);
            Console.WriteLine("Does array contain 8 ? " + exists);

            Console.ReadLine();
        }//End of Main

        /// <summary>
        /// it takes in an array and prints out its contents
        /// </summary>
        /// <param name="array"></param>
        public static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(" *" + array[i]);
            }
        }

        /// <summary>
        /// fills the entire array with a specific value
        /// </summary>
        /// <param name="array"></param>
        /// <param name="startingValue"></param>
        public static void FillArray(string[] array, string startingValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = startingValue;
            }
        }

        /// <summary>
        /// returns a string array of a specified size filled with specified starting data
        /// </summary>
        /// <param name="startingValue"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static string[] CreateAndFillArray(string startingValue,int size)
        {
            string[] array = new string[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = startingValue;
            }
            return array;
        }

        /// <summary>
        /// prins a given array of integars
        /// </summary>
        /// <param name="array"></param>
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {//repeats once for each int in the array
                //prints the array of ints
                Console.WriteLine(" - " + array[i]);
            }
        }

        /// <summary>
        /// takes in an array and returns the smallest number in it
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int FindSmallestValue(int[] array)
        {
            int smallest = int.MaxValue;//declares with biggest nummber possible
            foreach (int num in array) //repeats for every item in array
                smallest = Math.Min(smallest, num);//returns the smaller number
            return smallest;//returns the resulting smallest number
        }

        /// <summary>
        /// takes in an array and returns the biggest number in it
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int FindLargestValue(int[] array)
        {
            int smallest = int.MinValue;//declares with smallest nummber possible
            foreach (int num in array) //repeats for every item in array
                smallest = Math.Max(smallest, num);//returns the bigger number
            return smallest;//returns the resulting biggest number
        }

        /// <summary>
        /// takes in an array and a value and returns if the value is in the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool SearchForValue(int[] array, int value)
        {
            foreach (int num in array)//checks each item once
                if (num == value) return true;//returns true if any item is equal
            return false;//if it doent return true it returns false
        }
    }
}