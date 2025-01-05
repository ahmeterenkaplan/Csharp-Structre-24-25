namespace linklists;

class Program
{
    class Block
    {
        public int Data;
        public Block Next;
        public Block Previous;
        // public Block Prev;
    }
    static void Main(string[] args)
    {
        Block b = new Block();
        b.Data = 1;
        Block b2 = new Block();
        b.Next = b2;
        b2.Data = 2;
        
        // Bir head bloğumuz var bu bloktan başlayarak 10 tane blok oluştur, değer ata ve değerleri ekrana yazdır.
        Block head = null;
        Block last = null;
        for (int i = 0; i < 10; i++)
        {
            head = new Block(); // head =null yani head blogu olmadıgı için new ettik.
            head.Data = i;
            head.Next = last;
            last = head;

        }

        //Console.WriteLine(head.Data);
        int n = 0;
        Block tmp = head;
        while (tmp != null)
        {
            n++;
            //Console.WriteLine(n+".eleman ="+" " +tmp.Data);
            tmp = tmp.Next;
        }

        //1-)Listenin en başına data değeri -1 olan blok ekle
        Block tmp3 = new Block();
        tmp3.Data = -1;
        tmp3.Next = head;
        head = tmp3;
        //Console.WriteLine(tmp3.Next.Next.Next.Data);
        
        //2-)Listenin son elemanından sonra data değeri 100 olan blok ekle
        Block tmp4 = new Block();
        tmp4.Data = 100;
        last = head;
        while (last.Next != null)
        {
            last = last.Next;
        }
        last.Next = tmp4;
        last = tmp4;
        
        //3-)Listenin ilk elemanını sil.
        
        head=head.Next;
        head.Previous = null;
        
        //4-) Listenin son eleman sil.
        // ilk son elemanı bulmalıyız.
        Block tmp5 = head;
        while (tmp5.Next.Next!=null)
        {
            tmp5 = tmp5.Next;
        }
        tmp5.Next = null;
        
        //6-)Data değeri 5 olan bloktan sonra blok ekle
        Block tmp6 = head;
        while (tmp6!=null)
        {
            if (tmp6.Data==5)
            {
                Block besdensonra=new Block();
                besdensonra.Data = 333;
                besdensonra.Next = tmp6.Next.Next;
                tmp6.Next = besdensonra;
            }
            tmp6 = tmp6.Next;
        }
        //7-)Data değeri 5 olan bloktan önce datası -5 olan bir blok ekle
        /*Block tmp7 = head;
        while (tmp7!=null)
        {
            if (tmp7.Next.Data==5)
            {
                Block besdenonce = new Block();
                besdenonce.Data = -5;
                besdenonce.Next = tmp7.Next;
                tmp7.Next = besdenonce;
            }
            tmp7 = tmp7.Next;
        }*/

        
        // listeyi yazdırma
        Block yaz = head;
        while (yaz != null)
        {
            Console.WriteLine(yaz.Data);
            yaz = yaz.Next;
        }




    }
}