// Напишите программу, которая задаёт массив из 8 элементов и выводит их
//  на экран.
// 1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]
// 6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]

int[] array = new int[8];
Console.WriteLine("Print an array:");
FillArray(array);
WriteArray(array);
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = new Random().Next(0, 999);
    }
}
void WriteArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

