using Bravix.Module.FinancialAnalysis.Enums;
using ISO3166;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialStatement.Models;

public record FinancialStatementModel(
    Guid StatementId,
    Guid OrganizationId,
    Guid UserId,
    FinancialStatementType StatementType,
    Country Country,
    string FilePath,
    string FileName,
    DateTime UploadedAt
    );