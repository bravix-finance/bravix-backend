using Bravix.Module.FinancialAnalysis.Services.FinancialReport.Accounting;
using Bravix.Module.FinancialAnalysis.Services.FinancialReport.Models;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport.Reports;

public abstract class FinancialReportContext<TReport> where TReport : IFinancialReportModel
{
    public IEnumerable<FinancialReportFunction> Functions => _functions.Values;
    
    protected readonly Dictionary<string, FinancialReportFunction> _functions = new ();

    protected FinancialReportContext(IAccountingDataProvider dataProvider)
    {
       
    }
}