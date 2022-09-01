/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29 */

int Recursion(int n, int m)
{
    if (n == 0) return m + 1;
    else if (n != 0 && m == 0) return Recursion(n - 1, 1);
    else return Recursion(n - 1, Recursion(n, m - 1));
}
Console.Write("Введите значение (m): ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение (n): ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(Recursion(n, m));

