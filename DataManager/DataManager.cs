using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DataTypes;


class DataManager
{
    public static void PrintData(IEnumerable<Candle> lines)
    {
        foreach (Candle line in lines)
        {
            Console.WriteLine(line);
        }
    }

    public static void PrintPatterns(
        IEnumerable<DataTypes.CandlePatterns> patterns)
    {
        foreach (var pattern in patterns)
        {
            Console.WriteLine(pattern);
        }
    }

    public static List<Candle> OpenDataOHLC(string path, string split)
    {
        // Read the file
        List<string> file = File.ReadAllLines(path).ToList();
        // put the file data on the record
        List<Candle> candles = file.Select(line =>
        {
            // Split the data and put it in array
            string[] row = line.Split(split);
            // return the data in the record Candle
            return new Candle(
                DateTime.Parse(row[0]),
                double.Parse(row[1]), // make candles.Open
                double.Parse(row[2]), // make candles.High
                double.Parse(row[3]), // make candles.Low
                double.Parse(row[4])  // make candles.Close
            );
        }).ToList();
        return candles;
    }

    public static void SaveData(string[] header, List<object[]> rows, string path, string join)
    {
        string[] h = header;
        var joinH = string.Join(join, h);

        List<string> lines = new List<string>();
        lines.Add(joinH);
        foreach (object[] row in rows)
        {
            lines.Add(string.Join(join, row));
        }

        File.WriteAllLines(path, lines);
        Console.WriteLine($"Data Has Add Succesfully.");
        Console.WriteLine("this is the first 4 row:");
        Head(lines, 4);
    }
    public static void Head(List<string> lines, int n = 4)
    {
        foreach (string line in lines.Take(n))
            Console.WriteLine(line);
    }
}
