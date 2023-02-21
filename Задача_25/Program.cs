//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.Clear();
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int B = int.Parse(Console.ReadLine());
int Power(int num, int pow)
{
    int result = 1;
    for (int i = 0; i < pow; i++)
    {
        result *= num;
    }
    return result;
}
Console.WriteLine($"{A} в степени {B} равняется {Power(A,B)}");