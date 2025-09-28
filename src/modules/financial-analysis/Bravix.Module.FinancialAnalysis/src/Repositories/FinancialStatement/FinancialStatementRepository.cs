using Bravix.Module.FinancialAnalysis.Repositories.FinancialStatement.Entities;

namespace Bravix.Module.FinancialAnalysis.Repositories.FinancialStatement;

public class FinancialStatementRepository : IFinancialStatementRepository
{
    public Task<FinancialStatementEntity[]> GetFinancialStatements(GetFinancialStatementsQuery query, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<FinancialStatementEntity[]> UpsertFinancialStatements(FinancialStatementEntity[] query, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<FinancialStatementEntity[]> DeleteFinancialStatements(Guid[] statementIds, CancellationToken token)
    {
        throw new NotImplementedException();
    }
}