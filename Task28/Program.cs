// Напишите программу, 
// 1. которая  принимает на вход число N и 
// 2. выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

Console.WriteLine("Ввелите натуральное число: ");
int number =  Convert.ToInt32(Console.ReadLine());

if (number > 0) // если значение верно, что if > 0 выполняется
{
  int factNumber = FactNumber(number);
  Console.WriteLine($"Произведение чисел от 1 до {number} = {factNumber}");
}
else // или если значение не верно и if < 0 
{
  Console.WriteLine($"Введите натуральное число");
}


int FactNumber (int num)
{
  int fact = 1;
  for (int i = 1; i <= num; i++)
  {
    checked // проверка перепонения, когда программа выдает ошибку
    {
      fact *= i;
    }
  }
  return fact;
}