namespace BidCalc.Core;

public class BidCalculator
{
    private readonly IReadOnlyList<IFeeRule> _rules;
    public BidCalculator(IEnumerable<IFeeRule> rules)
    {
        _rules = rules.ToList();
    }
    public BidSummary Calculate(decimal basePrice, VehicleType type)
    {
        var fees = _rules.Select(rule => new FeeLine(rule.Name, rule.Compute(basePrice, type))).ToList();
        var total = basePrice + fees.Sum(fee => fee.Amount);
        return new BidSummary(basePrice, type, fees, total);
    }
}