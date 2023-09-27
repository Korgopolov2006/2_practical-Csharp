// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class три_программы
{
    public static void Main()
    {
        meny();
    }

    public static void Randomnoe_chislo()
    {
        Random random = new Random(); //Генератор рандомного числа
        int randomnoe_chislo = random.Next(0, 100);
        while (true)
        {
            Console.Write("Введите число: ");
            int vvedennoe_chislo = Convert.ToInt32(Console.ReadLine());
            if (vvedennoe_chislo == randomnoe_chislo)
            {
                Console.WriteLine("Вы молодец , рандомное число было найдено <3!");
                Console.WriteLine();
                break;

            }
            else if (vvedennoe_chislo < randomnoe_chislo)
            {
                Console.WriteLine("Рандомное число больше, повторите попытку снова..");
            }
            else
            {
                Console.WriteLine("Рандомное число меньше, повторите попытку снова..");
            }
        }
    }  //Найти рандомное число до 100-а (В Дательном падеже)



    public static void Tabliza_ymnojenia() //таблица умножения
    {
        int[,] table = new int[10, 10];
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                table[i - 1, j - 1] = i * j;  //Заполнение таблицы умножения
            }
        }
        Console.WriteLine("Таблица умножения:");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(table[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public static void Vivod_Delitelei_Chisla() //найти делитель
    {
        Console.Write("Введите число: ");
        int delit_na_chelo = Convert.ToInt32(Console.ReadLine());
        List<int> divisors = new List<int>();
        for (int i = 1; i <= delit_na_chelo; i++)
        {
            if (delit_na_chelo % i == 0)
            {
                divisors.Add(i);
            }
        }
        Console.WriteLine("Числа , которые делят заданное число нацело , без остатка {0}: {1}", delit_na_chelo, string.Join(", ", divisors));
    }

    public static void meny()  //менюшка
    {
        while (true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Игра 'Угадай число'");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("0. Выход");
            Console.Write("Выберите программу (введите номер): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Randomnoe_chislo();
            }
            else if (choice == 2)
            {
                Tabliza_ymnojenia();
            }
            else if (choice == 3)
            {
                Vivod_Delitelei_Chisla();
            }
            else if (choice == 0)
            {
                break;

            }
            else
                Console.WriteLine("Неверный выбор, вы накосячили с выбором задачи . Введите предложенные задачи :(");
        }

    }
}