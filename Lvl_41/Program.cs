using System.Linq;

Console.WriteLine("Введите желаемое количество чисел:");
int num = Convert.ToInt32(Console.ReadLine());

int[] FindNums(int numOf)
{
    {
        int[] arr = new int[numOf];

        for (int i = 0; i <= numOf - 1; i++)
        {
            Console.Write($"Введите {i + 1} число: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        return arr;
    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        if (i == count - 1) Console.Write($"{arr[i]} ");
        else Console.Write($"{arr[i]}, ");
    }
}

int CountNum(int[] arr)
{
    int count = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

int[] array = FindNums(num);
PrintArray(array);
CountNum(array);
Console.Write($" --> {CountNum(array)}");