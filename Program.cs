using System;
using ExtensionMethods.Extensions;

namespace ExtensionMethods;

class Program
{
    public static void Main(string[] args)
    {
        DateTime dt = new DateTime(2024, 02, 20, 8, 10, 45);
        Console.WriteLine(dt.ElapsedTime());
    } 
}
