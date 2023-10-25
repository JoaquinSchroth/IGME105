namespace W1D3_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int[] numbers = { 12, 13, 15, 12, 1, 78};
            /*
            for (int i = 0; i < numbers.Length; i++)
                number = Math.Max(number, numbers[i]);
            */
            foreach (int i in numbers)
                number = Math.Max(number, i);
            Console.WriteLine(number);
        }   
    }
}