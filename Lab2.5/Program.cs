using System;
using System.Threading;

class Apps
{
    static void NullRows(int[,] myArray)
    {
        for (int y = 0; y < myArray.GetLength(0); y++)
        {
            for (int x = 0; x < myArray.GetLength(1); x++)
            {
                if (myArray[y, x] == 0)
                {
                    Console.WriteLine($"\n Рядок з нульовим елементом:{y}");
                    for (int i = 0; i != myArray.GetLength(1); i++)
                        Console.Write(myArray[y, i] + " ");
                }
            }
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("(1)Генератор випадкових чисел"+"\n(2)Самостійний ввід чисел");
        string str = Console.ReadLine();
        int n, m;
        while (true)
        {
            Console.Clear();
            Console.Write("Розмір массива NxM:");
            string tmp = Console.ReadLine();
            string[] splitter = tmp.Split();
            try
            {
                n = int.Parse(splitter[0]); m = int.Parse(splitter[1]);
                break;

            }
            catch
            {
                Console.WriteLine("Невірний формат!");
                Thread.Sleep(500);

            }
        }
        int[,] myArray = new int[n, m];

        if (str == "1")
        {
            Random random = new Random();

            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    myArray[y, x] = random.Next(-100, 100);
                }
            }

            Console.WriteLine("\n\t Result: ");
            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write(myArray[y, x] + "\t");
                }
                Console.WriteLine();
            }
            NullRows(myArray);
        }




        else
        {
            try
            {
                for (int y = 0; y < myArray.GetLength(0); y++)
                {
                    for (int x = 0; x < myArray.GetLength(1); x++)
                    {
                        Console.WriteLine("Y: " + y + " X: " + x);
                        myArray[y, x] = int.Parse(Console.ReadLine());
                    }
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Введено не допустиме значення, спробуйте ще раз.");
            }
            Console.WriteLine("\n\t Result: ");
            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write(myArray[y, x] + "\t");
                }
                Console.WriteLine();
            }
            NullRows(myArray);
        }
    }
}