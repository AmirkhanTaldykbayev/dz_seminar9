// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое неотрицатальное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе неотрицательное число: ");
int n = Convert.ToInt32(Console.ReadLine());

/// <summary>
/// Функция Аккермана
/// </summary>
/// <param name="m">Первое неотрицательное число</param>
/// <param name="n">Второе неотрицитальное число</param>
/// <returns>Результат вычисления</returns>
int GetAckermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m!=0)&&(n == 0)) return GetAckermann(m - 1, 1);
    else return GetAckermann(m - 1, GetAckermann(m, n - 1));
}

if (m < 0 || n < 0)
{
    Console.WriteLine("Одно или два из введенных чисел является отрицательным!");
}
else
{
    Console.WriteLine($"Результат вычисления: {GetAckermann(m, n)}");
}
