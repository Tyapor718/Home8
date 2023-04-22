//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"
void EvenNumber(int numFirst, int numSecond)
{
    if (numFirst % 2 != 0)
    {
        numFirst = numFirst + 1;
    }
    if (numSecond >= numFirst)
    {
        System.Console.WriteLine(numFirst);
        EvenNumber(numFirst + 2, numSecond);
    }

}
    EvenNumber(4, 8);