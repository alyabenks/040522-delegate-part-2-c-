using System;
using ConsoleApp3;

delegate void Computing();
class Program
{
    static void Main(string[] args)
    {
        Work arr = new Work();
        Computing first = arr.Show;
        first();
        Computing second = arr.MaxValue;
        second();
        Computing third = arr.Arifm;
        third();
        Computing fourth = arr.Geom;
        fourth();
        Console.ReadKey();
    }
}