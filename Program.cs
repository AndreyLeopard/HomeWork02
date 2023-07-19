int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task10()

{
    /* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    456 -> 5
    782 -> 8
    918 -> 1 */

    int num = Input("Введите число: ");
    if (num >= 100 && num < 1000) Console.WriteLine($"Вторая цифра числа: {num / 10 % 10}");
    else Console.WriteLine("Число не трехзначное");
}

void Task13()
{
    /* Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    645 -> 5
    78 -> третьей цифры нет
    326743297 -> 6*/

    int num = Input("Введите число: ");
    num = Math.Abs(num);
    if(num > 99)
    {
        while (num > 999)
        {
            num /= 10;
        }
        Console.WriteLine($"Третья цифра числа: {num % 10}");
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}


void Task15()
{    /* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
    6 -> да
    7 -> да
    1 -> нет */
    int day = Input("Введите номер недели: ");

    if (day >= 1 && day <= 5)
    {
        Console.WriteLine("Будни");
    }
    else if (day == 6|| day == 7)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
    }

}
Console.Clear();
Task15();