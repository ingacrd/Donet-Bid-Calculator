namespace BidCalc.Core;

public class AssociationFeeRule : IFeeRule
{
    public string Name { get; } = "Association fee";
    public decimal Compute(decimal basePrice, VehicleType type)
    {
        if (basePrice <= 500m) return 5m;
        if (basePrice <= 1000m) return 10m;
        if (basePrice <= 3000m) return 15m;
        return 20m;
    }
}