namespace TradingDataEngine.DataTypes;

public record MarketSymbol
(
    string Symbol,
    string Name,
    MarketType Market
);
