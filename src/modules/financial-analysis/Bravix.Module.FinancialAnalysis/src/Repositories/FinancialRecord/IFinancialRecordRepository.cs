using Bravix.Module.FinancialAnalysis.Repositories.FinancialRecord.Entities;

namespace Bravix.Module.FinancialAnalysis.Repositories.FinancialRecord;

public interface IFinancialRecordRepository
{
    Task<FinancialRecordEntity[]> UpsertFinancialRecords(FinancialRecordEntity[] records, CancellationToken token);
    
    Task<FinancialRecordEntity[]> GetFinancialRecords(GetFinancialRecordsQuery query, CancellationToken token);
}