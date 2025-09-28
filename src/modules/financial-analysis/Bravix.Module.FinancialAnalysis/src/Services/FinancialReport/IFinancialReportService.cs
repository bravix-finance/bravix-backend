using Bravix.Module.FinancialAnalysis.Services.FinancialReport.Models;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport;

public interface IFinancialReportService
{
    Task<FinancialReportModel> GetReport(GetFinancialReportCommand command, CancellationToken token);
}