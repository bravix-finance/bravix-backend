using Bravix.Module.FinancialAnalysis.Services.FinancialRecord.Models;
using NodaMoney;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport.Accounting;

public record struct FinancialMetric
{
    public FinancialMetric(
        string key)
    {
        Key = key;
        DependentKeys = [key];
        GetAmount = dict => dict[key].Amount;
    }

    public FinancialMetric(
        string key,
        string[] dependentKeys,
        Func<Dictionary<string, FinancialRecordModel>, Money> getAmountFunc)
    {
        Key = key;
        DependentKeys = dependentKeys;
        GetAmount = getAmountFunc;
    }

    public string Key { get; }
    public string[] DependentKeys { get; }
    public Func<Dictionary<string, FinancialRecordModel>, Money> GetAmount { get; }

    public static FinancialMetric operator +(FinancialMetric a, FinancialMetric b)
    {
        return new FinancialMetric(
            $"{a.Key}+{b.Key}",
            a.DependentKeys.Concat(b.DependentKeys).Distinct().ToArray(),
            dict => a.GetAmount(dict) + b.GetAmount(dict)
        );
    }

    public static FinancialMetric operator -(FinancialMetric a, FinancialMetric b)
    {
        return new FinancialMetric(
            $"{a.Key}-{b.Key}",
            a.DependentKeys.Concat(b.DependentKeys).Distinct().ToArray(),
            dict => a.GetAmount(dict) - b.GetAmount(dict)
        );
    }

    public static FinancialMetric operator /(FinancialMetric a, FinancialMetric b)
    {
        return new FinancialMetric(
            $"{a.Key}/{b.Key}",
            a.DependentKeys.Concat(b.DependentKeys).Distinct().ToArray(),
            dict => new Money(a.GetAmount(dict) / b.GetAmount(dict), Currency.NoCurrency)
        );
    }

    public static FinancialMetric operator /(FinancialMetric a, decimal b)
    {
        return new FinancialMetric(
            $"{a.Key}/{b}",
            a.DependentKeys.ToArray(),
            dict => a.GetAmount(dict) / b
        );
    }
    
    public static FinancialMetric operator /(decimal a, FinancialMetric b)
    {
        return new FinancialMetric(
            $"{a}/{b.Key}",
            b.DependentKeys.ToArray(),
            dict =>
            {
                var bAmount = b.GetAmount(dict);
                return new Money(a / bAmount.Amount, bAmount.Currency);
            });
    }

    public static FinancialMetric operator *(FinancialMetric a, decimal b)
    {
        return new FinancialMetric(
            $"{a.Key}*{b}",
            a.DependentKeys.ToArray(),
            dict => a.GetAmount(dict) * b
        );
    }

    public static FinancialMetric operator *(decimal a, FinancialMetric b)
    {
        return new FinancialMetric(
            $"{a}*{b.Key}",
            b.DependentKeys.ToArray(),
            dict => a * b.GetAmount(dict)
        );
    }
}

public static class FinancialMetricHelper
{
    public static FinancialMetric Monthly(this FinancialMetric metric)
    {
        return metric / 12;
    }
}