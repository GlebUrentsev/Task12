using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha12
{
    class Program
    {
        public static Random rnd = new Random();
        public static int countV, countP;
        static void SortVstavka(int[] array) // сортировка методом вставки
        {
            for (int j = 1; j < array.Length; j++)
            {
                int k = array[j];
                int i = j - 1;
                while (i >= 0 && array[i] > k)
                {
                    array[i + 1] = array[i];
                    i--;
                    countV++;
                }
                array[i + 1] = k;
            }
        }

        static void CountSort(int[] array)// сортровка методом подсчета
        {
            int maxValue = array.Max<int>();
            int[] c = new int[maxValue];
            for (int i = 1; i < array.Length + 1; i++)
            {
                c[array[i - 1] - 1]++;
            }
            int j = 0;
            for (int i = 1; i < c.Length + 1; i++)
            {
                do
                {
                    if (c[i - 1] == 0) continue;
                    else
                    {
                        array[j] = i;
                        c[i - 1]--;
                        j++;
                        countP++;
                    }
                } while (c[i - 1] > 0);
            }

        }
        static void print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        static void print(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        static void makeRand(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 10);
            }
        }
        static void Main(string[] args)
        {
            #region 1 сортировка
            print("Сортирвока методом вставки");
            int[] array = { 4, 1, 5, 1, 1,0 };
            makeRand(array);
            print(array);
            SortVstavka(array);
            Console.WriteLine("");
            print(array);
            Console.WriteLine($"\nКоличество перестановок в 1-ой сортировке = {countV}");
            #endregion

            Console.WriteLine();

            // #region 2 сортировка
            print("Сортирвока методом вставки");
            int[] array2 = { 4, 1, 5, 5, 1,2 };
            makeRand(array);
            print(array2);
            CountSort(array2);
            Console.WriteLine("");
            print(array2);
            Console.WriteLine($"\nКоличество перестановок в 2-ой сортировке = {countP}");
            // #endregion
        }
    }
}
