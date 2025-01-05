namespace stack;

class Program
{
    // last in first out , first in last out yani son gelenin ilk çıkma prensibine dayalı stack oluşturma.
    // 1. yol Diziler
    // 2.yol LinkedList
    static int[] stack = new int[100];
                           static int sp = -1;
                           static void push(int data)
                           {
                               if(sp>=stack.Length) return;
                               sp++;
                               stack[sp] = data;
                           }
                       
                           static int pop()
                           {
                               if(sp<=-1)return -1;
                               int tmp = stack[sp];
                               sp--;
                               return tmp;
                           }
                       
                           static int Peek()
                           {
                               return stack[sp];
                           }
    static void Main(string[] args)
    {
        string infix = "a+b*c-d";// dönüştürülecek ifade
        string postfix = "";//sonuç burada birikecek
        string op = "$+-/*()";//operatörler
        int[] once = { 0, 2,2,3,3,1,1};//operatörlerin öncelik sırası
        push('$');//stackte işlem bitimini belirtmek için kullanıdık
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
                push(infix[i]);
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
            int a = Peek();
            if (once[indis] > once[op.IndexOf((char)a)])
            {
                push(infix[i]);
            }
            else
            {
                while (once[indis]<=once[op.IndexOf((char)a)])
                {
                    postfix += (char)pop();
                }
                push(infix[i]);
            }
        }
        while (Peek()!=(byte)'$')
        {
            postfix+=(char)pop();
        }
       
    }
        
    }

   
