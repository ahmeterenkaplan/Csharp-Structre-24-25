namespace veriVizeÖncesiTekrar;

class Program
{   
    //garbage collector (çöp toplayıcısı) : sizin programnızın create ettigi ve sonra unuttugu bazı bilgileri siler.
    public class MyBlock
    {
        public string name; 
        public string ogrn;
        public byte sinif;
        public MyBlock next;
        public MyBlock prev;
        public int data;
    }

    static void Yazdir(MyBlock my1)
    {
        if (my1 == null) return;
        Console.WriteLine(my1.data);
        Yazdir(my1.next);
    }
    static int Yazdir1(MyBlock my1)
    {
        if (my1 == null) return 0;
        Console.WriteLine(my1.name);
        return my1.data+Yazdir1(my1.next);
    }
    // Rekursif linked list oluşturma.
    public static MyBlock LinkListCreate(MyBlock head, int veri)
    {
        if (veri == 0) return head;
        MyBlock blc=new MyBlock();
        blc.data=veri;
        blc.next=head;
        Console.WriteLine(blc.data);
        return LinkListCreate(blc, veri-1);
    }

    
    //ÖDEV recursive en büyük değeri döndür. ???
   
    static void Main(string[] args)
    {
        MyBlock my1 = new MyBlock();
        my1.name = "ahmet";
        my1.ogrn = "123";
        my1.sinif = 1;
        
        MyBlock my2 = new MyBlock();
        my2.name = "eren";
        my2.ogrn = "223";
        my2.sinif = 2;
        my1.next = my2;
        
        MyBlock my3 = new MyBlock();
        my3.name = "kaplan";
        my3.ogrn = "323";
        my3.sinif = 3;
        my2.next = my3;
        
        MyBlock my4 = new MyBlock();
        my4.name = "veri";
        my4.ogrn = "423";
        my4.sinif = 4;
        my3.next = my4;
    
        // manuel yazdırma
        Console.WriteLine(my1.name);
        Console.WriteLine(my1.next.name);
        Console.WriteLine(my1.next.next.name);
        Console.WriteLine(my1.next.next.next.name);

        Console.WriteLine("");
        
        //döngü ile yazdırma
        MyBlock tmp = my1;
        while (tmp!=null)
        {
            Console.WriteLine(tmp.name);
            tmp = tmp.next;
        }
        
        //10 bloklu liste oluştur ve içine deger ata.
        // 1.ÇÖZÜM
        MyBlock head = null;
        MyBlock last = null;
        for (int i = 1; i < 11; i++)
        {
            MyBlock temp=new MyBlock();
            temp.data = i;
            if (head == null)
            {
                head = temp;
                last = temp;
            }
            else
            {
                last.next = temp;
                last = temp;
            }
        }
        // 2.ÇÖZÜM
        head = null;
        for (int i = 10; i > 0; i--)
        {
            MyBlock temp=new MyBlock();
            temp.data = i;
            temp.next = head;
            head = temp;
        }
        Console.WriteLine("");
        
        //döngü ile yazdırma
        tmp = head;
        while (tmp!=null)
        {
            //Console.WriteLine(tmp.data);
            tmp = tmp.next;
        }
        Console.WriteLine("");
        
        // Head tekli linked list'in ilk elemanına bakmaktadır.
        // 1. Bu listenin başına datası -1 olan bir blok ekleyin.
        MyBlock tmp2 = new MyBlock();
        tmp2.data = -1;
        tmp2.next = head;
        head=tmp2;
        // 2. Listenin sonuna data degeri 11 olan bir eleman ekleyiniz.
        last = head;
        MyBlock tmp3 = new MyBlock();
        tmp3.data = 11;
        while (last.next != null)
        {   
            last = last.next;
        }
        last.next = tmp3;
        last = tmp3;
        /*
         * Atilla çözümü : farklı çözüm: ahç
         * temp=head;
         * while(tmp.next!=null)
         * {tmp=tmp.next}
         * tmp.next=tmp3;
         */
        
        // 3. Bu listeyi recursive olarak create edin.
        // head = null; 
        // LinkListCreate(head, 10); recursive metot yukarıda.
        
        // 4. Listenin ilk elemanını sil.
        head = head.next;
        
        // 5. Listenin son elemanını sil.
        tmp = head;
        while (tmp.next.next != null)
        {
            tmp = tmp.next;
        }
        tmp.next = null;
        
        // n. elemanı bulma
        tmp = head;
        int adet = 1;
        int n = 5; // 5 olsun
        while (adet < n)
        {
            tmp = tmp.next;
            adet++; 
        }
        // recursive kısmı yazdırma
        Yazdir(head);
    }
}