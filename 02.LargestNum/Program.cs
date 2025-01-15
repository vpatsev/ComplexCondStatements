using System.Runtime.Serialization;

int a = int.Parse(Console.ReadLine()); 
int b = int.Parse(Console.ReadLine()); 
int c = int.Parse(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine(a);
    }
}
 if (b > a)
{
    if (b > c) { Console.WriteLine(b); }
}
 if (c > a)
{
    if (c > b) { Console.WriteLine(c); };
};

