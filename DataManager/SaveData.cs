using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TradingDataEngine.DataTypes;

namespace TradingDataEngine.DataManager;

public static partial class DataManager
{

    public static void SaveData(
        string[] header,
        List<object[]> rows,
        string path,
        string join,
        int printNum)
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

        foreach (string line in lines.Take(printNum))
        {
            Console.WriteLine(line);
        }
    }
}
