namespace Ruoka_Annos
{
    internal class Program
    {
        enum PääRaakaAine
        {
            Liha,
            Kana, 
            Kasviksia
        }
        enum Lisuke
        {
            Peruna,
            Riisi,
            Pasta,
        }
        enum Kastike
        {
            Pippuri,
            Curry,
            Chili
        }

        class Ateria
        {
            private PääRaakaAine pääaine;
            private Lisuke lisuke;
            private Kastike kastike;

            public Ateria(PääRaakaAine pääaine, Lisuke lisuke, Kastike kastike)
            {
                this.pääaine = pääaine;
                this.lisuke = lisuke;  
                this.kastike = kastike;
            }
            public Kastike AnnaKastike()
            {
                return this.kastike;
            }

            public override string ToString()
            {
                return $"Pääraaka-aine: {pääaine}, lisuke: {lisuke}, kastike: {kastike}";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Valitse pääraaka-aine: ");
            Console.WriteLine("0 - Liha, 1 - Kana, 2 - Kasvikset");
            PääRaakaAine valittuPääAine = (PääRaakaAine)int.Parse(Console.ReadLine());

            Console.WriteLine("Valitse lisuke: ");
            Console.WriteLine("0 - Peruna, 1 - Riisi, 2 - Pasta");
            Lisuke valittuLisuke = (Lisuke)int.Parse(Console.ReadLine());

            Console.WriteLine("Valitse kastike: ");
            Console.WriteLine("0 - Curry, 1 - Hapanimelä, 2 - Pippuri, 3 - Chili");
            Kastike valittuKastike = (Kastike)int.Parse(Console.ReadLine());

            Ateria tilaus = new Ateria(valittuPääAine, valittuLisuke, valittuKastike);

            Console.WriteLine($"Olet valinnut: {tilaus}");

        }

    }
}
