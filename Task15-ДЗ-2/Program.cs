// Задача 15: Напишите программу, которая принимает на 
// вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.Write("Введите номер дня недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <1 || number >7)
{
    Console.Write("Не является номером дня недели");
}
else if (number == 6 || number == 7)
{
    Console.Write("Выходной день");
}
else
{
    Console.Write("Будний день");
}
