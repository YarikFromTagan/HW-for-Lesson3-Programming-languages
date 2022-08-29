/* 
Напишите программу, которая принимает на вход
координаты двух точек и находит расстояние
между ними в 3D пространстве.

Пример:
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double LengthLine3D (
double x1, double y1, double z1,
double x2, double y2, double z2
)
{
    double Length3D = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
    return Length3D;
}

Console.Clear();
Console.WriteLine("Введите координаты точки А(x,y,z):");

Console.Write("A(x) = ");
double Ax = Convert.ToDouble(Console.ReadLine());

Console.Write("A(y) = ");
double Ay = Convert.ToDouble(Console.ReadLine());

Console.Write("A(z) = ");
double Az = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите координаты точки B(x,y,z):");

Console.Write("B(x) = ");
double Bx = Convert.ToDouble(Console.ReadLine());

Console.Write("B(y) = ");
double By = Convert.ToDouble(Console.ReadLine());

Console.Write("B(z) = ");
double Bz = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("****************************");
Console.WriteLine();

double Length = LengthLine3D(Ax, Ay, Az, Bx, By, Bz);
double RoundLength = Math.Round(Length, 2);
Console.WriteLine($"Длина отрезка А({Ax},{Ay},{Az}); В({Bx},{By},{Bz}) равна {RoundLength}");
Console.WriteLine();
