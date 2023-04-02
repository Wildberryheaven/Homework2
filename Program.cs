// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Clear();
// int SecondNum(int number) {
//     int SecNum = (number%100)/10;
//     return SecNum;
// }

// while(true) {
//     Console.Write("Введите любое трёхзначное целое положительное число: ");
//     int num = Convert.ToInt32(Console.ReadLine());

//     if(num <100 || num > 999) {
//         Console.WriteLine("Вы ввели неправильное число. Попробуйте ещё раз.");
//     } else {
//         Console.Write($"Вторая цифра трёхзначного числа = {SecondNum(num)}");
//         break;
//     }
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Clear();

// int FirdNum(int number) {
//     while(number > 999) {
//         number = number/10;
//     }
//     return number%10;
// }

// Console.Write("Введите любое положительное целое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if(a < 100 && a > -100) {
//     Console.WriteLine("Третьей цифры нет.");
// } else {
//     int firdNum = FirdNum(a);
//     if(firdNum < 0) firdNum = -firdNum;
//     Console.WriteLine($"Третья цифра числа {a} = {firdNum}");
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Clear();
// bool CheckDay(int number) {
//     if(number == 6 || number == 7) return true;
//     else return false;
// }
// while(true) {
//     Console.Write("Введите цифру, обозначающую день недели от 1 до 7: ");
//     int day = Convert.ToInt32(Console.ReadLine());
//     if(day < 1 || day >7) {
//         Console.WriteLine("Вы ввели неправильную цифру, попробуйте снова.");
//     } else {
//         Console.WriteLine(CheckDay(day));
//         break;
//     }
// }