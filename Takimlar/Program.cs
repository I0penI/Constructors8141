using System.Reflection.Metadata.Ecma335;

namespace Takimlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Takim takim = new FutbolTakimi("Galatasaray", "Sarı Kırmızı", "Fatih Terim", new DateTime(1905, 10, 1), 11);
            Console.WriteLine(takim.Adi);
            Takim takim2 = new FutbolTakimi("GS");
            Console.WriteLine(takim2.Adi);
        }
    }
    abstract class Takim
    {
        public string Adi { get; set; }
        public string Renkleri { get; set; }
        public string TeknikDrektörü { get; set; }
        public DateTime KurulusTarihi { get; set; }
        public byte OyuncuSayisi { get; set; }
        protected Takim(string adi, string renkleri, string teknikDirektörü, DateTime kurulusTarihi, byte oyuncuSayisi)
        {
            Adi = adi;
            Renkleri = renkleri;
            TeknikDrektörü = teknikDirektörü;
            KurulusTarihi = kurulusTarihi;
            OyuncuSayisi = oyuncuSayisi;
        }
        protected Takim(string adi)
        {
            Adi = adi;
        }
        protected Takim()
        {
                
        }
    }
    class FutbolTakimi : Takim
    {
        public FutbolTakimi() : base()
        {

        }
        public FutbolTakimi(string adi) : base(adi)
        {
        }

        public FutbolTakimi(string adi, string renkleri, string teknikDirektörü, DateTime kurulusTarihi, byte oyuncuSayisi) : base(adi, renkleri, teknikDirektörü, kurulusTarihi, oyuncuSayisi)
        {
        }
    }
   
}