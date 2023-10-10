using Microsoft.VisualBasic;

namespace _09.Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentageOccupied = double.Parse(Console.ReadLine());

            // The aquarium volume in centimeters
            // int aquarium = lenght * width * height;

            // The aquarium volume in decimeters diretly / volume in liters
            // 1 little = 1 dm^3
            double aquariumLiters = (lenght * 0.1) * (width * 0.1) * (height * 0.1);

            double requiredLiters = aquariumLiters * (1 - percentageOccupied/100);

            Console.WriteLine($"{requiredLiters:f2}");

            //Variant 2-- Console.WriteLine("{0:0.0}", requiredLiters);
        }
    }
}