// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]
// 6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]

// int [] arr = {1, 2, 5, 7, 19, 2, 4, 9};

// void PrintArray (int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine($"{array[i]}");
//     }
//     Console.WriteLine();
// }
// PrintArray(arr);

int[] arr = CreateArray();
PrintArray(arr);

int[] CreateArray()
{
    int [] array = new int[8];
    int index = 0;
    while (index < 8)
    {
        array[index] = new Random().Next(0,100);
        index++;
    }
    return array;
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

