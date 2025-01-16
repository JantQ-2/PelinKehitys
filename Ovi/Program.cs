namespace Ovi_T1
{
    internal class Program
    {
        public bool Looppi = true;

        enum OvenTila
        {
            Auki,
            Kiinni,
            Lukossa
        }

        enum Toiminto
        {
            Avaa,
            Lukitse,
            AvaaLukko,
            Sulje
        }
        static void Main(string[] args)
        {
            // Aseta oven alkutila ja kerro se pelaajalle
            OvenTila tila = OvenTila.Auki;

            while (true)
            {
                Console.WriteLine($"\nOvi on {tila}");
                Console.WriteLine("Valitse toiminto: Avaa, Lukitse, AvaaLukko, Sulje");

                string vastaus = Console.ReadLine();
                if (Enum.TryParse(vastaus, true, out Toiminto valittu))
                {
                        if (valittu == Toiminto.Avaa)
                        {
                            if (tila == OvenTila.Kiinni)
                            {
                                tila = OvenTila.Auki;
                                Console.WriteLine("Ovi avattiin.");
                            }
                            else if (tila == OvenTila.Lukossa)
                            {
                                Console.WriteLine("Et voi avata lukittua ovea! Avaa ensin lukko.");
                            }
                            else
                            {
                                Console.WriteLine("Ovi on jo auki.");
                            }
                        }
                        else if (valittu == Toiminto.Sulje)
                        {
                            if (tila == OvenTila.Auki)
                            {
                                tila = OvenTila.Kiinni;
                                Console.WriteLine("Ovi suljettiin.");
                            }
                            else
                            {
                                Console.WriteLine("Ovi ei ole auki, joten sitä ei voi sulkea.");
                            }
                        }
                        else if (valittu == Toiminto.Lukitse)
                        {
                            if (tila == OvenTila.Kiinni)
                            {
                                tila = OvenTila.Lukossa;
                                Console.WriteLine("Ovi lukittiin.");
                            }
                            else if (tila == OvenTila.Auki)
                            {
                                Console.WriteLine("Et voi lukita avointa ovea! Sulje ovi ensin.");
                            }
                            else
                            {
                                Console.WriteLine("Ovi on jo lukossa.");
                            }
                        }
                        else if (valittu == Toiminto.AvaaLukko)
                        {
                            if (tila == OvenTila.Lukossa)
                            {
                                tila = OvenTila.Kiinni;
                                Console.WriteLine("Oven lukko avattiin.");
                            }
                            else
                            {
                                Console.WriteLine("Oven lukkoa ei tarvitse avata, koska se ei ole lukossa.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Tuntematon toiminto.");
                        }
                }
                else
                {
                    Console.WriteLine("Virheellinen komento. Yritä uudelleen.");
                }
            }            
        }
    }
}
