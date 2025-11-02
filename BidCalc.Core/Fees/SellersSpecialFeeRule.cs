namespace BidCalc.Core;

public class SellersSpecialFeeRule : IFeeRule
{
    
    private const decimal CommonRate = 0.02m;
    private const decimal LuxuryRate = 0.04m;

    public string Name { get; } = "Seller special fee";

    public decimal Compute(decimal basePrice, VehicleType type)
    {
        return basePrice * (type == VehicleType.Luxury ? LuxuryRate : CommonRate);
    }
}