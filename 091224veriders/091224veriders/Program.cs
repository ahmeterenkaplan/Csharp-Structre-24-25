using System.Linq.Expressions;

namespace _091224veriders;

class Program
{
    // static Block[] datalar =new Block[30000]; // 1. yol
    class Block
    {
        public int data;
        public Block next;
        public Block prev;
    }
    //2.yol
    static int[] ogrler=new int[30000];
    static string[] names=new string[30000];


    class bplustree
    {
         int[] items = new int[1000];
         bplustree[] links = new bplustree[1000];
          bplustree left = null;
           bplustree next = null;
           bplustree prev = null;
          //?-range query
         
    }
    public static Block[] hashLink = new Block[100];
    //dosya ksımını araştır.
    static void Main(string[] args)
    {
        //b+tree
        Block tmp = new Block();
        tmp.data = 2100;
        if (hashLink[3] == null) hashLink[3] = tmp;
        else
        {
            tmp.next = hashLink[3];
            hashLink[3].prev = hashLink[3]=tmp;}
        
        
        
        
        // searching-search algoritmaları (arama algoları)
        // 30klık bir listede 1 öğrenciyi öğrenci no ile arama yapacagız
        
        //2.yol ile arama yaparsak
        int bulundu = 0;
        for (int i = 0; i < 30000; i++)
        {
            if (ogrler[i] == 213255062)
            {
                
            }
        }
        
        // bu aramaya sequential search (yanyana arama) denir. sonucu bulana kadar ortalama olarak 15000 sonra bulur.En ilker aramadır. daha kötüsü yoktur
        
        
        //binary search
        //sort edilmiş -sorted-sıralı dizi
        // bu dizinin orta elemanına gideriz. aranan elemana göre hep ikiye böle böle gideriz. log(n) hesaplama karşılıgıdır.bu log 2 tabanında kabul alır pc dilinde.
        //ödev binary search kodlanacak
        //İsam indexed sequential access method ,complex,berbat bir yapı
        //cobol programlama dili aptaldır. bak araştır
        
        // 2 indexed yapı araştır
        
        // 3 hashing search algoritması
        // en hızlı search algoritması ancak büyük verilerde kullanılması mümkün değildir.
        //hash tmelinde diziler vardır. Diziler üzerine kurulmuştur.
        // örnegin bir x dizisinin 1. elemanına ulaşmak ile 111.elemanına ulaşmak arasında fark yoktur.
        // temel esprimiz şu bir dataya iht olacak . bir veri var . ilk olarak veriyi saklamamız gerkiyor daha sıonra search etmemiz gerekiyo.
        //örn ogrno üzerine hash nasıl kurulacak?
        // mekanizması şöyle bir veriyi alıyoruz ve bu verinin saklanacagı indisi bulacagız.
        //hash function-kritik noktadır.
        //bu function verinin dizinin hangi indisine yazılacagını belirler
        //hash'in en büyük problemi çakışmadır. Collision .
        //collision azalırsa bu sefer dizinin eleman sayısını çoğaltmak gerekir bu hafızayı arttırır
        //hashing de collision 2 şekilde düşer. 1 hash functionu homojen hale getirmek ,,2 dizinin eleman sayısını arttırmaktır.
        //hash fucntiona mod eklenir.
        //?-perfect hashing
        
        
    }
}