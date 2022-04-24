using System;
internal class Program
{
    static void Main(string[] args)
    {
        byte pictures = 52;
        byte rowLength = 3;
        int filledRows = pictures / rowLength;
        int overflowPictures = pictures % rowLength;
        Console.WriteLine($"Полностью заполненных рядов: {filledRows}, картинок сверх меры: {overflowPictures}");
    }
}
