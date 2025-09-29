using Bravix.Module.FinancialAnalysis.Services.FinancialReport.Models;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport.Reports;

public interface IFinancialReportBuilder<TReport, TContext, TThresholds>
where TReport: IFinancialReportModel
where TContext: FinancialReportContext<TReport>
where TThresholds: IFinancialReportThresholds<TReport>
{
    TReport Build(TContext context, RecordStorage storage, TThresholds thresholds);
}