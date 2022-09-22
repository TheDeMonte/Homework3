// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Sqr (int arg)
{
    int i = 1;
    while (i <= arg)
    {
        Console.WriteLine ($"{i} {Math.Pow((i), 3)}");
        i++;
    }
}
Console.Write ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Sqr(number); 