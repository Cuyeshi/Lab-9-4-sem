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
            File.ReadAllLines("path/to/your/file.txt")
                .Where(line => line.Split(' ').Any(word => DateTime.TryParse(word, out _)))
                .SelectMany(line => line.Split(' ').Where(word => DateTime.TryParse(word, out _)).Select(word => DateTime.Parse(word)))
                .OrderBy(date => date)
                .ToList()
                .ForEach(date => Console.WriteLine(date.ToString(CultureInfo.InvariantCulture)));
        }
    }
}
