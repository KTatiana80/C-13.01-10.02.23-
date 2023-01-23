// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit(int num)
{
    return num / 10 % 10;
}

// int number, result;
Console.Write("Введите трехзначное число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));  // *Math.Abs* абсолютное значение (число всегда положительное)

if (number < 100 || number > 999)
{
    Console.Write("Было введено не 3-х значное число");
    return;
}

int result = SecondDigit(number);
Console.Write(result);
