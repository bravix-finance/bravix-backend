using Bravix.Module.FinancialAnalysis.Services.FinancialRecord;
using Bravix.Module.FinancialAnalysis.Services.FinancialReport.Models;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport;

public class FinancialReportService : IFinancialReportService
{
    private readonly IFinancialRecordService _financialRecordService;

    public FinancialReportService(IFinancialRecordService financialRecordService)
    {
        _financialRecordService = financialRecordService;
    }

    public Task<FinancialReportModel> GetReport(GetFinancialReportCommand command, CancellationToken token)
    {
        //For MVP we rely on Netherlands accounting codes, we will change this later to use normalized keys
        var stocks = new FinancialMetric("3100") +
                     new FinancialMetric("3150");
        
        var cashAndShortTermInvestments = new FinancialMetric("1010") + 
                                          new FinancialMetric("1020");
        
        var shortTermReceivables = new FinancialMetric("1580") +
                                   new FinancialMetric("1586") +
                                   new FinancialMetric("1589");

        var currentAssets =
            stocks +
            cashAndShortTermInvestments +
            shortTermReceivables;

        var currentLiabilities =
            new FinancialMetric("1700") +
            new FinancialMetric("1701") +
            new FinancialMetric("1987") +
            new FinancialMetric("1988") +
            new FinancialMetric("1989") +
            new FinancialMetric("1990");
        
        var shortTermLiabilities =
            new FinancialMetric("1700") +
            new FinancialMetric("1701") +
            new FinancialMetric("1987") +
            new FinancialMetric("1988") +
            new FinancialMetric("1989") +
            new FinancialMetric("1990");
        
        var currentLiquidityRatio = currentAssets / currentLiabilities;
        var quickRatio = (shortTermLiabilities + cashAndShortTermInvestments)/currentLiabilities;
        var absoluteLiquidityRation = cashAndShortTermInvestments / shortTermLiabilities;

        var costOfSales =
            new FinancialMetric("7110") +
            new FinancialMetric("7120") +
            new FinancialMetric("7125") +
            new FinancialMetric("7130") +
            new FinancialMetric("7340") +
            new FinancialMetric("7341") +
            new FinancialMetric("7342") +
            new FinancialMetric("7343") +
            new FinancialMetric("7350") +
            new FinancialMetric("7360") +
            new FinancialMetric("7395") -
            new FinancialMetric("7390");

        var inventoryCost =
            new FinancialMetric("3100") +
            new FinancialMetric("3150");
        
        throw new NotImplementedException();
    }

    
}