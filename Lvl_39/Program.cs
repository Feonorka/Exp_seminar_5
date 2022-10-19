// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.WriteLine("Введите количество элементов массива:");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void FillArray(int[] col, int minN, int maxN)
{
    int lenght = col.Length;
    int index = 0;
    while (index < lenght)
    {
        col[index] = new Random().Next(minN, maxN);
        index++;
    }
}

void ReverseArray(int[] arr)
{
    int size = arr.Length;
    int index1 = 0;
    int index2 = size - 1;

    while (index1 < index2)
    {
        int onj = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = onj;

        index1++;
        index2--;
    }
}

void ReverseArray2(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size / 2; i++)
    {
        int obj = arr[i];
        arr[i] = arr[size - 1 - i];
        arr[size - 1 - i] = obj;
    }
}

FillArray(array, 10, 100);
PrintArray(array);
ReverseArray2(array);
PrintArray(array);
Array.Reverse(array);
PrintArray(array);