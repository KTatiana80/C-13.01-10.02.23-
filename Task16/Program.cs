// 16. Напишите программу, которая принимает на 
// вход два числа и проверяет, является ли одно 
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

bool Sgusre(int number1, int number2)
{
    return ((number1 * number1 == number2) || (number2 * number2 == number1));
}

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = Sgusre(number1, number2);

// if (result) Console.WriteLine("Да");
// else Console.WriteLine("нет");

// Либо так

// Console.WriteLine(result ? "Да" : "Нет");

// Либо так

string res = result ? "Да" : "Нет";

Console.WriteLine(res);