using Bravix.Module.FinancialAnalysis.Enums;
using NodaMoney;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialRecord.Models;

public record FinancialRecordModel(
    Guid OrganizationId,
    Guid? StatementId,
    string Key,
    int Year,
    PeriodType PeriodType,
    Money Amount,
    DateTimeOffset CreatedAt,
    DateTimeOffset UpdatedAt
);