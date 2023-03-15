// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки A");
Console.Write("Xa: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Ya: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("Xb: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Yb: ");
int yB= Convert.ToInt32(Console.ReadLine());

double Leng = Distance (xA, yA, xB, yB);
Console.WriteLine($"Расстояние между точками A и B равно = {Math.Round(Leng, 2, MidpointRounding.ToZero)}");

double Distance (int x1, int y1, int x2, int y2)
{
  return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));  //- теорема пифагора
}