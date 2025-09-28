namespace Bravix.Module.FinancialAnalysis.Services.FinancialRecord.Models;

public record GetFinancialRecordsCommand(
    Guid OrganizationId,
    string[] Keys
    );