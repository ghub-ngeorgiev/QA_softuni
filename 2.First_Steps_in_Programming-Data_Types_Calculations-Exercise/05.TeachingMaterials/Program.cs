namespace _05.TeachingMaterials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPensPackages = int.Parse(Console.ReadLine());
            int numMarkersPackages = int.Parse(Console.ReadLine());
            int littersBoardCleaner = int.Parse(Console.ReadLine());
            int discountPercentage = int.Parse(Console.ReadLine());

            double sumlNumPensPackages = numPensPackages * 5.80;
            double sumlNumMarkersPackages = numMarkersPackages * 7.20;
            double sumLittersBoardCleaner = littersBoardCleaner * 1.20;

            double totalSum = sumlNumPensPackages + sumlNumMarkersPackages + sumLittersBoardCleaner;

            double discountedTotalSum = totalSum * (1 - discountPercentage / 100.0);

            Console.WriteLine(discountedTotalSum);

        }
    }
}