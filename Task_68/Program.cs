// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermanFunction(int number1, int number2)
{
    if (number1 == 0) return number2 + 1;
    else if (number2 == 0) return AckermanFunction(number1 - 1, 1);
    else return AckermanFunction(number1 - 1, AckermanFunction(number1, number2 - 1));
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num1 = GetInput("Введите значение m: ");
int num2 = GetInput("Введите значение n: ");
Console.Write($"m = {num1}; n = {num2} -> A(m,n) = {AckermanFunction(num1, num2)}");