﻿string type = Console.ReadLine();   
int rows =  int.Parse(Console.ReadLine());
int seats = int.Parse(Console.ReadLine());
double price = 0;
double totalPrice = 0;
if (type == "Premiere")
{
    price = 12.00;

} 
else if (type == "Normal")
{
    price = 7.50;
} else if (type == "Discount")
{
    price = 5.00;
}

totalPrice = price * seats * rows;

Console.WriteLine($"{totalPrice:F2}");