using Bravix.Module.FinancialAnalysis.Repositories.FinancialStatement.Entities;

namespace Bravix.Module.FinancialAnalysis.Repositories.FinancialStatement;

public interface IFinancialStatementRepository
{
    Task<FinancialStatementEntity[]> GetFinancialStatements(GetFinancialStatementsQuery query, CancellationToken token);
    
    Task<FinancialStatementEntity[]> UpsertFinancialStatements(FinancialStatementEntity[] query, CancellationToken token);
    
    Task<FinancialStatementEntity[]> DeleteFinancialStatements(Guid[] statementIds, CancellationToken token);
}