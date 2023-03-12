// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());

/// <summary>
/// Метод нахождения суммы натуральных чисел в промежутке от M до N
/// </summary>
/// <param name="M">Первое число, введенное с консоли</param>
/// <param name="N">Второе число, введенное с консоли</param>
/// <returns>Результат вычисления</returns>
int GetSumOfIntNums(int start, int end)
{
    if (start == end) return start;
    return (start + GetSumOfIntNums(start + 1, end));
}

if (M > 0 && N > 0 && N > M)
{
    Console.WriteLine(GetSumOfIntNums(M, N));
}
else if(M > 0 && N > 0 && N < M) // Не было в условии задачи, но решил добавить это условие во избежания ошибки
{   
    int temp = N;
    N = M;
    M = temp;
    
    Console.WriteLine(GetSumOfIntNums(temp, N));
}
else
{
    Console.WriteLine("Одно или два из введенных чисел не является натуральным");
}