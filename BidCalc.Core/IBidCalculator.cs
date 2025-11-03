namespace BidCalc.Core;

public interface IBidCalculator
{
    BidSummary Calculate(decimal basePrice, VehicleType type);
}