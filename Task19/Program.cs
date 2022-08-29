/* Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

bool Palindrom (int number)
{
    int ed = number % 10;
    int de = number / 10000;
    
    int dec = (number % 100) /10;
    int ced = (number / 1000) % 10;
    
    if (ed == de && dec == ced) return (true);
    else return (false);
}

Console.Clear();
Console.Write("Введите любое целое пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (Palindrom (num)) Console.Write($"Число {num} является палиндромом");
else Console.Write($"Число {num} НЕ является палиндромом");

