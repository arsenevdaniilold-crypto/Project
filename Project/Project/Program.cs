using System;
using System.Diagnostics;

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

        Console.WriteLine(" ");
        Console.WriteLine("Задание 11");

        int[,] num = new int[8, 5];
        Random ran = new Random();
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                num[i, j] = ran.Next(10, 100);
            }
        }
        Console.WriteLine("Двумерный массив 8 x 5 :");
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(num[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine(" ");

        Console.WriteLine("Задание 12");

        int rows = 7;
        int cols = 4;
        int[,] array = new int[rows, cols];
        Random random1 = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = random1.Next(-5, 6);
            }
        }

        Console.WriteLine("Двумерный массив 7x4:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j].ToString().PadLeft(3) + " ");
            }
            Console.WriteLine();
        }

        // Находим строку с наибольшим по модулю произведением элементов
        int maxRowIndex = 0;
        double maxProduct = 0;

        for (int i = 0; i < rows; i++)
        {
            double product = 1;
            for (int j = 0; j < cols; j++)
            {
                product *= Math.Abs(array[i, j]);
            }
            
            if (i == 0)
            {
                maxProduct = product;
                maxRowIndex = 0;
            }
            else if (product > maxProduct)
            {
                maxProduct = product;
                maxRowIndex = i;
            }
        }
        Console.WriteLine($"\n Индекс строки с наибольшим по модулю произведением: {maxRowIndex + 1}");
        Console.WriteLine($"Произведение модулей элементов этой строки: {maxProduct}");

        Console.WriteLine(" ");

        Console.WriteLine("Задание 13 в другом файле");

        Console.WriteLine("Задание 14");

        {
            int[][] arrays = new int[5][];

            for (int i = 0; i < arrays.Length; i++)
            {
                arrays[i] = new int[10];
                for (int j = 0; j < arrays[i].Length; j++)
                {
                    arrays[i][j] = GetRandomNumber1(1, 100);
                }
            }

            Console.WriteLine("5 массивов по 10 элементов каждый:");
            for (int i = 0; i < arrays.Length; i++)
            {
                PrintArray(arrays[i]);
            }
        }

        static int GetRandomNumber1(int a, int b)
        {
            Random random = new Random();
            // Небольшая задержка для разных seed'ов
            System.Threading.Thread.Sleep(10);
            return random.Next(a, b + 1);
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }



        Console.WriteLine(" ");
        Console.WriteLine("Задание 15");

        {
            int[] ar = { 1, 344, 251, 122, -22, 111, 901, 1007 };

            Console.WriteLine("Исходный массив:");
            PrintArray(ar);

            BubbleSort(ar);

            Console.WriteLine("Отсортированный массив (пузырь):");
            PrintArray(ar);
        }

        static void BubbleSort(int[] ar)
        {
            {
                int n = ar.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (ar[j] > ar[j + 1])
                        {
                            int temp = ar[j];
                            ar[j] = ar[j + 1];
                            ar[j + 1] = temp;
                        }
                    }
                }
            }

            static void PrintArray1(int[] ar)
            {
                Console.WriteLine(string.Join(" ", ar));
            }
        }

        Console.WriteLine(" ");
        Console.WriteLine("Задание 16");

        {
            Console.WriteLine("Анализируем фибоначи");
            Console.WriteLine("Ищет дохрена секунд ес че");
            Console.WriteLine("==============");
            
            int start = 30;
            int current = start;
            int step = 5;

            while (true)
            {
                Console.Write($"Проверяем F({current})... ");

                Stopwatch sw = Stopwatch.StartNew();
                long result1 = FibonacciRecursive(current);
                sw.Stop();

                double seconds = sw.Elapsed.TotalSeconds;
                Console.WriteLine($"{seconds:F3} сек");

                if (seconds > 60)
                {
                    Console.WriteLine($"\n Найден! F({current}) вычисляется {seconds:F2} сек (> 1 мин)");

                    // Уточняем точное значение
                    int precise = FindExactThreshold(current - step, current);
                    Console.WriteLine($"Точный порог: F({precise})");
                    break;
                }
                else if (seconds > 10)
                {
                    step = 1;
                    current += step;
                }
                else
                {
                    current += step;
                }

                if (current > 100)
                    break;
            }
        }

        static int FindExactThreshold(int start, int end)
        {
            for (int n = start; n <= end; n++)
            {
                Stopwatch sw = Stopwatch.StartNew();
                FibonacciRecursive(n);
                sw.Stop();

                if (sw.Elapsed.TotalSeconds > 60)
                {
                    return n;
                }
            }
            return end;
        }

        static long FibonacciRecursive(int n)
        {
            if (n <= 1) return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }


    }

}
