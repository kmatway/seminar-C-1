﻿Console.WriteLine("Введите номер дня недели: = ");
int number = int.Parse(Console.ReadLine());

if(number == 3)
{
    Console.WriteLine("Среда");
}
if(number == 5)
{
    Console.WriteLine("Пятница");
}
if(number == 1)
{
    Console.WriteLine("Понедельник");
}
if(number == 2)
{
    Console.WriteLine("Вторник");
}
if(number == 4)
{
    Console.WriteLine("Четверг");
}
if(number == 6)
{
    Console.WriteLine("Суббота");
}
if(number == 7)
{
    Console.WriteLine("Воскресенье");
}
if(number > 7)
{
    Console.WriteLine("Дней недели всего семь");
}
