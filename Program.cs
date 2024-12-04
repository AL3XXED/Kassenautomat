using System.Security.Cryptography.X509Certificates;

namespace Kassenautomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string[] geld = { "500 Euroschein", "200 Euroschein", "100 Eruroschein", "50 Euroschein", "20 Euroschein", "10 Euroschein", "5 Euroschein", "2 Euro", "1 Euro", "50 Cent", "20 Cent", "10 Cent", "5 Cent", "2 Cent", "1 Cent" };
            int[] SchweineUndMünzen = { 50000, 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            decimal gegeben;

            Console.WriteLine("Gebe den verlangten Betrag ein:");
            decimal betrag = decimal.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Gebe ein wie hoch der übermittelte Betrag ist : ");
                gegeben = decimal.Parse(Console.ReadLine());

                if (gegeben > betrag)
                {
                    break;
                }
                else if (gegeben == betrag)
                {
                    Console.WriteLine("Der Betrag passt genau!");
                    return;
                }
                Console.WriteLine("Der Bertrag ist zu niedrig, du Ficker");
            }
                decimal rückgeld = gegeben - betrag;
                Console.WriteLine($"Rückgeld: {rückgeld:c}");

            decimal rückgeldInEuro = rückgeld;
            for (int i = 0; i < SchweineUndMünzen.Length; i++)
            {
                decimal wertInEuro = SchweineUndMünzen[i] / 100m;
                int anzahl = (int)(rückgeldInEuro / wertInEuro);

                if (anzahl > 0)
                {
                    Console.WriteLine($"{anzahl} x {geld[i]}");
                    rückgeldInEuro %= wertInEuro;
                }
            }


        }
    }
}
