namespace TradingDataEngine.DataTypes;

public record CandleStructure(
    // Main Structuer Of Candle
    // Bullish: Close > Open
    bool Bull = false,
    // Bearish: Close < Open
    bool Bear = false,
    // Body: Close - Open
    double Body = 0,
    // Range: High - Low
    double Range = 0,
    // BodyRatio: Body / Range
    double BodyRatio = 0,
    // if(Bull): Close - High; if(Bear): Open - Low
    double UpperWick = 0,
    // if(Bear): Close - High; if(Bull): Open - Low
    double LowerWick = 0
);
