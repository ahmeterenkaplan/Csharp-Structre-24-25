namespace Veri3;

class Program
{
    static void Main()
    {
        #region tek boyutlu dizide en büyük eleman bulma

        int [] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 ,31,23,444,1112,-134,123333,123441,2222311};
        int eb = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (eb<numbers[i])
            {
                eb=numbers[i];
            }
        }
        // Console.WriteLine(eb);
        #endregion

        #region çok boyutlu dizide en büyük eleman bulma tek döngü
/*
        int[,,,,] x = new int[3, 4, 5, 6, 7]; //0 ,1 ,2
        x[0, 0, 0, 0, 0] = 7;
        x[0, 0, 0, 0, 1] = 8;
        x[0, 0, 0, 1, 0] = 9;
        x[0, 0, 0, 1, 1] = 15;
        x[0, 0, 1, 0, 0] = 10;
        x[0, 1, 0, 0, 0] = 1871;
        x[1, 0, 0, 0, 0] = 12;
        x[1, 2, 3, 4, 5] = 180;
        x[2, 2, 4, 3, 5] = 140;

        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        int e = 0;

        int enB = 0;

        while (a!=2||b!=3||c!=4||d!=5||e!=6) // dizinin sınır değerleri n-1 çnk 0dan baslar
        {
            if (enB<x[a,b,c,d,e])
            {
                enB=x[a,b,c,d,e];
            }
            e++;
            if (e==7)
            {
                e = 0;
                d++;
            }
            if (d==6)
            {
                d = 0;
                e = 0;
                c++;
            }

            if (c==5)
            {
                c = 0;
                d = 0;
                e = 0;
                b++;
            }
            if (b == 4)
            {
                b = 0;
                c = 0;
                d = 0;
                e = 0;
                a++;
            }
            if (a==3)
            {
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                e = 0;
            }
        }
        */
        //Console.WriteLine(enB);
        #endregion

        #region Dört boyutlu dizide en büyük eleman bulma iç içe döngü

        int[,,,] Arrs = new int[2, 3, 4, 5];
        int enbb = 0;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    for (int l = 0; l < 5; l++)
                    {
                        if (enbb < Arrs[l,j,k,l])
                        {
                            enbb=Arrs[l,j,k,l];
                        }
                    }
                }
            }
        }
        

        #endregion

        #region 100 elemanlı bir dizinin en büyük 5 elemanını bulup başka diziye aktarma.

        int[] yuz = new int[100];
        int[] bes = new int[5];
        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                for (int k = 4; k < 0; k--)
                {
                    bes[k] = bes[k - 1];
                }
                bes[j] = yuz[i];
                break;
            }
        }

        #endregion

        #region en büyük eleman bulma rekursif

        

        #endregion

        #region örnek

        int[,,,] deneme=new int[6,7,9,5];
        deneme[0, 0, 0, 0] = 112;
        deneme[0, 0, 0, 1] = 132;
        deneme[0, 0, 0, 2] = 142;
        deneme[0, 0, 0, 3] = 154;
        deneme[0, 0, 0, 4] = 1656;
        deneme[4, 5, 7, 3] = 16587;
        deneme[4, 5, 7, 4] = 16789;
        deneme[4, 5, 8, 4] = 16899;
        deneme[5, 6, 8, 4] = 126999; // son indisi neden görmüyor hocaya sor ????

        int ad = 0;
        int bd = 0;
        int cd = 0;
        int ed = 0;
        int ebD = 0;
        while (ad != 5 || bd != 6 || cd !=8 || ed != 4)
        {
            if (ebD<deneme[ad,bd,cd,ed])
            {
                ebD=deneme[ad,bd,cd,ed];
            }

            ed++;
            if (ed==5)
            {
                ed = 0;
                cd++;
            }

            if (cd==9)
            {
                cd = 0;
                ed = 0;
                bd++;
            }

            if (bd==7)
            {
                bd = 0;
                cd = 0;
                ed = 0;
                ad++;
            }

            if (ad==6)
            {
                ad = 0;
                bd = 0;
                cd = 0;
                ed = 0;
            }
        }

        //Console.WriteLine(ebD);
        //Console.WriteLine(deneme[5, 6, 8, 4]);


        #endregion

        #region dizi içersinde en çok tekrar eden sayı
        // iç içe döngülerde ilk önce en içteki döngü tamamen çalışır unutma.
        int[] tekrar = {
            1, 1, 1, 2, 2, 2, 1, 2, 2, 1, 2, 89, 2, 2, 2, 2, 2, 7, 21, 6, 13, 12, 1, 23, 1, 1, 23, 1, 3, 1, 3, 1, 322,
            1, 31, 3, 1, 3, 1, 3, 2312, 3, 3, 3, 3,
        };
        int enCok = 0;
        for (int i = 0; i < tekrar.Length; i++)
        {
            int sayac1 = 0;
            for (int j = 0; j < tekrar.Length; j++)
            {
                if (tekrar[i] == tekrar[j])
                {
                    sayac1++;
                }
            }

            if (enCok < sayac1)
            {
                enCok=sayac1;
            }
        }

        //Console.WriteLine(enCok);

        #endregion

        #region örnek

        int[] babus = { 1, 1, 1, 1, 1, 3, 3, 3, 2, 2, 2, 3, 3, 2, 2, 3, 2, 3, };
        int eC = 0;
        for (int i = 0; i < babus.Length; i++)
        {
            int say = 0;
            for (int j = 0; j < babus.Length; j++)
            {
                if (babus[i] == babus[j])
                {
                    say++;
                }
            }

            if (eC<say)
            {
                eC=say;
            }
        }

        Console.WriteLine(eC);

        #endregion

        #region dizi içersinde en çok tekrar eden recursif

        

        #endregion

        #region AHS(Atilla Hoca Sorusu) 
        //Klavyeden boyutları ve bu boyutların büyüklüğü girilen dizinin yine klavyeden girilen elemanının adresini bul.
        // örnek adresleme=
        // X[i1,i2,i3,i4]
        // X[b1,b2,b3,b4] olmak üzere;
        // X[0]+(i1*b2*b3*b4+i2*b3*b4+i3*b4+i4)*4
        
        // 1.Adım = Dizinin kaç boyutlu oldugunu ve bu boyutların büyüklüğünü aldık.
        Console.WriteLine("diziniz kaç boyutlu olsun?");
        int boyutSayisi=Convert.ToInt32(Console.ReadLine());
        int[] boyutDizisi=new int[boyutSayisi];
        for (int i = 0; i < boyutSayisi; i++)
        {
            Console.WriteLine((i+1)+". boyutun büyüklüğünü girin.");
            int boyut=Convert.ToInt32(Console.ReadLine());
            boyutDizisi[i]=boyut;
        }
        
        // 2.Adım = Aranan dizinin indislerini alacağız.
        int[] arananelemanDizisi=new int[boyutSayisi];
        Console.WriteLine("Adresini  bulmak istediginiz elemanın ;");
        for (int i = 0; i < boyutSayisi; i++)
        {
            Console.WriteLine((i+1)+". Boyuttaki eleman numarasını girin.");
            int arananEleman=Convert.ToInt32(Console.ReadLine());
            arananelemanDizisi[i]=arananEleman;
        }

        int sayac = 1;
        int adres = 0;
        
        // 3.Adım = Ramde adres hesaplama kısmı.
        for (int i = 0; i < boyutSayisi; i++)
        {
            int tempAdres=arananelemanDizisi[i];
            int tempSayac=sayac;
            for (int j = 0; j < (boyutSayisi-(i+1)); j++)
            {
                tempAdres = tempAdres * boyutDizisi[tempSayac];
                tempSayac++;
            }
            sayac++;
            adres+=tempAdres;
        }

        Console.WriteLine(adres*4);

        #endregion
    }
}