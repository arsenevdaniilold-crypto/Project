using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[20];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = GetRandomNumber(-100, 100); 
        }

        Console.WriteLine("Массив из 20 случайных чисел:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }

    static int GetRandomNumber(int a, int b)
    {
        Random random = new Random();
        return random.Next(a, b + 1);
    }

}
