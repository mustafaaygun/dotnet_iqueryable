class Program
{
    public class TBLMUSTERI
    {
        public int LNGKOD { get; set; }
        public string TXTAD { get; set; }
    }

    public class TBLMUSTERIID
    {
        public int LNGKOD { get; set; }
    }
    static void Main(string[] args)
    {
        var musteriler = new List<TBLMUSTERI>();


/************************************************************************************************************************************************************/
        /*
            @Add
            Listeye verilen elemani ekler;
        */
        musteriler.Add(new TBLMUSTERI { LNGKOD = 1, TXTAD = "Sabancı Holding" });
        musteriler.Add(new TBLMUSTERI { LNGKOD = 2, TXTAD = "Koç Holding" });

/************************************************************************************************************************************************************/
        /*
            @Aggregate
            Verilen varsayılan deger ile tum degerleri donerek tek bir sonuc dondurur;
        */
        string musteriBirlestir = musteriler.Aggregate("", (sonDeger, eleman) => sonDeger + " " + eleman.TXTAD);
        /*
            musteriBirlestir = "Sabancı Holding Koç Holding";
        */
        int carpim = musteriler.Aggregate(1, (sonDeger, eleman) => sonDeger * eleman.LNGKOD);
        /*
           carpim = 2;
        */
/************************************************************************************************************************************************************/
        /*  
            @All
            Butun kayitlar verilen kosula uyuyorsa true doner;
        */
        bool butunKayitlariKontrolEt = musteriler.All(x => x.TXTAD.EndsWith("g"));
        /*
            butunKayitlariKontrolEt = True;
        */
/************************************************************************************************************************************************************/
        /*
            @Any
            Herhangi bir kayit verilen kosulu saglarsa true doner;
        */
        bool tekBirKayitUyuyorMu = musteriler.Any(x => x.TXTAD.StartsWith("S")); //
        /*
            tekBirKayitUyuyorMu = True;
        */
/************************************************************************************************************************************************************/
        /*
            @Append
            Listenin sonuna kayıt ekler;
        */
        musteriler = musteriler.Append(new TBLMUSTERI { LNGKOD = 3, TXTAD = "Tekfen Holding" }).ToList();
        /*
            musteriler = 
            [0]:{
                LNGKOD [int]:1
                TXTAD [string]:"Sabancı Holding
            }
            [1]:{ 
                LNGKOD [int]:2
                TXTAD [string]:"Koç Holding"
            }
            [2]:{
                LNGKOD [int]:3
                TXTAD [string]:"Tekfen Holding"
            }
        */
/************************************************************************************************************************************************************/
        /*
            @AsEnumerable
            ienumerable olarak dondurur;
        */
        var ieMusteriler = musteriler.AsEnumerable();
/************************************************************************************************************************************************************/
        /*
            @Average
            Degerlerin ortalamasini alir;
        */
        double average = musteriler.Average(x => x.LNGKOD);
        /*
            average = 2;
        */
/************************************************************************************************************************************************************/
        /*
            @Capacity
            Kac adet eleman kapasitesi oldugunu verir;
        */
        int capacity = musteriler.Capacity;
        /*
            capacity = 3;
        */
/************************************************************************************************************************************************************/
        /*
            @Cast
            Listeyi icerisine verilen tipe donusturur;
        */
        var castMusteri = musteriler.Cast<TBLMUSTERI>().ToList();
        /*
            castMusteri = 
            [0]:{
                LNGKOD [int]:1
                TXTAD [string]:"Sabancı Holding
            }
            [1]:{ 
                LNGKOD [int]:2
                TXTAD [string]:"Koç Holding"
            }
            [2]:{
                LNGKOD [int]:3
                TXTAD [string]:"Tekfen Holding"
            }
        */
/************************************************************************************************************************************************************/
        /*
            @Chunk
            Listeyi verilen parcada boler;
        */
        var parcala = musteriler.Chunk(2);
        /*
            parcala = 
            [0] [TBLMUSTERI[]]:
                [0]:{
                    LNGKOD [int]:1
                    TXTAD [string]:"Sabancı Holding
                }
                [1]:{ 
                    LNGKOD [int]:2
                    TXTAD [string]:"Koç Holding"
                }
            [1] [TBLMUSTERI[]]:
                [0]:{
                    LNGKOD [int]:3
                    TXTAD [string]:"Tekfen Holding"
                }
        */
/************************************************************************************************************************************************************/
        /*
            @AddRange
            Listeyi liste içerisine ekler;
        */
        musteriler.AddRange(new List<TBLMUSTERI>{new TBLMUSTERI{LNGKOD=4,TXTAD="Alarko Holding" }});
        /*
            musteriler = 
            [0]:{
                LNGKOD [int]:1
                TXTAD [string]:"Sabancı Holding
            }
            [1]:{ 
                LNGKOD [int]:2
                TXTAD [string]:"Koç Holding"
            }
            [2]:{
                LNGKOD [int]:3
                TXTAD [string]:"Tekfen Holding"
            }
            [3]:{
                LNGKOD [int]:4
                TXTAD [string]:"Alarko Holding"
            }
        */
/************************************************************************************************************************************************************/
        /*
            @Clear
            Listeyi temizler;
        */
        musteriler.Clear();
/************************************************************************************************************************************************************/
        /*
            @Concat
            Iki listeyi birlestirir;
        */
        var sahol = new TBLMUSTERI { LNGKOD = 1, TXTAD = "Sabancı Holding" };
        musteriler.Add(sahol);
        var musterilerConcat = new List<TBLMUSTERI>{new TBLMUSTERI { LNGKOD = 2, TXTAD = "Koç Holding" }};
        musteriler = musteriler.Concat(musterilerConcat).ToList();
        /*
            musteriler = 
            [0]:{
                LNGKOD [int]:1
                TXTAD [string]:"Sabancı Holding
            }
            [1]:{ 
                LNGKOD [int]:2
                TXTAD [string]:"Koç Holding"
            }
        */
/************************************************************************************************************************************************************/
        /*
            @Contains
            Listenin icerisinde verilen tek eleman var mı?;
        */
        bool musteriIceriyorMu =  musteriler.Contains(sahol);
         /*
            Degiskenden cekilmeden arandıgında false donmekte cunku ramde farklı alanda;
            musteriIceriyorMu = true
        */
/************************************************************************************************************************************************************/
        /*
            @ConvertAll
            Listeyi istenilen tipte donusturur;
        */
        var musterilerConvertAll = musteriler.ConvertAll(x=>x.TXTAD);
        /*
            musterilerConvertAll = [
                [0] [string]:"Sabancı Holding"
                [1] [string]:"Koç Holding"
            ]
        */
/************************************************************************************************************************************************************/
        /*
            @CopyTo
            Listeyi diziye kopyalar;
        */
        TBLMUSTERI[] musteriDizisi = new TBLMUSTERI[musteriler.Count];
        musteriler.CopyTo(musteriDizisi);
        /*
            musteriDizisi[] = 
            [0]:{
                LNGKOD [int]:1
                TXTAD [string]:"Sabancı Holding"
            }
            [1]:{ 
                LNGKOD [int]:2
                TXTAD [string]:"Koç Holding"
            }
            
        */
/************************************************************************************************************************************************************/
        /*
            @Count
            Liste eleman sayısını verir;
        */
        int musteriAdet = musteriler.Count;
         /*
            musteriAdet = 2
        */
/************************************************************************************************************************************************************/
        /*
            @DefaultIfEmpty
            Liste eleman bulunmuyorsa verilen varsayılan elemanı döndürür;
        */
        var musterilerEgerBossa = musteriler.DefaultIfEmpty(new TBLMUSTERI { LNGKOD = 3, TXTAD = "Sabancı Holding" }).ToList();
        /*
            musterilerEgerBossa = 
            [0]:{
                LNGKOD [int]:1
                TXTAD [string]:"Sabancı Holding"
            }
            [1]:{ 
                LNGKOD [int]:2
                TXTAD [string]:"Koç Holding"
            }
        */
/************************************************************************************************************************************************************/
        /*
            @Distinct
            Liste elemanları benzersiz olarak döndürür;
        */
        musteriler.Add(new TBLMUSTERI {LNGKOD=3,TXTAD="Sabancı Holding"});
        var musterilerBenzersiz = musteriler.Distinct();
       /*
            musterilerBenzersiz = 
            [0]:{
                LNGKOD [int]:1
                TXTAD [string]:"Sabancı Holding"
            }
            [1]:{ 
                LNGKOD [int]:2
                TXTAD [string]:"Koç Holding"
            }
            [2]:{ 
                LNGKOD [int]:3
                TXTAD [string]:"Sabancı Holding"
            }
       */
/************************************************************************************************************************************************************/
        /*
            @DistinctBy
            Liste elemanları verilen anahtara göre benzersiz olarak döndürür;
        */
        var musterilerBenzersizBy = musteriler.DistinctBy(x=>x.TXTAD);
        /*
            musterilerBenzersizBy = 
            [0]:{
                LNGKOD [int]:1
                TXTAD [string]:"Sabancı Holding
            }
            [1]:{ 
                LNGKOD [int]:2
                TXTAD [string]:"Koç Holding"
            }
        */
        musteriler.Remove(musteriler.Last());
/************************************************************************************************************************************************************/
        /*
            @ElementAt
            Liste içerisinde verilen indexdeki elemanı döndürür;
        */
        var musterilerNthEleman = musteriler.ElementAt(0);
        /*
            musterilerNthEleman=
                LNGKOD [int]:1
                TXTAD [string]:"Sabancı Holding"
        */
/************************************************************************************************************************************************************/
        /*
            @ElementAtOrDefault
            Liste içerisinde verilen indexdeki elemanı döndürür yoksa default değerini döndürür;
        */
        var musterilerNthElementOrDefault= musteriler.ElementAtOrDefault(5);
        /*
            Eğer ElementAt ile 5. indexe ulaşılmak isteseydi excetion fırlatırdı;
            musterilerNthElementOrDefault=null
        */
/************************************************************************************************************************************************************/
        musteriler.EnsureCapacity(1); //?
/************************************************************************************************************************************************************/
        /*
            @Equals
            Liste içerisinde verilen listenin eşit olmadığını döndürür;
        */
        var musterilerEsitMi = musteriler;
        bool musterilerEsit = musteriler.Equals(musterilerEsitMi);
        /*
            musterilerEsit = true
        */
/************************************************************************************************************************************************************/
        /*
            @Except
            Liste içerisinde verilen liste karşılaştırılarak eşleşmeyenleri döndürür;
        */
        List<TBLMUSTERI> musterilerHaricListe = new List<TBLMUSTERI>();
        musterilerHaricListe = musteriler.Concat(musterilerHaricListe).ToList();
        musterilerHaricListe.Add(new TBLMUSTERI{LNGKOD=3,TXTAD="Koç Holding" });
        var musterilerHaric = musterilerHaricListe.Except(musteriler).ToList();
        /*
            musterilerHaric =
            [0]:{
                LNGKOD [int]:3
                TXTAD [string]:"Koç Holding"
            }
        */
/************************************************************************************************************************************************************/
        /*
            @ExceptBy
            Liste içerisinde verilen liste anahtar değerini karşılaştırılarak eşleşmeyenleri döndürür;
        */
        var musterilerHaricBy = musterilerHaricListe.ExceptBy(musteriler.Select(x=>x.LNGKOD),x=>x.LNGKOD).ToList();
        /*
            musterilerHaricBy =
            [0]:{
                LNGKOD [int]:3
                TXTAD [string]:"Koç Holding"
            }
        */
/************************************************************************************************************************************************************/        
        /*
            @Exists
            Listeye verilen koşula uyan bir kayıt var ise doğru(true) döndürür ;
        */
        bool musterilerVarMi = musteriler.Exists(x=>x.LNGKOD==12);
        /*
            musterilerVarMi = false
        */
/************************************************************************************************************************************************************/  
         /*
            @Exists
            Listeye verilen koşula uyan bir kayıt var ise döndürür;
        */
        var musterilerBul = musteriler.Find(x=>x.LNGKOD==2);
        /*
            musterilerBul =
            [0]:{
                LNGKOD [int]:2
                TXTAD [string]:"Koç Holding"
            }
        */








        /*
            @ToDictionary
            Listeyi sözlük olarak döndürür;
        */
        var musterilerToDictionary = musteriler.ToDictionary(x=>x.LNGKOD,y=>y.TXTAD);
        /*
            [0][KeyValuePair]:{[1,Sabancı Holding]]
            [1][KeyValuePair]:{[2,Koç Holding]]
        */ 
/************************************************************************************************************************************************************/
        
    }


}