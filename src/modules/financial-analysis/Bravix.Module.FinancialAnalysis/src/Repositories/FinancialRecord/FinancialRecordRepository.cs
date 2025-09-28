using Bravix.Module.FinancialAnalysis.Repositories.FinancialRecord.Entities;

namespace Bravix.Module.FinancialAnalysis.Repositories.FinancialRecord;

public class FinancialRecordRepository : IFinancialRecordRepository
{
    public Task<FinancialRecordEntity[]> UpsertFinancialRecords(FinancialRecordEntity[] records, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<FinancialRecordEntity[]> GetFinancialRecords(GetFinancialRecordsQuery query, CancellationToken token)
    {
        throw new NotImplementedException();
    }
}