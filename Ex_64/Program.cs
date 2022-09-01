/* Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8"" */

int WriteNumber(int a, int b)
{
    Console.Write(a + " ");
    if (a == b) return b;
    return WriteNumber(a + 1, b);
}
Console.Write("Введите значение (m): ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение (n): ");
int n = int.Parse(Console.ReadLine());
Console.Write(WriteNumber(m, n));