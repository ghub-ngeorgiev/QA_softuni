using System.Threading.Channels;

namespace _04.MandatoryLiterature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPagesTotal = int.Parse(Console.ReadLine());
            int pagePerHour = int.Parse(Console.ReadLine());
            int numDays = int.Parse(Console.ReadLine());

            int totalReadingTime = numPagesTotal / pagePerHour;

            int hoursPerDay = totalReadingTime / numDays;

            Console.WriteLine(hoursPerDay);
            
        }
    }
}