using Bravix.Module.FinancialAnalysis.Services.FinancialRecord.Models;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport;

public class RecordStorage
{
    private readonly Dictionary<int, Dictionary<string, FinancialRecordModel>> _history;
    private readonly int _latestYear;

    public RecordStorage(IEnumerable<FinancialRecordModel> records)
    {
        _history = records
            .GroupBy(r => r.Year)
            .ToDictionary(
                g => g.Key,
                g => g.ToDictionary(x => x.Key)
            );

        _latestYear = _history.Keys.Max();
    }

    public Dictionary<string, FinancialRecordModel> this[int year] => _history[year];

    public IEnumerable<Dictionary<string, FinancialRecordModel>> History => _history.Values;

    public Dictionary<string, FinancialRecordModel> Latest => _history[_latestYear];
}