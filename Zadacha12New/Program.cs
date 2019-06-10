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
        public static int countP1=0, countP2=0, countS1=0,countS2=0;
        static void SortVstavka(int[] array) // сортировка методом вставки
        {
            countP1 = 0;
            countS1 = 0;
            for (int j = 1; j < array.Length; j++)
            {
                int k = array[j];
                int i = j - 1;
                while (i >= 0 && array[i] > k)
                {
                    array[i + 1] = array[i];
                    i--;
                    countP1++;
                    countS1++;
                }
                array[i + 1] = k;               
            }
        }

        static void CountSort(int[] array)// сортровка методом подсчета
        {
            countP2 = 0;
            countS2 = 0;
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
                        countP2++;
                    }
                    countS2++;
                } while (c[i - 1] > 0);
            }

        }
        static void print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
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
        static void printG(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            label_1:
            Console.WriteLine("Выберите сортировку\n1)Сортировка методом вставки\n2)Сортировка методом подсчёта");
            int whichSort = int.Parse(Console.ReadLine());
            switch (whichSort)
            {
                case 1:
                        #region 1 сортировка
                        print("Сортирвока методом вставки");
                        int[] array1 = { 1, 2, 3, 4, 5 };
                        int[] array2 = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
                        int[] array3 = new int[10];
                        makeRand(array3);
                        Console.WriteLine("Выберите массив\n1)Упорядоченный по возрастанию\n2) Упорядоченный по убыванию\n3)Не упорядоченный");
                        int doing = int.Parse(Console.ReadLine());
                        switch (doing)
                        {
                            case 1:
                                printG("Массив 1 - упорядоченный по возрастанию");
                                print(array1);
                                printG("Массив 1 после сортировки вставкой");
                                SortVstavka(array1);
                                print(array1);
                                Console.WriteLine($"\nКоличество перестановок в 1-ой сортировке = {countP1}");
                                Console.WriteLine($"\nКоличество пересылок в 1-ой сортировке = {countS1}");
                            goto label_1;

                            case 2:
                            printG("Массив 2 - упорядоченный по убыванию");
                            print(array2);
                            printG("Массив 2 после сортировки вставкой");
                            SortVstavka(array2);
                            print(array2);
                            Console.WriteLine($"\nКоличество перестановок в 1-ой сортировке = {countP1}");
                            Console.WriteLine($"\nКоличество пересылок в 1-ой сортировке = {countS1}");
                            goto label_1;

                            case 3:
                            printG("Массив 3 - не упорядоченный");
                            print(array3);
                            printG("Массив 3 после сортировки вставкой");
                            SortVstavka(array3);
                            print(array3);
                            Console.WriteLine($"\nКоличество перестановок в 1-ой сортировке = {countP1}");
                            Console.WriteLine($"\nКоличество пересылок в 1-ой сортировке = {countS1}");
                            goto label_1;
                        }
                    #endregion
                    break;

                case 2:
                    #region 2 сортировка
                    print("Сортирвока методом подсчёта");
                    int[] array4 = { 1, 2, 3, 4, 5 };
                    int[] array5 = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
                    int[] array6 = new int[10];
                    makeRand(array6);
                    Console.WriteLine("Выберите массив\n1)Упорядоченный по возрастанию\n2) Упорядоченный по убыванию\n3)Не упорядоченный");
                    int doing1 = int.Parse(Console.ReadLine());
                    switch (doing1)
                    {
                        case 1:
                            printG("Массив 1 - упорядоченный по возрастанию");
                            print(array4);
                            printG("Массив 1 после сортировки вставкой");
                            CountSort(array4);
                            print(array4);
                            Console.WriteLine($"\nКоличество перестановок в 1-ой сортировке = {countP2}");
                            Console.WriteLine($"\nКоличество пересылок в 1-ой сортировке = {countS2}");
                            goto label_1;

                        case 2:
                            printG("Массив 2 - упорядоченный по убыванию");
                            print(array5);
                            printG("Массив 2 после сортировки вставкой");
                            CountSort(array5);
                            print(array5);
                            Console.WriteLine($"\nКоличество перестановок в 1-ой сортировке = {countP2}");
                            Console.WriteLine($"\nКоличество пересылок в 1-ой сортировке = {countS2}");
                            goto label_1;

                        case 3:
                            printG("Массив 3 - не упорядоченный");
                            print(array6);
                            printG("Массив 3 после сортировки вставкой");
                            CountSort(array6);
                            print(array6);
                            Console.WriteLine($"\nКоличество перестановок в 1-ой сортировке = {countP2}");
                            Console.WriteLine($"\nКоличество пересылок в 1-ой сортировке = {countS2}");
                            goto label_1;
                    }
                    #endregion
                    break;
        }
        }
    }
}
