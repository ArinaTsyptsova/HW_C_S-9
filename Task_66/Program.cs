// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNaturalSum(int startNum, int endNum)
{
    if (startNum == endNum) return endNum;
    return startNum + GetNaturalSum(startNum + 1, endNum);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num1 = GetInput("Введите значение M: ");
int num2 = GetInput("Введите значение N: ");
Console.Write($"M = {num1}; N = {num2} -> {GetNaturalSum(num1, num2)}");