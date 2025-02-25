namespace Seikkailijan_Reppu
{
    internal class Program
    {

        public class Tavara
        {
            public float Paino { get; private set; }
            public float Tilavuus { get; private set; }

            public Tavara(float paino, float tilavuus)
            {
                Paino = paino;
                Tilavuus = tilavuus;
            }

            public override string ToString()
            {
                return this.GetType().Name;
            }
        }


        public class Reppu
        {
            public int MaxTavaroidenMäärä { get; }
            public float MaxPaino { get; }
            public float MaxTilavuus { get; }

            private List<Tavara> Tavarat = new List<Tavara>();

            public int NykyinenMäärä => Tavarat.Count;
            public float NykyinenPaino => Tavarat.Sum(t => t.Paino);
            public float NykyinenTilavuus => Tavarat.Sum(t => t.Tilavuus);

            public float JäljelläPaino => MaxPaino - NykyinenPaino;
            public float JäljelläTilavuus => MaxTilavuus - NykyinenTilavuus;
            public int JäljelläTavarat => MaxTavaroidenMäärä - NykyinenMäärä;

            public Reppu(int maxTavaroidenMäärä, float maxPaino, float maxTilavuus)
            {
                MaxTavaroidenMäärä = maxTavaroidenMäärä;
                MaxPaino = maxPaino;
                MaxTilavuus = maxTilavuus;
            }

            public bool Lisää(Tavara tavara)
            {
                if (NykyinenMäärä >= MaxTavaroidenMäärä)
                {
                    Console.WriteLine("Reppu on täynnä! Ei voida lisätä: " + tavara.GetType().Name);
                    return false;
                }
                if (NykyinenPaino + tavara.Paino > MaxPaino)
                {
                    Console.WriteLine("Liian raskas! Ei voida lisätä: " + tavara.GetType().Name);
                    return false;
                }
                if (NykyinenTilavuus + tavara.Tilavuus > MaxTilavuus)
                {
                    Console.WriteLine("Ei mahdu reppuun! Ei voida lisätä: " + tavara.GetType().Name);
                    return false;
                }

                Tavarat.Add(tavara);
                Console.WriteLine($"{tavara.GetType().Name} lisätty reppuun.");
                return true;
            }

            public void NäytäTavarat()
            {
                Console.WriteLine("Repun sisältö:");
                if (Tavarat.Count == 0)
                {
                    Console.WriteLine(" - Reppu on tyhjä.");
                }
                else
                {
                    foreach (var tavara in Tavarat)
                    {
                        Console.WriteLine($" - {tavara}");
                    }
                }

                Console.WriteLine($"\nTavaroita: {NykyinenMäärä}/{MaxTavaroidenMäärä}");
                Console.WriteLine($"Paino: {NykyinenPaino}/{MaxPaino} kg");
                Console.WriteLine($"Tilavuus: {NykyinenTilavuus}/{MaxTilavuus} litraa");
                Console.WriteLine($"Jäljellä: {JäljelläTavarat} tavaraa, {JäljelläPaino} kg, {JäljelläTilavuus} litraa\n");
            }

            public override string ToString()
            {
                if (Tavarat.Count == 0)
                {
                    return "Reppu on tyhjä.";
                }
                return "Reppussa on seuraavat tavarat: " + string.Join(", ", Tavarat.Select(t => t.ToString()));
            }
        }




        public class Nuoli : Tavara
        {
            public Nuoli() : base(0.1f, 0.05f) { }
        }
        public class Jousi : Tavara
        {
            public Jousi() : base(1f, 4f) { }
        }

        public class Köysi : Tavara
        {
            public Köysi() : base(1f, 1.5f) { }
        }

        public class Vesi : Tavara
        {
            public Vesi() : base(2f, 2f) { }
        }
        public class RuokaAnnos : Tavara
        {
            public RuokaAnnos() : base(1f, 0.5f) { }
        }

        public class Miekka : Tavara
        {
            public Miekka() : base(5f, 3f) { }
        }


        static void Main(string[] args)
        {
            Reppu reppu = new Reppu(5, 10f, 8f);

            Console.WriteLine(reppu.ToString());
            Console.WriteLine("Paina Enter jatkaaksesi...");
            Console.ReadLine();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("REPPU - Valitse toiminto:");
                Console.WriteLine("1. Lisää Nuoli");
                Console.WriteLine("2. Lisää Jousi");
                Console.WriteLine("3. Lisää Köysi");
                Console.WriteLine("4. Lisää Vesi");
                Console.WriteLine("5. Lisää Ruoka-annos");
                Console.WriteLine("6. Lisää Miekka");
                Console.WriteLine("7. Näytä reppu");
                Console.WriteLine("8. Poistu");
                Console.Write("Valinta: ");

                string valinta = Console.ReadLine();
                Tavara tavara;

                switch (valinta)
                {
                    case "1": tavara = new Nuoli(); break;
                    case "2": tavara = new Jousi(); break;
                    case "3": tavara = new Köysi(); break;
                    case "4": tavara = new Vesi(); break;
                    case "5": tavara = new RuokaAnnos(); break;
                    case "6": tavara = new Miekka(); break;
                    case "7":
                        reppu.NäytäTavarat();
                        Console.WriteLine("Paina Enter jatkaaksesi...");
                        Console.ReadLine();
                        continue;
                    case "8": return;
                    default:
                        Console.WriteLine("Virheellinen valinta! Paina Enter ja yritä uudelleen.");
                        Console.ReadLine();
                        continue;
                }

                reppu.Lisää(tavara);
                Console.WriteLine("Paina Enter jatkaaksesi...");
                Console.ReadLine();
            }
        }
    }
}
