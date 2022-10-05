
/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Выберите задачу от 1 до 3:");
Console.WriteLine("1. Задача 10\n2. Задача 13\n3. Задача 15");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case 1:
        bool one = true;
        Console.WriteLine("Вы выбрали 10 задачу");
        Console.WriteLine("Условие: Напишите программу, которая принимает на вход трёхзначное число");
        Console.WriteLine("и на выходе показывает вторую цифру этого числа.");
        while (one)
        {
            try
            {
                Console.Write("Решение:\nВведите трехзначное число: ");
                int threeNum = Convert.ToInt32(Console.ReadLine());
                if (threeNum >= -999 && threeNum < -99 || threeNum > 99 && threeNum <= 999)
                {
                    threeNum = (threeNum % 100) / 10;
                    Console.WriteLine("Ответ: Вторая цифра числа: " + Math.Abs(threeNum));
                    one = false;
                }
                else Console.WriteLine("Вы ввели не трехзначное число");
            }
            catch
            {
                Console.WriteLine("Ошибка ввода, попробуйте еще раз: ");
            }
        }
        break;
    case 2:
        bool two = true;
        Console.WriteLine("Вы выбрали 13 задачу");
        Console.WriteLine("Условие: Напишите программу, которая выводит третью цифру заданного числа");
        Console.WriteLine("или сообщает, что третьей цифры нет.");
        while (two)
        {
            try
            {
                Console.Write("Решение:\nВведите число: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > 99 || num < -99)
                {
                    num = Math.Abs(num);
                    int digitCount = (int)Math.Log10(num) + 1;
                    num = num / (int)Math.Pow(10, digitCount - 3) % 10;
                    Console.WriteLine("Ответ: Третья цифра числа: " + num);
                    two = false;
                }
                else
                {
                    Console.WriteLine("Ответ: Третьей цифры нет");
                    two = false;
                }
            }
            catch
            {
                Console.WriteLine("Ошибка ввода, попробуйте еще раз: ");
            }
        }
        break;
    case 3:
        Console.WriteLine("Вы выбрали 15 задачу");
        Console.WriteLine("Условие: Напишите программу, которая принимает на вход цифру, обозначающую день недели,");
        Console.WriteLine("и проверяет, является ли этот день выходным.");
        bool three = true;
        while (three)
        {
            try
            {
                Console.Write("Решение:\nВведите число: ");
                int day = Convert.ToInt32(Console.ReadLine());
                if (day > 0 && day <= 5)
                {
                    Console.WriteLine("Ответ: Нет");
                    three = false;
                }
                else if (day == 6 || day == 7) {
                    Console.WriteLine("Ответ: Да(Ура!!! выходной!)");
                    three = false;
                }
                else Console.WriteLine("Число должно находиться в пределах от 1 до 7");
            }
            catch
            {
                Console.WriteLine("Ошибка ввода, попробуйте еще раз: ");
            }
        }
        break;
        default:
            Console.WriteLine("Такой задачи нет");
            break;
}