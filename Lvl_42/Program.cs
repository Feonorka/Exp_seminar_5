﻿// Задача 42: Напишите программу, которая будет преобразовывать
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

int[] ToBin3(int num)
{
    arr[0] = num;
    int pos = 1;
    if (arr[0] > 0)
    {
        arr[pos] = arr[0] % 2;
        Console.Write(arr[pos]);
        pos++;
        ToBin(arr[0] / 2);
    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    Console.WriteLine("Сгенерированный массив:");
    for (int i = 0; i < count; i++)
    {
        if (i == count - 1) Console.Write($"{arr[i]} ");
        else Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

ToBin1(num);
ToBin2(num);
ToBin3(num);