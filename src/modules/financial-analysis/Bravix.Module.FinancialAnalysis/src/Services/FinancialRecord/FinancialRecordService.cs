using Bravix.Module.FinancialAnalysis.Services.FinancialRecord.Models;
using Bravix.Module.FinancialAnalysis.Services.FinancialStatement.Models;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialRecord;

public class FinancialRecordService : IFinancialRecordService
{
    public Task<FinancialRecordModel[]> UpsertFinancialRecords(FinancialRecordModel[] records, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<FinancialRecordModel[]> GetFinancialRecords(GetFinancialRecordsCommand command, CancellationToken token)
    {
        throw new NotImplementedException();
    }
}