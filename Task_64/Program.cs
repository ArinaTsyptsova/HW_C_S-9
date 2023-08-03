// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


string GetNaturalNum(int number)
{
    if (number == 1) return number.ToString();
    return number + ", " + GetNaturalNum(number -1);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInput("Введите число: ");
Console.Write($"N = {num} -> {GetNaturalNum(num)}");