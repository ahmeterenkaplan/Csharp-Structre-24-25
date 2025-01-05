namespace StakCalısmam;

class Program
{
    // Stack (Yığın)
    // Ara elemanlara doğrudan erişim yoktur.
    // LİFO = Last in First out yani son giren ilk çıkar yada ilk giren son çıkar prensibine göre çalışır.
    // Staklerde veriye belirli bir sıraya göre erişilebilir.
    // Stacklerde eleman sayısı çalışma sırasında değiştirilebilir.
    // Stacklerde eleman ekleme-çıkarma işlemi en üstten (top) yapılır.
    // Stack için yeterli bellek kalmazsa stack patlar yani stackoverflow hatası alırız.
    // Push eleman ekleme, Pop eleman çıkarma, Peek en üstteki elemanı döndürür.
    // Stackler İşletim sistemleri, Oyun yazılımları , bazı diger yazılımlarda ,compiler,infix postfix işlemleri ve metot çagırmalarda kullanılır.
    
    static int topla(int a ,int b) 
    {
        return a + b;
    }
    static int cıkar(int a, int b)
    {
        return a - b;
    }
    static int carp(int a, int b)
    {
        return a * b;
    }
    static int bol(int a, int b)
    {
        return a / b;
    }
    //Diziler ile stack oluşturma :
    static int[] stack=new int[100];
    static int sp = -1;
    static void Push(int data)
    {
        if(sp>=stack.Length)return; //Dizi ile oluşturdugumuz için stack patlamasın diye önlem aldık yani stack full dolu gibi düşünebiliriz dizi ile oluşturdugumuz için.
        sp++;
        stack[sp] = data;
    }

    static int pop()
    {
        if(sp<=-1)return -1;// stack boşsa eğer stackten çıkaracak birşey olmaz bunun için önlem aldık.
        int temp=stack[sp];
        sp--;
        return temp;
    }

    static int Peek()
    {
        return stack[sp];
    }
    // Linked List ile Stack oluşturma.
    class Block
    {
        public int data;
        public Block next;
        public Block prev;
    }
    static Block spLinked=null;
    static void PushLinked(int data)
    {
        Block tmp = new Block();
        tmp.data = data;
        if (spLinked == null){ spLinked=tmp; return;}
        spLinked.next=tmp;
        tmp.prev=spLinked;
        spLinked = tmp;
    }
    static int PopLinked()
    {
        int data=spLinked.data;
        spLinked = spLinked.prev;
        return data;
    }
    static int StackcountLinked()
    {
        int a = 0;
        Block tmp = spLinked;
        while (tmp!=null)
        {
            tmp = tmp.prev;
            a++;
        }
        return a;
    }
    static int PeekLinked()
    {
        int data=spLinked.data;
        return data;
    }
    static void Main(string[] args)
    {
        Push(12);
        Push(22);
        Push(32);
        Push(42);
        // Console.WriteLine(pop());// Pop ettigimizde stack'e en son giren veri çıkacak yani 42.
        PushLinked(1);
        PushLinked(2);
        PushLinked(3);
        PushLinked(4);
        PushLinked(5);
        //Console.WriteLine(PopLinked());
        //Console.WriteLine(PopLinked());
        //Console.WriteLine(PopLinked());
        
        // Stack ile string ifadeyi tersten yazdırma ;
        string st = "traş";
        for (int i = 0; i < st.Length; i++)
        {
            Push(st[i]);
        }
        while (sp!=-1)
        {
            Console.Write((char)pop());
        }
        
        // Stack ile Palindromik string bulma ;
        string palst = "mum";
        int hata = 0;
        for (int i = 0; i < palst.Length; i++)
        {
            Push(st[i]);
        }
        for (int i = 0; i < palst.Length; i++)
        {
            if(pop()==palst[i]){
                hata++;
                break;
            }
        }
        if (hata==0)
        {
            Console.WriteLine("palindromik");
        }
        else
        {
            Console.WriteLine("palindromik değil");
        }
        
        // Stack ile PARANTEZ (24-25 1.Çözüm) ;
        
        string st3 = "{{[[())]]}}";
        string p = "([{}])";
        int hata3 = 0;
        for (int i = 0; i < st3.Length; i++)
        {
            if(p.IndexOf(st3[i]) != -1)continue;
            if (p.IndexOf(st3[i]) <= 2)
            {
                PushLinked((st3[i]));
            }
            else
            {
                if (StackcountLinked()==0){hata3=1;break;}
            }
            char ch = (char)PopLinked();
            if (st3[i]==')')
            {
                if(ch!='('){hata3=1;break;}
            }
            if (st3[i]==']')
            {
                if(ch!='['){hata3=1;break;}
            }
            if (st3[i]=='}')
            {
                if(ch!='{'){hata3=1;break;}
            }
        }
        if (hata3==0)
        {
            Console.WriteLine("doğru1");
        }
        else
        {
            Console.WriteLine("yanlış1");
        }
        // Stack ile PARANTEZ (24-25 2.Çözüm) ;
        string stt = "()(){{}}[][]){[()]}";
        string par = "([{)]}";
        int hataflag = 0;
        for (int i = 0; i < stt.Length; i++)
        {
            int indis=par.IndexOf(stt[i]);
            if (indis==-1)
            {
                continue;
            }
            if (indis<=2)
            {
                PushLinked(par[indis+3]);
            }
            else
            {
                if (StackcountLinked()==0)
                {
                    hataflag = 1;
                    break;
                }
                char chh = (char)PopLinked();
                if (stt[i]!=chh)
                {
                    hataflag = 1;
                    break;
                }
            }
        }
        if (hataflag==0)
        {
            Console.WriteLine("doğru2");
        }
        else
        {
            Console.WriteLine("yanlış2");
        }
        
        // İNFİX to POSTFİX
        string infix = "a+b*c-d";// dönüştürülecek ifade
        string postfix = "";//sonuç burada birikecek
        string op = "$+-/*()";//operatörler
        int[] once = { 0, 2,2,3,3,1,1};//operatörlerin öncelik sırası
        Push('$');//stackte işlem bitimini belirtmek için kullanıdık
        for (int i = 0; i < infix.Length; i++)
        {
            int indis=op.IndexOf(infix[i]);
            if (indis==-1)
            {
                postfix=postfix+infix[i];
                continue;
            }
            if (infix[i]=='(')
            {
                Push(infix[i]);
                continue;
            }
            if (infix[i]==')')
            {
                while ((char)Peek()!='(')
                {
                    postfix=postfix+(char)pop();
                }
                pop();
                continue;
            }
            if (once[indis] > once[op.IndexOf((char)Peek())])
            {
                Push(infix[i]);
            }
            else
            {
                while (once[indis]<=once[op.IndexOf((char)Peek())])
                {
                    postfix += (char)pop();
                }
               Push(infix[i]);
            }
        }
        while (Peek()!=(byte)'$')
        {
            postfix+=(char)pop();
        }
        Console.WriteLine(postfix);
        
        
        // POSTFİX ifadeyi sayısallaştırma.
        string postfix3 = "ab*c+d-";
        string degişken = "abcd";
        int[] deger = { 1, 2, 3, 4 };//değişkenlere değer atadık kullanıcıdan da alınabilirdi
        string op3 = "/+-*";
        for (int i = 0; i < postfix3.Length; i++)
        {
            if(op3.IndexOf(postfix3[i]) == -1) 
            {
                int ındıs = degişken.IndexOf(postfix3[i]);
                Push(deger[ındıs]);continue;
            }
            int op1 = pop();
            int op2 = pop();
            int sonuc = 0;
            if(postfix3[i] == '+') 
            {
                sonuc = topla(op1,op2);
            }
            else if (postfix3[i] == '-')
            {
                sonuc = cıkar(op2, op1);
            }
            else if (postfix3[i] == '*')
            {
                sonuc = carp(op1, op2);
            }
            else if (postfix3[i] == '/')
            {
                sonuc = bol(op2, op1);
            }
            Push(sonuc);
        }
        Console.WriteLine(pop()) ;
    }
}