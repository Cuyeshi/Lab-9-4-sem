using System;
using System.IO;
using System.Linq;
using System.Globalization;

namespace Lab_9
{
    class Program
    {
        static void Main()
        {
            File.ReadAllLines("C:\\Users\\Cuyeshi\\Documents\\ОТЧЁТЫ\\Лабораторные работы 2-ой курс (4 семестр)\\ООПиП\\№9 ООПиП\\Lab_9\\Example.txt")
                .Where(line => line.Split(' ').Any(word => DateTime.TryParse(word, out _)))
                .SelectMany(line => line.Split(' ').Where(word => DateTime.TryParse(word, out _)).Select(word => DateTime.Parse(word)))
                .OrderBy(date => date)
                .ToList()
                .ForEach(date => Console.WriteLine(date.ToString(CultureInfo.InvariantCulture)));
        }
    }
}
