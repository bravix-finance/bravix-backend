using Bravix.Module.FinancialAnalysis.Services.FinancialReport.Models;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport;

public interface IFinancialReportService
{
    Task<BalanceReportModel> GetBalanceReport(GetFinancialReportCommand command, CancellationToken token);
}