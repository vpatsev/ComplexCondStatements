using System.ComponentModel.Design;

string product = Console.ReadLine();
string day = Console.ReadLine();
double price = 0;
//if (product == "Banana" && day == "Weekday")
//{
//    price = 2.50;
//    Console.WriteLine($"{price:F2}");
//}
//else if (product == "Banana" && day == "Weekend")
//{
//    price = 2.70;
//    Console.WriteLine($"{price:F2}");
//}
//if (product == "Apple" && day == "Weekday")
//{
//    price = 1.30;
//    Console.WriteLine($"{price:F2}");
//}
//else if (product == "Apple" && day == "Weekend")
//{
//    price = 1.60;
//    Console.WriteLine($"{price:F2}");
//}
//if (product == "Kiwi" && day == "Weekday")
//{
//    price = 2.20;
//    Console.WriteLine($"{price:F2}");
//}
//else if (product == "Kiwi" && day == "Weekend")
//{
//    price = 3.00;
//    Console.WriteLine($"{price:F2}");
//}

if (product == "Banana")
{
    if (day == "Weekday")
    {
        price = 2.50;
       

    }else if(day == "Weekend")
    {
        price = 2.70;
    }
}
if (product == "Apple")
{
    if (day == "Weekday")
    {
        price = 1.30;


    }
    else if (day == "Weekend")
    {
        price = 1.60;
    }
}
if (product == "Kiwi")
{
    if (day == "Weekday")
    {
        price = 2.20;


    }
    else if (day == "Weekend")
    {
        price = 3.00;
    }
}
Console.WriteLine($"{price:F2}");
