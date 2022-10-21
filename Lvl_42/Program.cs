// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите цифру:");
int num = Convert.ToInt32(Console.ReadLine());

void ToBin1 (int num)
{
    string bin = default;
    if (num > 0)
    {
        if (num % 2 == 1) bin += "1";
            else bin += "0";
        ToBin1(num / 2);
    }
    Console.Write(bin);
}

void ToBin2 (int num)
{
    if (num == 0) return;
    ToBin2(num / 2);
    Console.Write(num % 2);
}


ToBin1(num);
ToBin2(num);
