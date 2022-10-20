// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите длину первой стороны:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину третьей стороны:");
int num3 = Convert.ToInt32(Console.ReadLine());

bool Triangle(int a, int b, int c)
{
    bool res = false;
    if ((a + b < c) || (a + c < b) || (c + b < a)) res = false;
    return res;
}

if (Triangle(num1, num2, num3)) Console.Write("Треугольник с такими сторонами может существовать");
else Console.Write("Треугольник с такими сторонами не может существовать");