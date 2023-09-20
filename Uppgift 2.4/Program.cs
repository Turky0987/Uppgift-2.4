using System; 

    namespace CarRentalCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur mycket är första personens lön?");
            int P1L = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur mycket är andra personens lön?");
            int P2L = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur mycket är tredje personens lön?");
            int P3L = int.Parse(Console.ReadLine());

            int totalcost = (P1L + P2L + P3L) / 3;

            Console.WriteLine($"medellönen = {totalcost}kr");
        }



    }

}
