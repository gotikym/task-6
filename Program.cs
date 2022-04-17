using System;
    internal class Program
    {
        static void Main(string[] args)
        {
        var pictures = 52;
        var series = 3;
        var numberSeries = pictures / series;
        var overflow = pictures % series;
        Console.WriteLine($"Полностью заполненных рядов: {numberSeries}, картинок сверх меры: {overflow}");
        }
    }
