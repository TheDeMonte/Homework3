// // Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrome (int num)
{
    int a = num / 10000;
    int b = (num / 1000) % 10;
    int B = (num % 100) / 10;
    int A = num % 10;
    if (num >= 100000 || num < 10000) Console.WriteLine ("Введено неверное значение");
    else if (a == A && b == B)
    {
        Console.Write ($"Число {num} является палиндромом"); 
    }
    else
    {
        Console.Write ($"Число {num} не является палиндромом");
    }
}
Console.WriteLine ("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrome(number);
