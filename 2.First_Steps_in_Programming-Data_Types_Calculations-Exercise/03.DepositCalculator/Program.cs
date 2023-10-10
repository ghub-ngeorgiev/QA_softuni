using System.Threading.Channels;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double rate = double.Parse(Console.ReadLine());
            double recieve = amount + term * (amount * rate/100) / 12;
            Console.WriteLine(recieve);
        }
    }
}