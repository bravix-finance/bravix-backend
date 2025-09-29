using Bravix.Module.FinancialAnalysis.Services.FinancialReport.Models;
using Bravix.Module.FinancialAnalysis.Services.FinancialReport.Reports.BalanceReport;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport;

public interface IFinancialReportService
{
    Task<BalanceReportModel> GetBalanceReport(GetFinancialReportCommand command, CancellationToken token);
}