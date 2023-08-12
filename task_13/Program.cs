// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите  число от 100 до 1.000.000");
int num1 = Convert.ToInt32 ( Console.ReadLine () );
if ( num1 > 99 && num1 < 1000 )
    {
        int digit1 = num1 / 100;
        int digit2 = num1 % 100;
        int digit3 = digit2 / 10;
        int digit4 = digit2 % 10;
        System.Console.WriteLine($" Третья цифра слева это {digit4}");
    }
else if ( num1 > 1000 && num1 < 10000 )
    {
        int digit4 = num1 % 1000;
        int digit1 = digit4 % 100;
        int digit2 = digit1 / 10;
        System.Console.WriteLine($" Третья цифра слева это {digit2}");
    }
else if ( num1 > 10000 && num1 < 100000 )
    {
        int digit4 = num1 % 1000;
        int digit1 = digit4 / 100;
        System.Console.WriteLine($" Третья цифра слева это {digit1}");
    }
else if ( num1 > 100000 && num1 < 1000000 )
    {
        int digit1 = num1 / 1000;
        int digit4 = digit1 % 10;
        System.Console.WriteLine($" Третья цифра слева это {digit4}");
    }
else
    {
        System.Console.WriteLine("Введенное число меньше 100");
    }
