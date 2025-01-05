namespace Veri2;

class Program
{
    static void Main(string[] args)
    {
        // TEK BOYUTLU DİZİ İÇİN
        //Diziyi oluşturduk.

        int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 1236, 17, 999, 123, 23, 2343, -9123 };

        //Dizinin en büyük elemanını tek döngü ile bulma.
        int eb = 0;
        for (int i = 0; i < 22; i++)
        {
            if (dizi[i] > eb)
            {
                eb = dizi[i];
            }
        }
        // Dizinin en büyük 2.elemanını bulma.
        int eb2 = 0;
        eb = 0;

        for (int i = 0; i < 22; i++)
        {
            if (dizi[i] > eb)
            {
                eb2 = eb; // Mevcut en büyük ikinci büyük olur
                eb = dizi[i]; // Yeni en büyük bulunur
            }
            else if (dizi[i] > eb2 && dizi[i] != eb)
            {
                eb2 = dizi[i]; // Yeni ikinci büyük bulunur
            }
        }
        
        // Dizinin en büyük 3. elemanını bulma
        
        int eb3 = 0;
        eb2 = 0;
        eb = 0;

        for (int i = 0; i < 22; i++)
        {
            if (dizi[i] > eb)
            {
                eb3 = eb2; // Mevcut ikinci büyük üçüncü büyük olur
                eb2 = eb; // Mevcut en büyük ikinci büyük olur
                eb = dizi[i]; // Yeni en büyük bulunur
            }
            else if (dizi[i] > eb2 && dizi[i] != eb)
            {
                eb3 = eb2; // Mevcut ikinci büyük üçüncü büyük olur
                eb2 = dizi[i]; // Yeni ikinci büyük bulunur
            }
            else if (dizi[i] > eb3 && dizi[i] != eb2 && dizi[i] != eb)
            {
                eb3 = dizi[i]; // Yeni üçüncü büyük bulunur
            }
        }
        
        
        //  BİR MATRİSİ 180 DERECE DÖNDÜRME
        // 180 derece döndürme hem satırlarını hem stunlarını ters çevirerek olur,
        // Yani : [2-i,2-j] = Ters çevirmedir.
        // Ters çevirme işleminde matrisin tam zıddındaki değere gider.
        int a = 1;
        int[,]dizidön = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                dizidön[i, j] = a++ ;
                
            }
        }
        int[,] yuzseksenDizi= new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                yuzseksenDizi[i, j] = dizidön[2-i, 2-j]; ;
               // Console.Write(yuzseksenDizi[i,j]);
            }
            Console.WriteLine(" ");
        }
        
        // Matrisi 270 derece döndürme.
        int[,] ikiyetmis=new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                ikiyetmis[i, j] = dizidön[j,2-i];
                //Console.Write(ikiyetmis[i,j] + " ");
            }

            Console.WriteLine();
        }
        
        // Tek boyutlu dizi içersinde en çok tekrar eden sayı.
        int[]diziTekrar=new int[99];
        Random rnd = new Random();
        for (int i = 0; i < 99; i++)
        {
            diziTekrar[i] = rnd.Next(19);
        }
        int encok = 0;
        for (int i = 0; i < 99; i++)
        {
            int sayac = 0;
            for (int j = 0; j < 99; j++)
            {
                if (diziTekrar[i] == diziTekrar[j])
                {
                    sayac+=1;
                }
                if (encok<sayac)
                {
                    encok=sayac;
                }
            }
        }
        Console.WriteLine(encok);
        
        // Çok boyutlu dizi içersinde en çok tekrar eden sayı.
        
        // Çok boyutlu dizilerde en fazla 1'in olduğu satırı bul.
    }
}