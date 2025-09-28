using Bravix.Module.FinancialAnalysis.Services.FinancialStatement.Models;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialStatement;

public interface IFinancialStatementService
{
    Task<FinancialStatementModel> UploadFinancialStatement(FinancialStatementModel statement, CancellationToken token);
    
    Task<FinancialStatementModel> DownloadFinancialStatement(Guid statementId, CancellationToken token);
    
    Task<FinancialStatementModel[]> GetFinancialStatements(GetFinancialStatementsCommand command, CancellationToken token);
}