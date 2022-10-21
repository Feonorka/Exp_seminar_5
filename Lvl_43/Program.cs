
Console.WriteLine($"Введите координаты первой точки: ");
double b1 = Convert.ToDouble(Console.ReadLine());
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Введите координаты второй точки: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());

double XPoint(double b1, double k1, double b2, double k2)
{
    double y = default;
    double x = default;
    x = (b2 - b1) / (k1 - k2);
    return x;
}

double YPoint(double b1, double k1, double b2, double k2)
{
    double y = default;
    double x = default;
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    return y;
}

double x = Math.Round(XPoint(b1, k1, b2, k2), 2);
double y = Math.Round(YPoint(b1, k1, b2, k2), 2);

Console.WriteLine($"b1 = {b1}, k1 ={k1}, b2 = {b2}, k2 = {k2} --> ({x},{y})");