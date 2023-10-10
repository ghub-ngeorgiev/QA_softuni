namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());  
            int veg = int.Parse(Console.ReadLine());

            double menuOrders = chicken * 10.35 + fish * 12.4 + veg * 8.15;
            double dessert = menuOrders * 0.2;
            double delivery = 2.50;

            double totalOrder = menuOrders + dessert + delivery;

            Console.WriteLine(totalOrder);
        }
    }
}