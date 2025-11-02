namespace BidCalc.Core;
public interface IFeeRule
{
    string Name { get; }
    decimal Compute(decimal basePrice, VehicleType type);
}