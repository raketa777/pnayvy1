using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2;


namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {

            MyString p = new MyString();
            MyString Stroka1 = new MyString();
            MyString Stroka2 = new MyString("qwer");
            MyString Stroka3 = new MyString("tyuiop");
            char Simvol = 'q';
            string test;
            int lenght;
            int numOfSpaces;
            int numOfDigits;
            
            Console.WriteLine("Тест");
            test = Console.ReadLine();

            lenght = p.Lenght(test);
            numOfSpaces = p.NumberOfSpaces(test);
            numOfDigits = p.NumberOfDigits(test);

            Console.WriteLine("Длина строки: \"{0}\" составляет: {1} символов\nКол-во пробелов в строке:{2}", test, lenght, numOfSpaces);

            Stroka1 = "123456789"; // Преобразование типов "string" -> "MyString".
            string str;
            str = Stroka1; // Преобразование типов "MyString" -> "string".

            Console.WriteLine(Stroka1);
            Console.WriteLine(Stroka2);
            Console.WriteLine(Stroka3);
            Console.WriteLine(Stroka2.FindSymbol(Simvol));
            Console.WriteLine(p.Replace(Stroka2, 'q', 'P'));

            Console.WriteLine("/////////////////////\n/////////////////////\n// ПЕРЕГРУЗКИ.\n");
            Console.WriteLine(p.Substring(Stroka1, 3));
            Console.WriteLine(p.Substring(Stroka1, 3, 6));

            Console.ReadLine();
        }
    }
}
