namespace Nuoli_kauppa
{
    internal class Program
    {
        enum Kärjet
        {
            Puu,
            Teräs,
            Timantti
        }

        enum Perä
        {
            Lehti,
            Kanansulka,
            Kotkansulka
        }

        class Nuoli
        {
            private Kärjet kärki;
            private Perä perä;
            private int pituus;

            public Nuoli(Kärjet kärki, Perä perä, int pituus)
            {
                this.kärki = kärki;
                this.perä = perä;
                this.pituus = pituus;
            }

            public Kärjet GetKärki()
            {
                return kärki;
            }

            public Perä GetPerä()
            {
                return perä;
            }

            public int GetPituus()
            {
                return pituus;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Valitse Nuolen Kärki:");
            Console.WriteLine("0 - Puu, 1 - Teräs, 2 - Timantti");
            Kärjet valittuKärki = (Kärjet)int.Parse(Console.ReadLine());

            Console.WriteLine("Valitse Nuolen Perä:");
            Console.WriteLine("0 - Lehti, 1 - Kanansulka, 2 - Kotkansulka");
            Perä valittuPerä = (Perä)int.Parse(Console.ReadLine());

            int valittuPituus;
            while (true)
            {
                Console.WriteLine("Valitse Nuolen Pituus (60cm-100cm): ");
                valittuPituus = int.Parse(Console.ReadLine());

                if (valittuPituus < 60 || valittuPituus > 100)
                {
                    Console.WriteLine("Virheellinen pituus, syötä uudestaan. ");
                }
                else
                {
                    break;
                }
            }

            Nuoli nuoli = new Nuoli(valittuKärki, valittuPerä, valittuPituus);

            Console.WriteLine($"Nuolen Kärki: {nuoli.GetKärki()}, Nuolen Perä: {nuoli.GetPerä()}, Nuolen Pituus: {nuoli.GetPituus()}cm");
        }
    }
}
