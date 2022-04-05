using System;
class Switchcase
{
    static void Main()
    {

        Console.WriteLine("|---------------------------------|");
        Console.WriteLine("  Введіть порядковий номер місяця  ");
        Console.WriteLine("|---------------------------------|");

        string s = Console.ReadLine(); 

        switch (s)
        {
            case "1":
                Console.WriteLine("|------|");
                Console.WriteLine("|Січень|");
                Console.WriteLine("|------|");
                break;

            case "2":
                Console.WriteLine("|-----|");
                Console.WriteLine("|Лютий|");
                Console.WriteLine("|-----|");
                break;

            case "3":
                Console.WriteLine("|--------|");
                Console.WriteLine("|Березень|");
                Console.WriteLine("|--------|");
                break;

            case "4":
                Console.WriteLine("|-------|");
                Console.WriteLine("|Квітень|");
                Console.WriteLine("|-------|");
                break;

            case "5":
                Console.WriteLine("|-------|");
                Console.WriteLine("|Травень|");
                Console.WriteLine("|-------|");
                break;

            case "6":
                Console.WriteLine("|-------|");
                Console.WriteLine("|Червень|");
                Console.WriteLine("|-------|");
                break;

            case "7":
                Console.WriteLine("|------|");
                Console.WriteLine("|Липень|");
                Console.WriteLine("|------|");
                break;

            case "8":
                Console.WriteLine("|-------|");
                Console.WriteLine("|Серпень|");
                Console.WriteLine("|-------|");
                break;

            case "9":
                Console.WriteLine("|--------|");
                Console.WriteLine("|Вересень|");
                Console.WriteLine("|--------|");
                break;

            case "10":
                Console.WriteLine("|-------|");
                Console.WriteLine("|Жовтень|");
                Console.WriteLine("|-------|");
                break;

            case "11":
                Console.WriteLine("|--------|");
                Console.WriteLine("|Листопад|");
                Console.WriteLine("|--------|");
                break;

            case "12":
                Console.WriteLine("|-------|");
                Console.WriteLine("|Грудень|");
                Console.WriteLine("|-------|");
                break;

            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!!ERROR!!!");
                Console.ResetColor();
                break;
        }
    }
}


