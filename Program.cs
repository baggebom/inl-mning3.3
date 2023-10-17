using System;
namespace Upggift
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur länge hade du tänkt att hyra bilen? Du får inte hyra bilen längre än 11 timmar");
            int hyra= int.Parse(Console.ReadLine());

            if (hyra !< 12)
            {
                Console.WriteLine("Kostnaden för hyrningen är " + (hyra * 80) + " kr.");
            }
            else
            {
                Console.WriteLine("Du får inte hyra den så länge!");
            }
            Console.ReadKey();

        }

    }
}