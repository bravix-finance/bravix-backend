using Bravix.Module.FinancialAnalysis.Services.FinancialRecord.Models;
using NodaMoney;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport.Models;

internal record struct FinancialMetric
{
    internal record Context
    {
        private readonly Dictionary<int, Dictionary<string, FinancialRecordModel>> _allRecords;
        private readonly int _latestYear; 
        
        public Context(IEnumerable<FinancialRecordModel> records)
        {
            _allRecords = records
                .GroupBy(x => x.Year)
                .ToDictionary(
                    x => x.Key, 
                    i => i.ToDictionary(x => x.Key)
                    );
            
            _latestYear = _allRecords.Keys.Max();
        }
        
        public IEnumerable<Dictionary<string, FinancialRecordModel>> Records => _allRecords.Values;
        
        public Dictionary<string, FinancialRecordModel> Latest => _allRecords[_latestYear];
    }
    
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