namespace Robotti
{
    
    public class Robotti
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool OnKäynnissä { get; set; }
        public IRobottiKäsky?[] Käskyt { get; } = new IRobottiKäsky?[3];

        public void Suorita()
        {
            foreach (IRobottiKäsky? käsky in Käskyt)
            {
                käsky?.Suorita(this);
                Console.WriteLine($"[{X} {Y} {OnKäynnissä}]");
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Robotti robotti = new Robotti();
                Console.WriteLine($"Mitä komentoja syötetään robotille: Käynnistä, Sammuta, Ylös, Alas, Oikea, Vasen.");
                
                for (int i = 0; i < 3;  i++)
                {
                    Console.Write($"\nKäsky {i + 1}: ");
                    string valinta = Console.ReadLine();

                    IRobottiKäsky? käsky = valinta switch
                    {
                        "Käynnistä" => new Käynnistä(),
                        "Sammuta" => new Sammuta(),
                        "Ylös" => new YlösKäsky(),
                        "Alas" => new AlasKäsky(),
                        "Oikea" => new OikeaKäsky(),
                        "Vasen" => new VasenKäsky(),
                        _ => null
                    };
                    if (käsky == null)
                    {
                        i--;
                    }
                    else
                    {
                        robotti.Käskyt[i] = käsky;
                    }
                    
                }
                robotti.Suorita();
            }
        }
    }
}