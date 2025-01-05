namespace recursive;

class Program
{
    public static int fact(int sayi)
    {
        if (sayi == 1) return 1;
        else
        {
            return sayi * fact(sayi - 1);

        }
    }

    public static int basamaktoplam(int num)
    {
        if (num < 10) return num;
        else
        {
            return num % 10 + basamaktoplam(num / 10);
        }
        
    }

    public static int fibonacci(int n)
    {
        if(n == 0) return 0;
        if (n == 1) return 1;
        return fibonacci(n - 1) + fibonacci(n - 2);
    }
    static void Main(string[] args)
    {
        Console.WriteLine( fact(5));
        Console.WriteLine(basamaktoplam(999));
        Console.WriteLine(fibonacci(9));
    }
}