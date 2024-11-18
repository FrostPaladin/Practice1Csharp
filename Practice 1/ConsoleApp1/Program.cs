using System;
using System.Reflection;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int program = 1;
            while (program == 1)
            {
            Console.WriteLine("Выберите номер задания :");
            Console.WriteLine("1. Разработайте программу, которая принимает четыре числа и находит среднее значение между ними");
            Console.WriteLine("2. Разработайте программу-калькулятор, в которой можно выбрать действие для двух вводимых пользователем чисел");
            Console.WriteLine("3. Разработайте программу для конвертации температуры между градусами Цельсия, Кельвина, Фаренгейта");
            Console.WriteLine("4. Разработайте программу, которая позволяет определить имя файла (с расширением) по введенному пути");
            Console.WriteLine("5. Разработайте программу для нахождения самого длинного слова в предложении");
            Console.WriteLine("6. Разработайте программу, которая может перемножить два массива значений");
            Console.WriteLine("7. Разработайте программу, которая может найти максимальное и минимальное число из пяти введенных");
            Console.WriteLine("8. Разработайте программу, которая выводит “пирамиду” из чисел из количества уровней, введенных пользователем");
            Console.WriteLine("9. Часть 2. Напечатать полную таблицу умножения");
            Console.WriteLine("25. Часть 3. Разработайте программу “Шутки Кузьмы Ивановича”, которая выводит случайную шутку про null, undefined и []");
            Console.WriteLine("0 - Завершить программу");
            string window =Console.ReadLine();
                switch (window)
                {
                    case "1":
                        double n1, n2, n3, n4;
                        double average, result;
                        Console.Clear();
                        Console.WriteLine("1. Разработайте программу, которая принимает четыре числа и находит среднее значение между ними");
                        Console.WriteLine("Введите первое число:");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите третье число:");
                        n3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите четвертое число:");
                        n4 = Convert.ToDouble(Console.ReadLine());
                        average = (n1 + n2 + n3 + n4) / 4;
                        Console.WriteLine("Среднее значение чисел " + n1 + ", " + n2 + ", " + n3 + ", " + n4 + " равно: " + average);
                        Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Разработайте программу-калькулятор, в которой можно выбрать действие для двух вводимых пользователем чисел");
                        Console.WriteLine("Введите первое число:");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Выберите выполняемое действие: \n" +
                            "1. Сложение\n" +
                            "2. Вычитание\n" +
                            "3. Умножение\n" +
                            "4. Деление\n" +
                            "5. Нахождение остатка\n");
                        string choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "1":
                                result = n1 + n2;
                                Console.WriteLine("Результат " + n1 + " + " + n2 + " = " + result);
                                break;
                            case "2":
                                result = n1 - n2;
                                Console.WriteLine("Результат " + n1 + " - " + n2 + " = " + result);
                                break;
                            case "3":
                                result = n1 * n2;
                                Console.WriteLine("Результат " + n1 + " * " + n2 + " = " + result);
                                break;
                            case "4":
                                result = n1 / n2;
                                Console.WriteLine("Результат " + n1 + " / " + n2 + " = " + result);
                                break;
                            case "5":
                                result = n1 % n2;
                                Console.WriteLine("Результат " + n1 + " % " + n2 + " = " + result);
                                break;
                            default:
                                Console.WriteLine("Ошибка ввода");
                                break;
                        }
                        Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "3":
                        int inputsystem, countsystem;
                        Console.Clear();
                        Console.WriteLine("Выберите шкалу вводимой температуры: \n" +
                            "1. Цельсий\n" +
                            "2. Кельвин\n" +
                            "3. Фаренгейт\n");
                        inputsystem = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите показатель температуры(градусы): ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Выберите тип шкалы для конвертации: \n" +
                            "1. Цельсий\n" +
                            "2. Кельвин\n" +
                            "3. Фаренгейт\n");
                        countsystem = Convert.ToInt32(Console.ReadLine());
                        switch (inputsystem)
                        {
                            case 1:
                                switch (countsystem)
                                {
                                    case 1:
                                        Console.WriteLine("Вы зачем-то переводите Цельсий в Цельсий???");
                                        Console.WriteLine("Результат конвертации: " + n1);
                                        break;
                                    case 2:
                                        Console.WriteLine("Вы выбрали: Цельсий -> Кельвин");
                                        result = n1 + 273.15;
                                        Console.WriteLine("Результат конвертации: " + result);
                                        break;
                                    case 3:
                                        Console.WriteLine("Вы выбрали: Цельсий -> Фаренгейт");
                                        result = (n1 * 9 / 5) + 32;
                                        Console.WriteLine("Результат конвертации: " + result);
                                        break;
                                    default:
                                        Console.WriteLine("Ошибка ввода");
                                        break;
                                }
                                break;
                            case 2:
                                switch (countsystem)
                                {
                                    case 1:
                                        Console.WriteLine("Вы выбрали: Кельвин в Цельсий");
                                        result = n1 - 273.15;
                                        Console.WriteLine("Результат конвертации: " + result);
                                        break;
                                    case 2:
                                        Console.WriteLine("Вы выбрали: Кельвин -> Кельвин");
                                        Console.WriteLine("Результат конвертации: " + n1);
                                        break;
                                    case 3:
                                        Console.WriteLine("Вы выбрали: Кельвин -> Фаренгейт");
                                        result = (n1 - 273.15) * 9 / 5 + 32;
                                        Console.WriteLine("Результат конвертации: " + result);
                                        break;
                                    default:
                                        Console.WriteLine("Ошибка ввода");
                                        break;
                                }
                                break;
                            case 3:
                                switch (countsystem)
                                {
                                    case 1:
                                        Console.WriteLine("Вы выбрали: Фаренгейт в Цельсий");
                                        result = (n1 - 32) * 5 / 9;
                                        Console.WriteLine("Результат конвертации: " + result);
                                        break;
                                    case 2:
                                        Console.WriteLine("Вы выбрали: Фаренгейт -> Кельвин");
                                        result = (n1 - 32) * 5 / 9 + 273.15;
                                        Console.WriteLine("Результат конвертации: " + result);
                                        break;
                                    case 3:
                                        Console.WriteLine("Вы выбрали: Фаренгейт -> Фаренгейт");
                                        Console.WriteLine("Результат конвертации: " + n1);
                                        break;
                                    default:
                                        Console.WriteLine("Ошибка ввода");
                                        break;
                                }
                                break;
                            default:
                                Console.WriteLine("Ошибка ввода");
                                break;
                        }
                        Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Разработайте программу, которая позволяет определить имя файла (с расширением) по введенному пути");
                        Console.WriteLine("Введите путь до файла: ");
                        string input = Console.ReadLine();
                        string[] subs = input.Split('\\');
                        int a = subs.Length;
                        Console.WriteLine(subs[a - 1]);
                        Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Разработайте программу для нахождения самого длинного слова в предложении");
                        Console.Write("Введите строку: ");
                        input = Console.ReadLine();
                        string[] str = input.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' });
                        int maxlen = 0;
                        int index = 0;
                        for (int i = 0; i < str.Length; i++)
                        {
                            if (str[i].Length > maxlen)
                            {
                                maxlen = str[i].Length;
                                index = i;
                            }
                        }
                        Console.Write("Самое длинное слово: " + str[index] + "\n");
                        Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Разработайте программу, которая может перемножить два массива значений");
                        Console.WriteLine("Введите значения для первого массива через пробел:");
                        string arr = Console.ReadLine();
                        string[] array1 = arr.Split(' ');
                        Console.WriteLine("Введите значения для второго массива через пробел:");
                        arr = Console.ReadLine();
                        string[] array2 = arr.Split(' ');
                        for (int i = 0; i < array1.Length; i++)
                        {
                            Console.Write($"{Convert.ToInt32(array1[i]) * Convert.ToInt32(array2[i])} \n");
                        }
                        Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "7":
                        Console.Clear();
                        Console.Write("Разработайте программу, которая может найти максимальное и минимальное число из пяти введенных");
                        Console.WriteLine("Введите пять чисел:");
                        double min, max;
                        n1 = Convert.ToDouble(Console.ReadLine());
                        min = n1;
                        max = n1;
                        n2 = Convert.ToDouble(Console.ReadLine());
                        if (n2 < min) min = n2;
                        if (n2 > max) max = n2;
                        n3 = Convert.ToDouble(Console.ReadLine());
                        if (n3 < min) min = n3;
                        if (n3 > max) max = n3;
                        n4 = Convert.ToDouble(Console.ReadLine());
                        if (n4 < min) min = n4;
                        if (n4 > max) max = n4;
                        double n5 = Convert.ToDouble(Console.ReadLine());
                        if (n5 < min) min = n5;
                        if (n5 > max) max = n5;
                        Console.WriteLine("Минимальное число: " + min + ", максимальное: " + max);
                        Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "8":
                        Console.Clear();
                        Console.WriteLine("Разработайте программу, которая выводит “пирамиду” из чисел из количества уровней, введенных пользователем");
                        Console.Write(" Введите уровень пирамиды : ");
                        int levels = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= levels; i++)
                        {
                            for (int j = 0; j < levels - i; j++)
                            {
                                Console.Write(" ");
                            }

                            for (int k = 1; k <= i; k++)
                            {
                                Console.Write(k + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "9":
                        Console.Clear();
                        Console.WriteLine("Часть 2 - Напечатать полную таблицу умножения");
                        Console.Write("Задача 9. Напечатать полную таблицу умножения в виде\n");
                        for (int i = 1; i <= 9; i++)
                        {
                            for (int j = 1; j <= 9; j++)
                            {
                                Console.Write($"{1} x {j} = {i * j}\t");
                            }

                            Console.WriteLine();
                        }
                        Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "25":
                        Console.Clear();
                        List<string> jokes = new List<string>(10);
                        jokes.Add("Боюсь идти на собеседование. А вдруг возьмут, придется undefined");
                        jokes.Add("Девиз программистов: Ошибок нет, то и хорошо!");
                        jokes.Add("Почему null и undefined не могут стать друзьями?  \r\n   Потому что null всегда говорит: \"У меня нет значения\", а undefined отвечает: \"Я даже не знаю, кто я!\"");
                        jokes.Add("Почему undefined никогда не выигрывает в играх?  \r\n   Потому что он всегда играл \"в незнании\"!");
                        jokes.Add("Как null заставил всю программу нервничать?  \r\n   Он просто пришел и сказал: \"Я не существую!\"");
                        jokes.Add(" Почему null всегда в депрессии?\r\n   Потому что он не может найти свое значение!");
                        jokes.Add("Почему null не смог найти себе работу?\r\n   Потому что у него не было ни одного подтвержденного значения.");
                        jokes.Add("Какой самый оптимистичный тип данных?\r\n   Новый массив: []. Он всегда верит, что в его жизни будет больше элементов!");
                        jokes.Add("Что говорит строка, когда встречает массив?\r\n   \"Привет, я string, а ты кто?\"\r\n   Массив отвечает: \"Я просто [], но у меня есть много друзей!\"");
                        jokes.Add("undefined и null зашли в бар. Бармен спрашивает: \"Что будете пить?\"\r\n   - undefined отвечает: \"Не знаю.\" А null говорит: \"Я ничто!\".");

                        Console.WriteLine("Вариант 25 - Разработайте программу “Шутки Кузьмы Ивановича”, которая выводит случайную шутку про null, undefined и []");
                        int joker = 1;
                        int lol;
                        Random rnd = new Random();
                        Console.WriteLine("Шутка от Кузьмы Ивановича: ");
                        lol = rnd.Next(0, jokes.Count);
                        Console.WriteLine(jokes[lol]);
                        while (joker == 1)
                        {
                            Console.WriteLine("Хотите генерировать еще одну шутку?");
                            input = Console.ReadLine();
                            if (input == "Да" || input == "ДА" || input == "да")
                            {
                                lol = rnd.Next(0, jokes.Count);
                                Console.WriteLine(jokes[lol]);
                            }
                            else if (input == "Нет" || input == "НЕТ" || input == "нет")
                                joker = 0;
                            else
                                Console.WriteLine("Ошибка ввода");
                        }
                        Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "0":
                        Console.Clear();
                        Console.WriteLine("Завершение программы");
                        program = 0;
                        break;
                    default:
                        Console.WriteLine("Ошибка ввода");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}