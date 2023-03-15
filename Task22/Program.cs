﻿// Напишите программу, которая
// 1.принимает на вход число (N) и 
// 2. выдаёт таблицу квадратов чисел от 1 до N.

//  5 -> 1, 4, 9, 16, 25.
//  2 -> 1,4

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0) // уточнее если число больше 0
{
  TableSquare(number);
}
else // показываем сообщение о невыполнение функии
{
  Console.WriteLine("Введено некорректное число");
}

void TableSquare(int num) //создание метода
{
  int i = 1; //указание типа
  while (i <= num) //- счётчик
  {
    Console.WriteLine($"{i, 4} -> {i * i, 4}");
     i++; //увелечение счётчик на единицу
  }
}