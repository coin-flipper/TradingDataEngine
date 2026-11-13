namespace TradingDataEngine.DataTypes;

public record TradingSpecifications
(
    decimal TickSize,
    decimal? PipSize,
    decimal ContractSize,
    int Digits
);
