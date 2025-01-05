using System.Runtime.InteropServices;

namespace veriders4.hafta;

class Program
{
    static void Main(string[] args)
    {
        //rekursif programlama
        /*rekursif programlama bir fonksiyonun kendisini çagırdıgı bir tekniktir.
         * genellikle daha büyük bir problemi,daha küçük alt problemlere bölerek çözmektir.
         *
         * temel durum(base case)Ç rekursiyonun sonlanmasını sağlayan
         * rekursif çagrı=
         *
         * LİFO = 123 sayısı için
         * 1.=  n % 10 + BasamaklariTopla(n / 10); 12
         * 2.=  n % 10 + BasamaklariTopla(n / 10); 1
         * 
         */
        //5!=5*4*3*2*1
        //faktoriyel rekursif
        int sonuc = Fac(5);
        Console.WriteLine(sonuc);
        //123; sayi%10 birler bas , sayi/10
        //basamak toplayan rekurisf
        int snc = BasamaklariTopla(333);
        Console.WriteLine(snc);
        //fibonacci rekursif çözüm
        
        // SINAV :stun öncelikli sıralanmış hafızada şu indise sahip elemanın ramdeki adres indisi kaçtır?
        int[,,]dizi=new int[3,3,3] ;
        int bas = 0;
        int toplam = 0;
        for (int i = 0; i < 3; i++)//derinlik
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    dizi[i, j, k] = bas;
                    bas++;
                    toplam+=dizi[i, j, k];
                }
            }
        }
        Console.WriteLine(toplam);
        /*
         * adres indis
         * 3,3,3
         * x,y,z
         * x*3*3+y*3+z
         */
        int[] boyutlar = { 3, 3, 3 };
        int[] indisler = { 2, 1, 3 };
        int sonucRam=RamDizilis(boyutlar, indisler);
        Console.WriteLine(sonucRam);
        
    //SORU
    // çok boyutlu bir matris var.
    // bu matrisin içindeki pozitif elemanların sayısını ve
    // negatif elemanların toplamını geriye döndüren bir rekursif metot yazınız.
    
    
    }

    public static int PozitifSayisi(int[,,] dizi, int x, int y, int z, int boyutX, int boyutY, int boyutZ)
    {
        if (x==boyutX)
        {
            return 0;
        }
        int sayici = 0;
        int sonrakiX = z == boyutZ - 1 && y == boyutY - 1 ? x + 1 :x;
        int sonrakiY = z == boyutZ - 1 ? (y + 1)%boyutY : y;
        int sonrakiZ = (z + 1) % boyutZ;    
        sayici=dizi[x,y,z] > 0 ? sayici + 1: sayici;
        return PozitifSayisi(dizi, sonrakiX, sonrakiY, sonrakiZ, boyutX, boyutY, boyutZ);
    }public static int NegatifSayisi(int[,,] dizi, int x, int y, int z, int boyutX, int boyutY, int boyutZ)
    {
        if (x==boyutX)
        {
            return 0;
        }
        int toplam = 0;
        int sonrakiX = z == boyutZ - 1 && y == boyutY - 1 ? x + 1 :x;
        int sonrakiY = z == boyutZ - 1 ? (y + 1)%boyutY : y;
        int sonrakiZ = (z + 1) % boyutZ;    
        toplam=dizi[x,y,z] < 0 ? toplam + dizi[x,y,z]: toplam;
        return NegatifSayisi(dizi, sonrakiX, sonrakiY, sonrakiZ, boyutX, boyutY, boyutZ);
    }
    public static int RamDizilis(int[]boyutlar,int[]indisler)
    {
        int boyut=boyutlar.Length;
        int ramIndis = 0;
        int carpimIndisi = 1;
        for (int i = boyut-1; i >= 0; i--)
        {
            ramIndis += indisler[i]*carpimIndisi;
            carpimIndisi *= boyutlar[i];
        }
        return ramIndis;
    }
    public static int BasamaklariTopla(int n)
    {
        if (n<10)
        {
            return n;
        }

        return n % 10 + BasamaklariTopla(n / 10);
    }
    public static int Fac(int n)
    {
        if (n <= 1)
        {
            return 1;
        }

        return n * Fac(n - 1);
    }

    public static int Fib(int n)
    {
        if (n<=1)
        {
            return n;
        }
        return Fib(n-1)+Fib(n-2);
    }
    
}