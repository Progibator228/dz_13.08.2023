// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

int num = new Random().Next(100,1000);
System.Console.WriteLine($"Было сгенерированно число {num}");
int digit1 = num / 100;
int digit2 = num % 100;
int digit3 = digit2 / 10;
int digit4 = digit2 % 10;
System.Console.WriteLine($"Вторая цифра в этом трехзначном числе {digit3}");