using System.Threading.Channels;

namespace Veri_1;

class Program
{
    static void Main(string[] args)
    {
        // ÇOK BOYUTLU DİZİLER //
        /*
         * C#'da çok boyutlu diziler birden fazla boyutlu veriyi depolamak için kullanılır.
         * Bu çok boyutlu diziler aşagıdaki gibi tanımlanabilir.
         */
        
        // -- iki boyutlu dizi --MATRİS
        // bu iki boyutlu dizi 3 satır ,5 stundan oluşur matris formundadır.
        int [,] ikiBoyut=new int[3,5];
        // -- çok boyutlu dizilerde elemanlara erişim şu şekildedir.
        //ikiBoyut[1, 3] = 112;
        //int indexVerisi = ikiBoyut[1, 3]; // 1.satır 3. stundaki veriye erişim.
        
        // -- üç boyutlu dizi
        int[,,]ucBoyut=new int[3,5,2];// bu dizi 3 katman 5 satır ve 2 stundan oluşan bir dizidir.
        // -- elemanlara erişim :
        //ucBoyut[1,2,3] = 43;
        
        // çok boyutlu dizileri oluşturma ve doldurma
        // İKİ BOYUTLU DİZİ _ MATRİS
        // Matrislerde yani iki boyutlu dizilerde matris boyutunun -1 tane indexi var yani 3,3 ise 0. satır , 1.satır ve 2.satır şeklinde.
        int [,] dizi1=new int[4,3];
        for (int i = 0; i < dizi1.GetLength(0); i++) // satırlar
        {
            for (int j = 0; j < dizi1.GetLength(1); j++) //stunlar
            {
                dizi1[i,j] = i + j; // örnek olarak satır ve stun index toplamı ile doldurduk.
            }
        }
        
        // iki boyutlu dizi el ile dordurma ve yazdırma
        int[,] dizi2 =
        {
            { 1, 2, 3, 4, 5 },
            { 1, 2, 3, 4, 5 },
            { 1, 2, 3, 4, 5 }
        };
        for (int i = 0; i < dizi2.GetLength(0); i++)
        {
            for (int j = 0; j < dizi2.GetLength(1); j++)
            {
                Console.Write(dizi2[i,j]+" ");
            }

            Console.WriteLine();
            
        }
        
        
        // iki boyutlu dizileri yazdırma
        for (int i = 0; i < dizi1.GetLength(0); i++)
        {
            for (int j = 0; j < dizi1.GetLength(1); j++)
            {
                Console.Write(dizi1[i,j]+" ");
            }

            Console.WriteLine();
            
        }
        
        // ÜÇ BOYUTLU DİZİLERİ OLUŞTURMA VE DOLDURMA =
        int[,,] dizi3=new int [3,3,3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    dizi3[i,j,k] = i + j + k;
                }
            }
        }
        // ÜÇ BOYUTLU DİZİ YAZDIRMA =
        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write(dizi3[i, j, k] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        // ÖRNEKLER //
        // Soru 1: 3x3 boyutunda bir dizi oluşturun ve içindeki tüm elemanları 1 ile doldurun.
        int [,] dizi4=new int [3,3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                dizi4[i,j] = 1;
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(dizi4[i,j] + " ");
            }

            Console.WriteLine();
        }
        // Soru 2: 2x2x2 boyutunda bir üç boyutlu dizi oluşturun. Her bir elemanın değerini, satır, sütun ve derinlik indekslerinin toplamı olacak şekilde ayarlayın.
        int[,,]dizi5=new int [2,2,2];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    dizi5[i,j,k] = i+j+k;
                }
            }
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j<2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.Write(dizi5[i,j,k] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
        
        //Soru 3: 4x4 boyutunda bir dizi oluşturun ve bu dizinin köşegeninde (dizi[i,i]) olan tüm elemanları 1 yapın, diğer elemanları ise 0 yapın.
        
        int[,]dizi6=new int [4,4];
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (i == j)
                {
                    dizi6[i,j] = 1;
                }
                else
                {
                    dizi6[i,j] = 0;
                }
            }
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(dizi6[i,j]);
            }

            Console.WriteLine();
        }
        
        //Soru 4: 3x3 boyutunda bir dizi oluşturun ve elemanlarına rastgele değerler atayın. Daha sonra bu dizinin satırlarının ve sütunlarının toplamlarını hesaplayın ve ekrana yazdırın.
        int [,] dizi7=new int [3,3];
        int toplam = 0;
        Random random = new Random();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                dizi7[i,j] = random.Next(0,10);
                toplam=toplam + dizi7[i,j];
            }
        }

        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                 
                 Console.Write(dizi7[i,j]);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine($"satır ve stünların toplamı : {toplam}");
        
        
        //Soru 5: 5x5 boyutunda bir dizi oluşturun ve bu dizinin dış çerçevesindeki (ilk ve son satır/sütun) elemanları 1, diğer elemanları 0 yapın.
        int [,] dizi8=new int [5,5];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i==0 || i==4||j==0||j==4)
                {
                    dizi8[i,j] = 1;
                }
                else
                {
                    dizi8[i,j] = 0;
                }

                Console.Write(dizi8[i,j]+" ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        //Soru 6: 3x3x3 boyutunda bir dizi oluşturun ve elemanlarını rastgele sayılarla doldurun. Bu dizideki tüm elemanların ortalamasını hesaplayın.
        
        int [,,] dizi9=new int [3,3,3];
        
        float toplam333 = 0;
        float ortalama = 0;
        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    dizi9[i,j,k] = random.Next(0,10);
                    toplam333=toplam333 + dizi9[i,j,k];
                    Console.Write(dizi9[i,j,k]+" ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
        ortalama=toplam333/27;
        Console.WriteLine(ortalama);
        
        //Soru 7: 6x6 boyutunda bir dizi oluşturun ve bir spiral şeklinde 1’den 36’ya kadar sayılarla doldurun.
        int [,] dizi10=new int [6,6];
        int sayac = 1;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                dizi10[i,j] = sayac;
                sayac++;
            }
        }

        // HOCAYA SOR ? : özel metot olmadan birden fazla if olmadan nasıl spiral şeklinde yazdıracagım ?

        Console.WriteLine();
        //Soru 8: Bir matrisin (iki boyutlu dizi) transpozunu hesaplayan bir fonksiyon yazın.
        // transpoz = devrigi
        int str = 2;
        int stn = 3;
        int [,] trnspozsuz=new int [str,stn];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                trnspozsuz[i,j] = random.Next(0,10);
                Console.Write(trnspozsuz[i,j]+" ");
            }
            Console.WriteLine();
        }
        int[,] transpozlu=new int [stn,str];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                transpozlu[i,j] = trnspozsuz[j,i];
                Console.Write(transpozlu[i,j]+" ");
            }

            Console.WriteLine();
        }
        // HOCAYA SOR :  Başka daha kolay nasıl alabilirim ?

        Console.WriteLine();
        
        
        //Soru 9: 3x3 boyutunda bir dizi oluşturun. Bu diziyi, bir satır ve sütun takası olmadan döndüren bir algoritma yazın (örneğin, diziyi 90 derece döndürün).
        int[,] matris = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Yeni bir dizi oluştur 90 derece döndürmek için
        int[,] donmusMatris = new int[3, 3];

        // 90 derece döndürme işlemi
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                donmusMatris[i,j] = matris[2-j, i];
            }
        }
        //Matrisin elemanlarını 90 derece döndürürken, satırlar sütunlara, sütunlar ise satırlara dönüşür.
        //İlk adımda:
        // i = 0, j = 0:
        // Orijinalde matris[0, 0] değeri 1'dir. Bu, yeni matrisin donmusMatris[0, 2] konumuna yerleştirilir.
        // Yani, 1 yeni matrisin üçüncü sütununda, birinci satıra gelir.
        // İkinci adımda:
        // i = 0, j = 1:
        // Orijinalde matris[0, 1] değeri 2'dir. Bu, yeni matrisin donmusMatris[1, 2] konumuna yerleştirilir.
        // Yani, 2 yeni matrisin üçüncü sütununda, ikinci satıra gelir.
        // Üçüncü adımda:
        // i = 1, j = 0:
        // Orijinalde matris[1, 0] değeri 4'tür. Bu, yeni matrisin donmusMatris[0, 1] konumuna yerleştirilir.
        // Yani, 4 yeni matrisin ikinci sütununda, birinci satıra gelir.
        
        // Döndürülmüş matrisi ekrana yazdır
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(donmusMatris[i, j] + " ");
            }
            Console.WriteLine();
        }
        int[] dizi = { 1, 2, 3, 1, 3, 3, 3, 3, 3, 3, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5,3,2,1,2,2,2,2,2,2,22,2,2,2,2,2,2,2,2,2,};

        int enCok = 0;


        for (int i = 0; i < dizi.Length; i++)
        {
             sayac = 0;

            for (int j = 0; j < dizi.Length; j++)
            {
                if (dizi[i] == dizi[j])
                {
                    sayac += 1;
                }
            }
            if (enCok < sayac)
            {
                enCok = sayac;
            }
        }

        Console.WriteLine(enCok);
        
    }
}