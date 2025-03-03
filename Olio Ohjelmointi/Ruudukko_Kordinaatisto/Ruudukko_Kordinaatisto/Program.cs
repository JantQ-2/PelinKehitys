namespace Ruudukko_Kordinaatisto
{
    struct Koordinaatti
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Koordinaatti(int x, int y)
        {
            X = x;
            Y = y;
        }
        public bool OnVieressa(Koordinaatti toinen)
        {
            int dx = Math.Abs(X - toinen.X);
            int dy = Math.Abs(Y - toinen.Y);

            return (dx <= 1 && dy <= 1);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna Ensimmäisen Koordinaatin X:");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna Ensimmäisen Koordinaatin Y:");
            int y1 = int.Parse(Console.ReadLine());

            Koordinaatti p1 = new Koordinaatti(x1, y1);

            Console.WriteLine("Anna Toisen Koordinaatin X:");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna Toisen Koordinaatin Y:");
            int y2 = int.Parse(Console.ReadLine());

            Koordinaatti p2 = new Koordinaatti(x2, y2);

            if (p1.OnVieressa(p2))
            {
                Console.WriteLine($"{p1} on koordinaatin {p2} vieressä.");
            }
            else
            {
                Console.WriteLine($"{p1} ei ole koordinaatin {p2} vieressä");
            }

        }
    }
}
