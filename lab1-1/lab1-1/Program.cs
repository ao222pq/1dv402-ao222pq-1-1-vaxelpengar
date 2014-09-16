using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklarera variabler
            double subtotal = 0.0;
            int recieved = 0;
            int change;
            uint total;
            int fiveHundreds;
            int oneHundreds;
            int fifties;
            int twenties;
            int tens;
            int fives;
            int ones;

            // indata, summa och mottaget belopp, 
            // de måste vara rätt format och 
            // summan får inte vara mindre än 
            // 1 eller högre än mottaget belopp

            
            while (true)
            {
                try
                {
                    Console.Write("Ange totalsumma  :");
                    subtotal = double.Parse(Console.ReadLine());
                    break;
                }
                catch 
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel! totalsumman inte giltigt.");
                    Console.ResetColor();
                    
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Ange mottaget belopp :");
                    recieved = int.Parse(Console.ReadLine());

                    break;
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel! Mottaget belopp inte giltigt.");
                    Console.ResetColor();
                }
            }

            // avrunda sum

            total = (uint)Math.Round(subtotal);

            // skriv ut kvittot

            Console.WriteLine("KVITTO");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Totalt           :   {0} kr", subtotal);
            Console.WriteLine("Öresavrundning   :   {0:f2} kr", subtotal - total);
            Console.WriteLine("Att betala       :   {0} kr", total);
            Console.WriteLine("Kontant          :   {0} kr", recieved);
            Console.WriteLine("Tillbaka         :   {0} kr", recieved - total);
            Console.WriteLine("------------------------------");
            Console.WriteLine("");

            // Dela upp växeln i sedlar och mynt och
            // skriv ut det som ges tillbaka.

            change = recieved - (int)total;
            fiveHundreds = change / 500;
            change = change % 500;
            oneHundreds = change / 100;
            change = change % 100;
            fifties = change / 50;
            change = change % 50;
            twenties = change / 20;
            change = change % 20;
            tens = change / 10;
            change = change % 10;
            fives = change / 5;
            change = change % 5;
            ones = change;

            if (fiveHundreds > 0)
            {
                Console.WriteLine(" 500-lappar      :   {0}", fiveHundreds);
            }
            if (oneHundreds > 0)
            {
                Console.WriteLine(" 100-lappar      :   {0}", oneHundreds);
            }
            if (fifties > 0)
            {
                Console.WriteLine("  50-lappar      :   {0}", fifties);
            }
            if (twenties > 0)
            {
                Console.WriteLine("  20-lappar      :   {0}", twenties);
            }
            if (tens > 0)
            {
                Console.WriteLine("  10-kronor      :   {0}", tens);
            }
            if (fives > 0)
            {
                Console.WriteLine("   5-kronor      :   {0}", fives);
            }
            if (ones > 0)
            {
                Console.WriteLine("   1-kronor      :   {0}", ones);
            }
        }
    }
}
