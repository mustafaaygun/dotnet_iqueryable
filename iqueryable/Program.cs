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
        musteriler.Add(new TBLMUSTERI { LNGKOD = 1, TXTAD = "Sabancı Holding" });
        musteriler.Add(new TBLMUSTERI { LNGKOD = 2, TXTAD = "Koç Holding" });

/************************************************************************************************************************************************************/
        /*
            @Aggregate
            Verilen değerleri toplar;
        */
        var musteriBirlestir = musteriler.Aggregate("", (sonDeger, eleman) => sonDeger + " " + eleman.TXTAD);
        /*
            @return(
                string => Sabancı Holding Koç Holding
            )
        */
        var carpim = musteriler.Aggregate(1, (sonDeger, eleman) => sonDeger * eleman.LNGKOD);
        /*
            @return(
                int => 2
            )
        */
/************************************************************************************************************************************************************/
        /*  
            @All
            Butun kayitlar verilen kosula uyuyorsa true doner;
        */
        var butunKayitlariKontrolEt = musteriler.All(x => x.TXTAD.EndsWith("g"));
        /*
            @return(
                boolean = True
            )
        */
/************************************************************************************************************************************************************/
        /*
            @Any
            Herhangi bir kayit verilen kosulu saglarsa true doner;
        */
        var tekBirKayitUyuyorMu = musteriler.Any(x => x.TXTAD.StartsWith("S")); //
        /*
            @return(
                boolean = True
            )
        */
/************************************************************************************************************************************************************/
        /*
            @Append
            Listenin sonuna kayıt ekler;
        */
        musteriler = musteriler.Append(new TBLMUSTERI { LNGKOD = 3, TXTAD = "Tekfen Holding" }).ToList();
        /*
            @return(
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
            )
        */
/************************************************************************************************************************************************************/
        /*
            @AsEnumerable
            ienumerable olarak dondurur
        */
        var ieMusteriler = musteriler.AsEnumerable(); //
/************************************************************************************************************************************************************/
        /*
            @Average
            Degerlerin ortalamasini alir
        */
        var average = musteriler.Average(x => x.LNGKOD);
        /*
            @return(
                int => 2
            )
        */
/************************************************************************************************************************************************************/
        /*
            @Capacity
            Kac adet eleman kapasitesi oldugunu verir;
        */
        var capacity = musteriler.Capacity;
        /*
           @return(
               int => 3
           )
       */
/************************************************************************************************************************************************************/
        /*
            @Cast
            Listeyi icerisine verilen tipe donusturur;
        */
        var castMusteri = musteriler.Cast<TBLMUSTERI>().ToList(); // convert eder
        /*
            @return(
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
            )
        */
/************************************************************************************************************************************************************/
        /*
            @Chunk
            Listeyi verilen parcada boler;
        */
        var parcala = musteriler.Chunk(2);
        /*
            @return(
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
            )
        */
/************************************************************************************************************************************************************/
        /*
            @AddRange
            Listeyi liste içerisine ekler;
        */
        musteriler.AddRange(new List<TBLMUSTERI>{new TBLMUSTERI{LNGKOD=4,TXTAD="Alarko Holding" }});
        /*
            @return(
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
                [3]:{
                    LNGKOD [int]:4
                    TXTAD [string]:"Alarko Holding"
                }
            )
        */
    }
}