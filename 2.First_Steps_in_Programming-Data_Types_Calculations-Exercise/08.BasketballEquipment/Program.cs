namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fee = int.Parse(Console.ReadLine());

            double sneakers = fee - (fee * 0.4);
            double team = sneakers - (sneakers * 0.2);
            double basketbal = team / 4;
            double accessories = basketbal / 5;

            //double grandTotal = sneakers + team + basketbal + accessories;

            //Console.WriteLine(grandTotal);

            Console.WriteLine(sneakers + team + basketbal + accessories + fee);

        }
    }
}