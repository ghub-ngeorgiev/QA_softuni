namespace _06.Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int workHours = int.Parse(Console.ReadLine());

            double nylonNeeded = (nylon + 2) * 1.5;
            double paintNeeded = paint * 1.1 * 14.5;
            double thinnerNeeded = thinner * 5.0;
            double bags = 0.4;
            double workCost = workHours * ((nylonNeeded + paintNeeded + thinnerNeeded + bags) * 0.3);
            double allCosts = nylonNeeded + paintNeeded + thinnerNeeded + bags + workCost;

            Console.WriteLine(allCosts);
        }
    }
}