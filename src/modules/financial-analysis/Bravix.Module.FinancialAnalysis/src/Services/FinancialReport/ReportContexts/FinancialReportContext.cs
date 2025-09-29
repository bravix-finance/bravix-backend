using Bravix.Module.FinancialAnalysis.Services.FinancialReport.Models;
using Bravix.Module.FinancialAnalysis.Services.FinancialReport.RegionalAccounting;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport.ReportContexts;

public abstract class FinancialReportContext<TReport> where TReport : IFinancialReportModel
{
    public IEnumerable<FinancialReportFunction> Functions => _functions.Values;
    
    protected readonly Dictionary<string, FinancialReportFunction> _functions = new ();

    protected FinancialReportContext(IRegionalAccountingDataProvider dataProvider)
    {
       
    }
}