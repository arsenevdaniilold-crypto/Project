using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задание 1");
        for (int i = 2; i <= 100; i += 2)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine(" ");
        Console.WriteLine("Задание 2");

        Console.Write("A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("B: ");
        int b = int.Parse(Console.ReadLine());

        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                Console.Write("7");
            }
            Console.WriteLine();

        }
        Console.WriteLine(" ");
        Console.WriteLine("Задание 3");
        int r = 10;

        for (int i = 1; i <= r; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("3");
            }
            Console.WriteLine();
        }
        Console.WriteLine(" ");
        Console.WriteLine("Задание 4");

        Console.Write("Q: ");
        int q = int.Parse(Console.ReadLine());

        Console.Write("S: ");
        int s = int.Parse(Console.ReadLine());

        static int min(int a, int b)
        {
            return a < b ? a : b;
        }
        int k = min(q, s);

        Console.WriteLine(k);

        Console.WriteLine(" ");
        Console.WriteLine("Задание 5");

        Console.Write("Введите первое имя: ");
        string name1 = Console.ReadLine();

        Console.Write("Введите второе имя: ");
        string name2 = Console.ReadLine();

        if (name1 == name2)
        {
            Console.WriteLine("Имена идентичны");
        }
        else if (name1.Length == name2.Length)
        {
            Console.WriteLine("Длины имен равны");
        }

        Console.WriteLine(" ");
        Console.WriteLine("Задание 6");

        Console.Write("Q: ");
        int q1 = int.Parse(Console.ReadLine());

        Console.Write("S: ");
        int s1 = int.Parse(Console.ReadLine());

        Console.Write("B: ");
        int b1 = int.Parse(Console.ReadLine());

        Console.Write("C: ");
        int c1 = int.Parse(Console.ReadLine());

        static int Min(int a, int b)
        {
            return a < b ? a : b;
        }
        static int Min1(int a, int b, int c, int d)
        {
            int min1 = Min(a, b);
            int min2 = Min(c, d);
            return Min(min1, min2);
        }
        int result = Min1(q1, s1, b1, c1);
        Console.WriteLine(result);

        Console.WriteLine(" ");
        Console.WriteLine("Задание 7");

        Console.Write("X: ");
        int X = int.Parse(Console.ReadLine());
        Console.Write("Y: ");
        int Y = int.Parse(Console.ReadLine());
        if (X == 0 || Y == 0)
        {
            Console.WriteLine("No");
            return;
        }
        int chetvert = (X > 0) ? (Y > 0 ? 1 : 4) : (Y > 0 ? 2 : 3);
        Console.Write(chetvert);

        Console.WriteLine(" ");
        Console.WriteLine("Задание 8");

        int[] Chet = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Chet[i] = (i + 1) * 2;
        }
        Console.WriteLine(string.Join(" ", Chet));
        Console.WriteLine(string.Join("\n", Chet));

        Console.WriteLine(" ");
        Console.WriteLine("Задание 9");

        int[] NeChet = new int[50];
        for (int i = 0; i < 50; i++)
        {
            NeChet[i] = (i * 2) + 1;
        }
        Console.WriteLine(string.Join(" ", NeChet));
        Console.WriteLine(" ");
        for (int j = 50 - 1; j >= 0; j--)
        {
            Console.Write(NeChet[j] + " ");
        }

        Console.WriteLine(" ");

        Console.WriteLine("Задание 10");
        int[] numbers = new int[15];
        Random random = new Random();
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(0, 10);
            Console.Write(numbers[i] + " ");
            if (numbers[i] % 2 == 0)
            {
                count++;
            }
         
        }
        Console.WriteLine("\n" + count);
    }
}