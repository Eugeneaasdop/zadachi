using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество покупок: ");
            int N = int.Parse(Console.ReadLine());
            List<string> listBuy = new List<string>(N);
            for (int i = 0; i < N; i++)
            {
                listBuy.Add(Console.ReadLine());
            }
            //сортировка по алфавиту
            listBuy.Sort();
            //вывод списка
            Console.WriteLine("От А до Я");
            PrintList(listBuy);
            listBuy.Reverse();
            Console.WriteLine("От Я до А");
            PrintList(listBuy);
            Console.ReadKey();
            //задача 2
            Console.WriteLine("Введите количество строк: ");
            int K = int.Parse(Console.ReadLine());
            List<string> listSentences = new List<string>(K);
            for (int i = 0; i < K; i++)
            {
                listSentences.Add(Console.ReadLine());
            }
            Console.WriteLine("Введите поисковое слово: ");
            string wordSearch = Console.ReadLine();
            Console.WriteLine("Результаты поиска: ");
            List<string> listFinded = listSentences.FindAll(p => p.Contains(wordSearch));
            if (listFinded.Count > 0)
                PrintList(listFinded);
            else
                Console.WriteLine("По вашему запросу ничего не нашлось");
            Console.ReadKey();
            //задача 3
            Console.WriteLine("Введите количество строк: ");
            int M = int.Parse(Console.ReadLine());
            List<string> listStrings = new List<string>(M);
            for (int i = 0; i < M; i++)
            {
                listStrings.Add(Console.ReadLine());
            }
            Console.WriteLine("Введите номер символа: ");
            int numberSimbol = int.Parse(Console.ReadLine());
            string abbreviature = "";
            foreach (string line in listStrings)
            {
                if (line.Length >= numberSimbol)
                    abbreviature += line[numberSimbol - 1];
                else
                    abbreviature += '_';
            }
            Console.WriteLine($"Полученное слово: {abbreviature}");
            Console.ReadKey();
            //задача 5
            Console.WriteLine("Введите количество клиентов банка: ");
            int N1 = int.Parse(Console.ReadLine());
            List<int> listClients = new List<int>(N1);
            for (int i = 0; i < N1; i++)
            {
                listClients.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Исходные вложения");
            PrintList(listClients);
            Console.WriteLine("Накопления через год");
            foreach (int l in listClients)
            {
                Console.WriteLine(l * 3);
            }
            Console.ReadKey();
            //Задача №4
            int L = int.Parse(Console.ReadLine());
            List<string> listMagazin = new List<string>(L);
            for (int i = 0; i < L; i++)
            {
                listMagazin.Add(Console.ReadLine());
            }
            Console.WriteLine("Количество строк");
            int kolvo = int.Parse(Console.ReadLine());
            List<string> Frazy = new List<string>();
            for (int i = 0; i < kolvo; i++)
            {
                Console.WriteLine("Введите номер фразы");
                int nomer = int.Parse(Console.ReadLine());
                nomer -= 1;
                Frazy.Add(listMagazin[nomer]);
            }
            PrintList(Frazy);
            Console.ReadKey();
        }
        private static void PrintList(List<string> list)
        {
            foreach (string buy in list)
            {
                Console.WriteLine(buy);
            }
        }
        private static void PrintList(List<int> list)
        {
            foreach (int buy in list)
            {
                Console.WriteLine(buy);
            }
        }
    }
}
