namespace stacködev;

class Program
{
    static void Main(string[] args)
    {
        // ödev: iki boyutlu bir dizi hayal edelim 50 50 olsun içersinde 0 ve 1 lerden oluşan bir yapı olsun
        int[,] arrr= new int[50,50];
        for (int i = 0; i < 50; i++)
        {
            for (int j = 0; j < 50; j++)
            {
                if (i==0&j==0&arrr[i, j] == 1)
                {
                   
                }
            }
        }
    }
    static int[] stack = new int[100];
    static int sp=-1;

    static void push(int data)
    {
        sp++;
        stack[sp] = data;
    }

    static int pop()
    {
        int tmp=stack[sp];
        sp--;
        return tmp;
    }
}