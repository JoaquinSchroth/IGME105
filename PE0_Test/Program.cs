namespace W1D3_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dat = DateTime.Now;
            Console.WriteLine("The time: {0:d} at {0:t}", dat);
            TimeZoneInfo tz = TimeZoneInfo.Local;
            Console.WriteLine("The time zone: {0}\n",
                              tz.IsDaylightSavingTime(dat) ?
                                 tz.DaylightName : tz.StandardName);
            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.A) { }
        }   
    }
}