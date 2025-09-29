using Bravix.Module.FinancialAnalysis.Services.FinancialReport.Models;
using Bravix.Module.FinancialAnalysis.Services.FinancialReport.ReportContexts;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport.ReportBuilders;

public interface IFinancialReportBuilder<TReport, TContext>
where TReport: IFinancialReportModel
where TContext: FinancialReportContext<TReport>
{
    TReport Build(TContext context, RecordStorage storage);
}