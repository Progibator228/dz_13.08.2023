// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите первое число   ");
int num1 = Convert.ToInt32 ( Console.ReadLine () );
if (num1 == 6  || num1  == 7)
    Console.WriteLine("Выходной чилим");
else 
    Console.WriteLine("СЕГОДНЯ РАБОТАЕМ");