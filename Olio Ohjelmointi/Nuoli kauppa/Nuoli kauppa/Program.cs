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

            public float LaskeHinta()
            {
                float kärjenHinta = kärki switch
                {
                    Kärjet.Puu => 3,
                    Kärjet.Teräs => 5,
                    Kärjet.Timantti => 50,
                    _ => 0
                };

                float peränHinta = perä switch
                {
                    Perä.Lehti => 0,
                    Perä.Kanansulka => 1,
                    Perä.Kotkansulka => 5,
                    _ => 0
                };

                float varrenHinta = pituus * 0.05f;

                return kärjenHinta + peränHinta + varrenHinta;
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
            Console.WriteLine($"Nuolen Hinta: {nuoli.LaskeHinta()} kultarahaa");
        }
    }
}
