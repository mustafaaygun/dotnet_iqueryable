class Program
{
    public class TBLMUSTERI
    {
        public int LNGKOD { get; set; }
        public string TXTAD { get; set; }
    }
    static void Main(string[] args)
    {
        var musteriler = new List<TBLMUSTERI>();
        musteriler.Add(new TBLMUSTERI { LNGKOD = 1, TXTAD = "Sabancı Holding" });
        musteriler.Add(new TBLMUSTERI { LNGKOD = 2, TXTAD = "Koç Holding" });
        var musteriBirlestir = musteriler.Aggregate("", (sonDeger, eleman) => sonDeger + " " + eleman.TXTAD);
        var carpim = musteriler.Aggregate(1, (sonDeger, eleman) => sonDeger * eleman.LNGKOD);
        //Console.WriteLine($@"Carpim = {carpim}; Birlesim = {musteriBirlestir}");

        var butunKayitlariKontrolEt = musteriler.All(x => x.TXTAD.EndsWith("g")); //butun kayitlar verilen kosula uyuyorsa true doner
        //Console.WriteLine(butunKayitlariKontrolEt);
        
        var tekBirKayitUyuyorMu = musteriler.Any(x => x.TXTAD.StartsWith("S")); //herhangi bir kayit verilen kosulu saglarsa true doner
        //Console.WriteLine(tekBirKayitUyuyorMu);

        musteriler = musteriler.Append(new TBLMUSTERI { LNGKOD = 3, TXTAD = "Tekfen Holding" }).ToList(); //listenin sonuna kayıt ekler

        var ieMusteriler = musteriler.AsEnumerable(); //ienumerable olarak dondurur

        var average = musteriler.Average(x=>x.LNGKOD); //secilen degerin ortalamasini alir
        //Console.WriteLine(average);
        
        var capacity = musteriler.Capacity; // kac adet eleman oldugunu verir : 3
        //Console.WriteLine(capacity);
       
        musteriler.Cast<TBLMUSTERI>(); // convert eder

        var ss = musteriler.Chunk(2);
        
var e = ss.FirstOrDefault()[0].TXTAD;
        // musteriler = musteriler.Where(x => x.LNGKOD == 1).ToList(); //verilen kosul ile listeyi filtreler
        foreach (var item in musteriler)
        {
            //Console.WriteLine($@"LNGKOD={item.LNGKOD} TXTAD={item.TXTAD}");
        }

        musteriler.AddRange(musteriler); // Listeyi aynı tip listeye ekler
    }
}