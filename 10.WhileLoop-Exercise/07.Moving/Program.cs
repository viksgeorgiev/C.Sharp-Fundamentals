﻿
int size = int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine());
string input = Console.ReadLine();

while (input != "Done")
{
    size -= int.Parse(input);
    if (size < 0)
    {
        Console.WriteLine($"No more free space! You need {Math.Abs(size)} Cubic meters more.");
        break;
    }
    input = Console.ReadLine();
}
if (input == "Done")
{
    Console.WriteLine($"{size} Cubic meters left.");
}