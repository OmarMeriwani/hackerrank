using System;

class MyClass
{
    private static int N = 0;
    private static long[] A;
    private static string[] Line1;
    static void Main(string[] args)
    {
            N = Convert.ToInt32(Console.ReadLine());
            A = new long[N];
            Line1 = Console.ReadLine().Split(' ');
            A = Array.ConvertAll(Line1, long.Parse);
            long OriginalProduct = Product(A);
            long MinNumber = GetMax(A);
            long X = 0;
            bool resultFound = false;
            while (resultFound == false )
            {
                long MinimumProduct = 0;
                for (int i = 0; i < N; i++)
                    A[i] = MinNumber;
                MinimumProduct = Product(A);
                if (MinimumProduct <= OriginalProduct)
                {
                    X = MinNumber + 1;
                    resultFound = true ;
                }
                else
                {
                    MinNumber = MinNumber - 1;
                }
            }
            Console.WriteLine(X);
            Console.ReadLine();
        
    }
    static long Product(long[] Numbers)
    {
        long P = 1;
        for (int i = 0; i < Numbers.Length; i++)
        { P = P * Numbers[i]; }
        return P;
    }
    static long GetMax(long[] Numbers)
    {
        long P = 0;
        for (int i = 0; i < N; i++)
        {
            if (Numbers[i] > P)
            { P = Numbers[i]; }
        }
        return P;
    }
}
