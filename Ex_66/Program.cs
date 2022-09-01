/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SumNumbers(int a, int b, int sum = 0)
{
    sum += a;
    if (a == b) return sum;
    return SumNumbers(a + 1, b, sum);
}
Console.Write("Введите значение (m): ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение (n): ");
int n = int.Parse(Console.ReadLine());
Console.Write(SumNumbers(m, n));
