namespace ConstructorsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Film film = new Film("Logan", 2017, 1, "20 Century Fox/Marvel Studio", "James Magold", 619.2);
            Console.WriteLine(film.FilmGetir());
        }
      
    }
   
    class Film
    {
        
        public string Adi { get; set; }
        public int YapimYili { get; set; }
        public int Id { get; set; }
        public string Yapimcisi { get; set; }
        public string Yonetmeni { get; set; }
        public double Gisesi { get; set; }


        public Film(string adi, int yapimYili, int id, string yapimcisi, string yonetmeni, double gisesi)
        {
            Adi = adi;
            YapimYili = yapimYili;
            Id = id;
            Yapimcisi = yapimcisi;
            Yonetmeni = yonetmeni;
            Gisesi = gisesi;
        }
        public string FilmGetir()
        {
            return "Adı: " + Adi + " " + "\nYapım Yılı: " + YapimYili+ " " + "\nId: " + Id + " " + "\nYapımcısı: " + Yapimcisi + " " + "\nYönetmeni: " + Yonetmeni + ", " + "\nGişesi: " + Gisesi + "M$";
        }
    }
    

}