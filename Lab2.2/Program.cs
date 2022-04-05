using System;
class Type2
{

    public static void Main()
    {
        double a = - Math.PI;
        double b = Math.PI;
        double dx = Math.PI / 10 ;
        while (true)
        {

            Console.Write("Виберіть дію: \n" +
                    "1 - Обчисліть за допомогою циклу з передумовою \n" +
                    "2 - Обчисліть за допомогою циклу з післяумовою \n" +
                    "3 - Вийти з програми \n" +
                    "Ваш вибір: ");
            int str = int.Parse(Console.ReadLine());
            double x, y = 0;
            if (str == 1)
            {//Цикл з передумовою
                x = a;
                Console.Write("|  x      |   y=f(x)  |\n");
                while (x <= b)
                {
                    Console.Write("|{0:F3}    |    {1,5:F2}  |\n", x, y);
                    x += dx;
                    y = Math.Cos(x) * Math.Sin(x);
                }
            }
            if (str == 2)
            {//Цикл з післяумовою
                x = a;
                Console.Write("|  x      |   y=f(x)  |\n");
                do
                {
                    Console.Write("|{0:F3}    |    {0,5:F2}  |\n", x, y);
                    x += dx;
                    y = Math.Cos(x) * Math.Sin(x);
                } while (x <= b);
            }
            if (str == 3)
            {
                break;
            }
            else
                if (str < 1 || str > 3)
                continue;
        }
    }
}

