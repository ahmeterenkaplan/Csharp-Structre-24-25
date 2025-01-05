using System.Runtime.Intrinsics.Arm;

namespace veriders3.hafta;

class Program
{



    static void Main(string[] args)
    {
        //değişkenler
        //diziler(arrays)
        // Tek boyutlu diziler
        // elemanlar yan yanadır
        // elemanlar aynı değişken tiptedir
        int[] dz = new int[10]; //her int 4 byte bu dizi 40 byte yer kaplar.
        // dz değişkeni bir pointer'dır.
        //heap pcde size ayrılmış olan kullanılmayan boş alandır.
        // dz[n] = base adres + n * 4 ;
        for (int i = 0; i < 10; i++)
        {
            dz[i] = i+1;
        }
        // bu dizinin  en büyük elemanını bul.
        int enbuyk = dz[0];
        for (int i = 1; i < 10; i++)
        {
            if (enbuyk < dz[i])
            {
                enbuyk = dz[i];
            }
        }

        // dizinin ikinci en büyük elemanını bul.
        // ÖDEV: recursive çöz
        int eb2 = 0;
        for (int i = 0; i < 10; i++)
        {
            if (enbuyk < dz[i])
            {
                eb2 = enbuyk;
                enbuyk = dz[i];
            }
            else if (enbuyk < dz[i])
            {
                eb2 = dz[i];
            }
        }

        
        // en büyük 3. elemanı bulan kod
        int eb3 = 0;
        for (int i = 0; i < 10; i++)
        {
            if (enbuyk < dz[i])
            {
                eb3 = eb2;
                eb2 = enbuyk;
                enbuyk = dz[i];
            }
            else if (eb2 < dz[i])
            {
                eb3 = eb2;
                eb2 = dz[i];
            }
            else if (eb3 < dz[i])
            {
                eb3 = dz[i];
            }
            
        }
        
    }
}
// ÖDEV : en büyük n'inci elemanı bulan kod.

        //for (int i = 0; i < 100; i++)
        // {
        //     dz[i] = i;
        // }

        // int base1 = 0;
        // for (int i = 0; i < 100; i++)
        // {
        //     base1 = i;
        // }
/*
        // İKİ BOYUTLU DİZİLER ( MATRİSLER )
        int[,] x=new int[2,3];
        // 2 satır 3 stun 2*3 6 adet eleman (hücre) vardır.
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                x[i,j]=i*j;
            }
        }
        //  int new[s1,s2]
        //  s[1,1] x[a1,a2]
        //  1 satırda stun sayısı kadar eleman var.
        //  s2 adet eleman var 
        //  kaç byte = N bayte n değişken tipine göre değşir
        //  a1*a2*nb+a2*nb
        //  [1,2] = base + 1*3*4 + 2*4
        
        
        // fakültemizdeiki bölümler
        Random rnd = new Random();
        int[,] muh=new int[7,2]; // öğrenci mevcutları
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                muh[i,j]=rnd.Next(1,100);
                Console.Write(muh[i,j]+" ");
            }

            Console.WriteLine();
        }
        //0 bm 1 eee 2 endüstri 3 malzeme....
        // en fazla öğğrenci olan bölüm.
        // bu çözümün iö ve nö olan versiyonunu bul
        // evde recursive halinde çöz.
        int ec = 0;
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (ec<muh[i,j])
                {
                    ec=muh[i,j];
                }
            }
        }
        // 15x15 lik matrisin satır ve stun toplamları ve satır stun'ların en büyügü
        
        
        // üç boyıtlu diziler
        int [,,] threed=new int[2,3,4];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    threed[i,j,k]=i*j*k;
                }
            }
        }
        // new int[s1,s2,s3]
        //threed[a1,a2,a3]
        //nb = 4;
        
        //a1*s2*s3*nb+a2*s3*nb+a3*nb; FORmül
        
        //hangi bölümün nö mevcutu daha fazla?
        int [,,] muh2=new int[7,2,4];
        // 7 = bölğmler
        // 2 no ve io
        // 4 sınıf ögr sayısı
        muh2[0, 0, 0] = 77;
        muh2[0, 1, 3] = 250;
        int enb = 0;
        int blm = 0;
        for (int i = 0; i < 7; i++)
        {
            int t = 0;
                for (int k = 0; k < 4; k++)
                {
                    t=t+muh2[i,0,k];
                    if (t>enb)
                    {
                        t = enb;
                        blm = i;
                    }
                }
            
        }
        
        // 4 boy dizi
        int[,,,]dizi=new int[3,2,4,3];
        //int[s1,s2,s3,s4]
        //dizi[a1,a2,a3,a4]
        //a1,s2*s3*s4*nb + a2*s3*nb + a3*nb
        
        // 5 boy dizi
        int [,,,,]dizi5=new int[3,2,4,3,2];
        //a1*s2*s3*s4*nb+a2*s3*s4**nb+a3*s4*nb+a4*nb
        //il ilçe  veya üniversite  sorusu glblr.
        // text dosyaları hakkında araştır.
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    for (int l = 0; l < 3; l++)
                    {
                        for (int m = 0; m < 2; m++)
                        {
                            dizi5[i, j, k, l, m] = 123;
                        }
                    }
                }
            }
        }
        
    }
    */
