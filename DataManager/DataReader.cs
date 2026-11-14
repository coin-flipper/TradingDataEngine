using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TradingDataEngine.DataTypes;

namespace TradingDataEngine.DataManager;

public static partial class DataManager
{
    public static List<OHLC> OpenDataOHLC(string path, string split)
    {
        // Read the file
        List<string> file = File.ReadAllLines(path).ToList();
        // put the file data on the record
        List<OHLC> candles = file.Select(line =>
        {
            // Split the data and put it in array
            string[] row = line.Split(split);
            // return the data in the record Candle
            return new OHLC(
                DateTime.Parse(row[0]),
                double.Parse(row[1]), // make candles.Open
                double.Parse(row[2]), // make candles.High
                double.Parse(row[3]), // make candles.Low
                double.Parse(row[4])  // make candles.Close
            );
        }).ToList();
        return candles;
    }
}
