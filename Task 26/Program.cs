// Напишите программу, 
// 1. которая принимает на вход число и 
// 2. выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Ввелите натуральное число: ");
int number =  Convert.ToInt32(Console.ReadLine());

int digNumber = DigNumber(number);
Console.WriteLine($"В числе {number} -> {digNumber} цифр");

int DigNumber(int num)
{
  int dig = 0;
  while (num > 0) // если поставить num != 0, то будет работать и с отрицательными числами 
  {
    num = num / 10; // считает последнее число то есть 456, считает число 6 как одну цифру в числе 
    dig++; // то есть число переходит на одно деление то, есть 456 , перейдет к числу 5
  }
  return dig;
}