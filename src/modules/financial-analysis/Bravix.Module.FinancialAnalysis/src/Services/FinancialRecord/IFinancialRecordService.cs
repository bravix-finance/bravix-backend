using Bravix.Module.FinancialAnalysis.Services.FinancialRecord.Models;
using Bravix.Module.FinancialAnalysis.Services.FinancialStatement.Models;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialRecord;

public interface IFinancialRecordService
{
    Task<FinancialRecordModel[]> UpsertFinancialRecords(FinancialRecordModel[] records, CancellationToken token);
    
    Task<FinancialStatementModel[]> GetFinancialRecords(GetFinancialRecordsCommand command, CancellationToken token);
}