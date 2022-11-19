using System;
    class Project
    {
    public static void Main(string[] args)
    {
        string a1 = Console.ReadLine();
        int a = Convert.ToInt32(a1);
        if (a % 2 == 0)
        {
            even(a);
        }
        else
        { 
            odd(a);
        }
        Console.ReadKey();
    }
        private static void even (int x)
        {
            for (int i = 0; i <= x; i++)
                Console.WriteLine(i);
        }
    private static void odd (int y)
    {
        int i;
        int sum = 0;
        int z = 1;
            for (i = 1; i <= y; i++)
        {        
            sum += i;
            z *= i;
        }
        Console.WriteLine(sum);
        Console.WriteLine(z);
    }
    }//برنامه ای بنویسید ک اگر زوج بود مجموع و حاصل ضرب عدد تا عدد و اگ زوج بود از صفر تا ان عدد را چاپ کند
