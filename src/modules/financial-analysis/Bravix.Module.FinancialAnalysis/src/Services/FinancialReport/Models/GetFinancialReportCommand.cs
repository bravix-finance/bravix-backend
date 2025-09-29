namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport.Models;

public record GetFinancialReportCommand(
    string CountryCode,
    Guid OrganizationId
    ) { }