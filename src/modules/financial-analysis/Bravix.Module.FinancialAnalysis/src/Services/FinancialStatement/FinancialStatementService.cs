using Bravix.Module.FinancialAnalysis.Services.FinancialStatement.Models;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialStatement;

public class FinancialStatementService : IFinancialStatementService
{
    public Task<FinancialStatementModel> UploadFinancialStatement(FinancialStatementModel statement, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<FinancialStatementModel> DownloadFinancialStatement(Guid statementId, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<FinancialStatementModel[]> GetFinancialStatements(GetFinancialStatementsCommand command, CancellationToken token)
    {
        throw new NotImplementedException();
    }
}