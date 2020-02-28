using System;
using print = System.Console;
namespace FirstCSharpPr
{
    class Program
    {
        static void Difference(int first_digit,int second_digit)
        {
            Console.WriteLine("Task:2");
            Console.WriteLine( "Разность чисел {1} и {2} равно {0}" , first_digit-second_digit, first_digit,second_digit );
        }
        static void AddRealDigits(double f_d,double s_d)
        {
            Console.WriteLine("Task:5");
            Console.WriteLine("Сумма вещественных чисел {1} и {2} -> {0}", f_d + s_d, f_d, s_d );
        }
        static void DiffernceRealDigits(double f_d, double s_d)
        {
            Console.WriteLine("Task:6");
            Console.WriteLine("Сумма вещественных чисел {1} и {2} -> {0}", f_d - s_d, f_d, s_d );
        }
        static void SqrtDifInt(int first_digit, int second_digit)
        {
            Console.WriteLine("Task:11");
            Console.WriteLine("квадрат разности двух целых чисел {1} и {2} -> {0}", Math.Pow(first_digit - second_digit,2), first_digit, second_digit);
        }

        static void SqrtDoubleСomposition(double first_digit, double second_digit)
        {
            Console.WriteLine("Task:16");
            Console.WriteLine("квадрат произведения двух вещественных чисел {1} и {2} -> {0}", Math.Pow(first_digit * second_digit,2), first_digit, second_digit);
        }
        static void IntСubeСomposition(int first_digit, int second_digit)
        {
            Console.WriteLine("Task:21");
            Console.WriteLine("куб произведения двух целых чисел {1} и {2} -> {0}", Math.Pow(first_digit * second_digit,3), first_digit, second_digit );
        }
        static void Main(string[] args)
        {
            //Var 5,tasks: 2  5  6   11   16   21   

            Random rand = new Random();
            Difference(rand.Next(0,100),rand.Next(0,100));
            AddRealDigits((rand.Next(0,100))/10.0, (rand.Next(0,100))/10.0);
            DiffernceRealDigits((rand.Next(0, 100)) / 10.0, (rand.Next(0, 100)) / 10.0);
            SqrtDifInt(rand.Next(0, 100), rand.Next(0, 100));
            SqrtDoubleСomposition((rand.Next(0, 100)) / 10.0, (rand.Next(0, 100)) / 10.0);
            IntСubeСomposition(rand.Next(0, 100), rand.Next(0, 100));
            Console.ReadKey();
        }
    }

}
