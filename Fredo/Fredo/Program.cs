using System;
class MyClass
{
    private static int N = 0;
    private static int A = 0;
    private static int[] Arr;
    private static int[] index;
    private static string[] Answers;
    private static int T;
    private static int AmmoGain = 3;
    private static int AmmoLose = 1;
    static void Main(string[] args)
    {
        string ReadT = Console.ReadLine();
        T = Convert.ToInt32(ReadT);
        index = new int[T];
        Answers = new string[T];
        for (int j = 0; j < T; j++)
        {
            string[] Line2 = Console.ReadLine().Split(' ');
            A = Int32.Parse(Line2[0]);
            N = Int32.Parse(Line2[1]);
            Arr = new int[N];
            string[] Line3 = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                index[j] = i + 1;
                Arr[i] = Int32.Parse( Line3[i]);
                A = HitAnObstacle(Arr[i], A);
                if (A == 0)
                {
                    break;
                }
            }
            if (A > 0)
            {
                Answers[j] = "Yes";
                index[j] = A;
            }
            else
            {
                Answers[j] = "No";
            }
        }
        for (int j = 0; j < T; j++)
        {
            Console.WriteLine(Answers[j] + " "  + index[j]);
        }
        Console.ReadLine();
    }
    private static int HitAnObstacle(int Hit, int NumOfAmmo)
    {
        if (Hit == 0)
        {
            NumOfAmmo = NumOfAmmo - AmmoLose;
        }
        else if (Hit == 1)
        {
            NumOfAmmo = NumOfAmmo + AmmoGain - AmmoLose;
        }
        return NumOfAmmo;
    }
    private void InitiateGame()
    {
        N = 0;
        A = 0;
        Arr = null;
        index = null;
        Answers = null;
        T = 0;
    }

}
