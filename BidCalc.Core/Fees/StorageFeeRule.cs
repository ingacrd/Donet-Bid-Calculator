namespace BidCalc.Core;

public class StorageFeeRule : IFeeRule
{
    public string Name { get; } = "Storage fee";
    public decimal Compute(decimal basePrice, VehicleType type)
    {
        return 100m;
    }
}