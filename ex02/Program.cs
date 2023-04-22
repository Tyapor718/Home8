//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
//M= 1; N = 15 -> 120
//M = 4; N = 8 -> 30
int ReadInt(string msg)
{
    System.Console.Write($"{msg} > ");
    return int.Parse(Console.ReadLine());
}
int SumMN(int m, int n)
{
    int sum = m;
    if (m < n)
    {
        sum += SumMN(m + 1, n);
    }
    return sum;
}
int numberM = ReadInt("Введите первое число");
int numberN = ReadInt("Введите второе число");
System.Console.WriteLine(SumMN(numberM, numberN));