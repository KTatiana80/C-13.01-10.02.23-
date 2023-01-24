// Задача 19
// Напишите программу, которая принимает
// на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


bool IsPalindrome(int num)
{
        int firstDigit = num / 10000;
        int fifthDigit = num % 10;
        if (firstDigit != fifthDigit)
    {
        return false;
    }
        int secondDigit = (num / 1000) % 10;
        int fourthDigit = (num % 100) / 10;
        if (secondDigit != fourthDigit)
    {
        return false;
    }
        return true;
}

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    Console.Write("Введено не целое число");
    return;
}

if (number < 10000 || number > 99999)
{
    Console.Write("Было введено не 5-ти значное число");
    return;
}


if (IsPalindrome(number))
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}


