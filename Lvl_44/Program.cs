// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите цифру:");
int num = Convert.ToInt32(Console.ReadLine());

// void Fibonachi (int n)
// {
//     int num1 = 0;
//     int num2 = 1;
//     int num3 = default;
//     Console.Write($"N = {num} -> {num1} {num2}");
//     for (int i = 2; i < num; i++)
//     {
//         num3 = num1 + num2;
//         Console.Write($" {num3}");
//         num1 = num2;
//         num3 = num2;
//     }
// }

void Fibonacci(int num)
{
    int num1 = 0;
    int num2 = 1;
    int num3 = default;
    Console.Write($"N = {num} -> {num1} {num2}");
    for (int i = 2; i < num; i++)
    {
        num3 = num1 + num2;
        Console.Write($" {num3}");
        num1 = num2;
        num2 = num3;

    }
}

Fibonacci(num);