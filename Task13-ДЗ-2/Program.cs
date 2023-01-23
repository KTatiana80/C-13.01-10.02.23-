// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}


Console.Write("Введите целое число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number < 100)
{
    Console.Write("Нет третьего числа");
    return;
}

int result = ThirdDigit(number);
Console.Write(result);