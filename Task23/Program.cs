/*
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.

Пример:
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int Cube (int num)
{
    int CubeNum = num * num * num;
    return CubeNum;
}

Console.Clear();
Console.Write("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write($"{N} --> ");
for(int i = 1; i < N; i++)
{
    Console.Write($"{Cube(i)}, ");
}
Console.Write(Cube(N));

