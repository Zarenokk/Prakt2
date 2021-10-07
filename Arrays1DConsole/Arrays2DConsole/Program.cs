using System;
using System.Text;

namespace Arrays2DConsole
{
    class Program
    {//8 Варіант
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            ushort n;//рядки матриці
            ushort m;//стовпці матриці
            bool fn,fm;
            //ввід кількості рядків
            do
            {
                Console.Write("Введіть кількість рядків матриці(ціле число): ");
                fn = ushort.TryParse(Console.ReadLine(), out n);
                if (fn == false)
                {
                    Console.WriteLine("Помилка! Введіть ще раз");
                }
                if (n == 0)
                {
                    n = 4;
                }
            } while (!fn);
            //ввід кількості стовпців
            do
            {
                Console.Write("Введіть кількість стовпців матриці(ціле число): ");
                fm = ushort.TryParse(Console.ReadLine(), out m);
                if (fm == false)
                {
                    Console.WriteLine("Помилка! Введіть ще раз");
                }
                if (n == 0)
                {
                    n = 4;
                }
            } while (!fm);
            double[,] matr = new double[n, m];
            //заповнення матриці рандомними числами від[-33.531; 33.110]
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++) {
                    double d = rnd.Next(-34,34);
                    double d2 = rnd.NextDouble();
                    double d3 = d + d2;
                    double dx = Math.Round(d3, 3);
                    matr[i,j] = dx;
                }
            }
            //Виведення матриці
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matr[i, j]);
                    Console.Write(" | ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Виведення суми модулів кожного рядка:");
            //Виведення суми модулів кожного рядка
            double[] arrS = new double[n];
            double Suma = 0;
            double naySuma = 0;
            int nomerR = 0;
            for (int i = 0; i < n; i++)
            {
                Suma = 0;
                for (int j = 0; j < m; j++)
                {
                    Suma=Suma+Math.Abs(matr[i, j]);
                }
                arrS[i] = Suma;
                Console.WriteLine(Suma);
                Console.WriteLine(" ");
            }
            //Виведення найбільшої суми модулів рядка
            Console.WriteLine("Виведення найбільшої суми модулів рядка:");
            for (int i = 0; i < n; i++) {
                if (naySuma < arrS[i]) {
                    naySuma = arrS[i];
                    nomerR = i;
                }
            }
            Console.WriteLine($"{++nomerR} номер рядка,значення = {naySuma}");
        }
    }
}
