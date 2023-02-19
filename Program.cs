// Задача 10: Напишите программу, которая включает в себя трехзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// int num = new Random().Next(100,1000);
// Console.WriteLine(num); 
// int a = num %100/10;
// int b = num %10;
// Console.WriteLine(a);




// Задача 13: Напишите программу, которая выводит 
// треть цифру заданного числа или сообщает,
// что других цифр нет.
// 645 -> 5
// 78 -> других цифр нет
// 32679 -> 6 

// Console.Write("Введите число -");
// int num = int.Parse(Console.ReadLine()!);
// if(num <= 99)
// {
//   Console.WriteLine("Третий цифры нет");
// }
// if(num >= 100 && num <= 999)
// {
//   int num2 = num % 10;
//   Console.WriteLine(num2);
// }
// if(num >= 1000 && num < 10000)
// {
//   int num2 = num %100/10;
//   Console.WriteLine(num2);
// }
// if(num >= 10000 && num < 100000)
// {
// int num2 = num % 1000/100;
// Console.WriteLine(num2);
// }




//15Напишите программу, которая принимает 
//на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


// Console.WriteLine("Введите число 1.до.7");
// int number = int.Parse(Console.ReadLine()!);
// if (number == 1)
// {
//   System.Console.WriteLine("Понидельник нет");
// }
// if (number == 2)
// {
//   System.Console.WriteLine("Вторник нет");
// }
// if (number == 3)
// {
//   System.Console.WriteLine("Среда нет");
// }
// if (number == 4)
// {
//   System.Console.WriteLine("Четверг нет");
// }
// if (number == 5)
// {
//   System.Console.WriteLine("Пятница нет");
// }
// if (number == 6)
// {
//   System.Console.WriteLine("Субота нет ");
// }
// if (number == 7)
// {
//   System.Console.WriteLine("Воскресения");
// }
// if (number >= 7)
//   Console.WriteLine("(Выходной)");
