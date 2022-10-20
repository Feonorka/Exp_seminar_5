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

int[] CopyArr(int[] arr)
{
    int[] arrCopy = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arrCopy[i] = arr[i];
    }
    return arrCopy;
}

PrintArray(array);
FillArray(array, 10, 99);
PrintArray(array);
int[] arr2 = CopyArr(array);
PrintArray(arr2);