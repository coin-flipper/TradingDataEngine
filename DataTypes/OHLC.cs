namespace TradingDataEngine.DataTypes;

public record OHLC
(
    DateTime Time,
    double Open,
    double High,
    double Low,
    double Close
);
