namespace ConstructorsInInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elma elma = new Elma("Kırmızı", false, 10);
            elma.Yazdir();
            Cilek cilek = new Cilek("Altın", true, 50);
            cilek.Yazdir();
        }
    }

    abstract class Meyve
    {
        protected string _renk;
        protected bool _tropikalMi;
        protected double _agırlık;

        protected Meyve(string renk, bool tropikalMi, double agırlık)
        {
            _renk = renk;
            _tropikalMi = tropikalMi;
            _agırlık = agırlık;
        }

        public void Yazdir()
        {
            Console.WriteLine("Renk: " + _renk + ", Tropikal: " + (_tropikalMi ? "Tropikal" : "Tropikal Değil") + ", Ağırlık: " + _agırlık);
        }
    }
    class Elma : Meyve
    {
        public Elma(string renk, bool tropikalMi, double agırlık) : base(renk, tropikalMi, agırlık)
        {
        }
    }
    class Cilek : Meyve
    {
        public Cilek(string renk, bool tropikalMi, double agırlık) : base(renk, tropikalMi, agırlık)
        {
        }
    }
}