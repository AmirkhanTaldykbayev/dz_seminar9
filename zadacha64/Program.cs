// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

/// <summary>
/// Метод вывода натуральных чисел от N до 1
/// </summary>
/// <param name="N">Число, введенное из консоли</param>
/// <returns>Заполненная строка натуральных чисел от N до 1</returns>
string ShowIntNumbers(int N)
{
    if (N == 1) return N.ToString();
    return (N + ", " + ShowIntNumbers(N - 1));
}

if (N > 0)
{
    Console.WriteLine(ShowIntNumbers(N));
}
else
{
    Console.WriteLine("Введенное число не является натуральным!");
}