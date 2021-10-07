using System;
using System.Text;

namespace Arrays1DConsole
{
    class Program
    {//14 Варіант
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            ushort n;
            ushort k = 0;
            double S=0;
            bool f,kf;
            do
            {
                Console.Write("Введіть кількість елементів масиву(ціле число): ");
                f = ushort.TryParse(Console.ReadLine(),out n);
                if (f == false) {
                    Console.WriteLine("Помилка! Введіть ще раз");
                }
                if (n == 0) {
                    n = 10;
                }
            } while (!f);
            Console.WriteLine(n);
            Console.WriteLine(" ");
            double[] arr = new double[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                double d = rnd.Next(-15, 19);
                double d2 = rnd.NextDouble();
                double d3 = d + d2;
                double dx = Math.Round(d3, 1);
                arr[i] = dx;
                Console.WriteLine(arr[i]);
            }
            for (int i = 0; i < n; i++) {
                if (arr[i] > 0) {
                    S = S + arr[i];
                }
            }
            Console.Write("Сума додатніх індексів = ");
            Console.WriteLine(S);
            Console.WriteLine("");
            //СОРТУВАННЯ
            do
            {
                Console.Write("Введіть кількість елементів які будуть сортуватись(не більше розміру масиву): ");
                kf = ushort.TryParse(Console.ReadLine(), out k);
                if (k > n) {
                    kf = false;
                }
                if (kf == false)
                {
                    Console.WriteLine("Помилка! Введіть ще раз");
                }
            } while (!kf);
            double temp;
            for (int i = 0; i < k; i++)
            {
                for (int j = i + 1; j <k; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("Вивід відсортованого масиву");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
