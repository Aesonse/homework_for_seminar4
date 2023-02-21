/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
Console.Clear();

void PrintArray(int[] mas)
{
    Console.Write($"[{String.Join(", ", mas)}]");
}
 
int[] Array(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(101);
    }
    return result;
}
int num = 8;
int[] array = Array(num);
PrintArray(array);
