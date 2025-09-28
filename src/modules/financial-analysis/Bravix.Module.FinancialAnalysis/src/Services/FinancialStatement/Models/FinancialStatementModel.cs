using Bravix.Module.FinancialAnalysis.Enums;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialStatement.Models;

public record FinancialStatementModel(
    Guid StatementId,
    Guid OrganizationId,
    Guid UserId,
    FinancialStatementType StatementType,
    string FilePath,
    string FileName,
    DateTime UploadedAt
    );