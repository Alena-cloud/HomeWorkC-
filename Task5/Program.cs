﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5, 782 -> 8, 918 -> 1

Console.WriteLine("Enter three-digit number: ");

int threeDigitNumber = Convert.ToInt32(Console.ReadLine())!;
string stringNumber = Convert.ToString(threeDigitNumber);

Console.WriteLine("Second digit of the three-digit number - > " + stringNumber[1]);