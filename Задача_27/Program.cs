/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11*/
int Sum(int num)
{
    int sum = 0;
    
    for (int i = num; i > 0; i/=10)
        sum += i % 10;
  
    return sum;
}
Console.Clear();
Console.Write ("Введите число: ");
int х = int.Parse (Console.ReadLine ());
Console.WriteLine($"Сумма цифр в числе {х} равна {Sum(х)}");