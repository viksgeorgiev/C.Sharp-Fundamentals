﻿//  1.Брой страници в текущата книга – цяло число в интервала [1…1000]
//  2.Страници, които прочита за 1 час – цяло число в интервала [1…1000]
//  3.Броят на дните, за които трябва да прочете книгата – цяло число в интервала [1…1000]

//Input

int pagesInBook = int.Parse(Console.ReadLine());
int pagesPerHour  = int.Parse(Console.ReadLine());
int daysToRead = int.Parse(Console.ReadLine());

//Calculations

int hoursPerDay = (pagesInBook / pagesPerHour) / daysToRead;

//Output

Console.WriteLine(hoursPerDay);