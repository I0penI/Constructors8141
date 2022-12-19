namespace Constructors8141
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oyun oyun = new Oyun("GTA 5", 2013 );
            oyun.GetAdi();
            Oyun oyun1 = new Oyun();
        }
    }
    class Oyun
    {
        string _adi;
        short _yapimYili;
        public Oyun() // default (parametresiz) constructor
        {
            _adi = "";
            _yapimYili = 2022;
        }
        public Oyun(string adi, short yapimYili)
        {
            _adi = adi;
            _yapimYili = yapimYili;
        }
        public string GetAdi()
        {
            return _adi.Trim();
        }

    }
}