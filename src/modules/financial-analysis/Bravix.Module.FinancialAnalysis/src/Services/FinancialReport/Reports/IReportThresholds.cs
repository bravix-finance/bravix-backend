using Bravix.Module.FinancialAnalysis.Services.FinancialReport.Models;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport.Reports;

public interface IFinancialReportThresholds<TReport> where TReport : IFinancialReportModel
{
    
}

public record struct ReportThresholdItem(decimal Min = decimal.MinValue, decimal Max = decimal.MaxValue);