using Bravix.Module.FinancialAnalysis.Services.FinancialReport.Models;
using Bravix.Module.FinancialAnalysis.Services.FinancialReport.RegionalAccounting;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport.ReportContexts;

public class BalanceReportContext : FinancialReportContext<BalanceReportModel>
{
    public FinancialReportFunction CurrentLiquidityRatio
    {
        get => _functions[nameof(CurrentLiquidityRatio)];
        private init => _functions[nameof(CurrentLiquidityRatio)] = value;
    }
    public FinancialReportFunction QuickRatio 
    {
        get => _functions[nameof(QuickRatio)];
        private init => _functions[nameof(QuickRatio)] = value;
    }
    public FinancialReportFunction AbsoluteLiquidityRatio 
    {
        get => _functions[nameof(AbsoluteLiquidityRatio)];
        private init => _functions[nameof(AbsoluteLiquidityRatio)] = value;
    }
    public FinancialReportFunction InventoryTurnoverRatio 
    {
        get => _functions[nameof(InventoryTurnoverRatio)];
        private init => _functions[nameof(InventoryTurnoverRatio)] = value;
    }
    public FinancialReportFunction ReceivablesTurnoverRatio 
    {
        get => _functions[nameof(ReceivablesTurnoverRatio)];
        private init => _functions[nameof(ReceivablesTurnoverRatio)] = value;
    }
    public FinancialReportFunction AssetTurnover 
    {
        get => _functions[nameof(AssetTurnover)];
        private init => _functions[nameof(AssetTurnover)] = value;
    }
    public FinancialReportFunction Dso 
    {
        get => _functions[nameof(Dso)];
        private init => _functions[nameof(Dso)] = value;
    }
    public FinancialReportFunction NetProfitMargin 
    {
        get => _functions[nameof(NetProfitMargin)];
        private init => _functions[nameof(NetProfitMargin)] = value;
    }
    public FinancialReportFunction Roa 
    {
        get => _functions[nameof(CurrentLiquidityRatio)];
        private init => _functions[nameof(CurrentLiquidityRatio)] = value;
    }
    public FinancialReportFunction Roe 
    {
        get => _functions[nameof(Roe)];
        private init => _functions[nameof(Roe)] = value;
    }
    public FinancialReportFunction EquityRatio 
    {
        get => _functions[nameof(EquityRatio)];
        private init => _functions[nameof(EquityRatio)] = value;
    }
    public FinancialReportFunction Dti 
    {
        get => _functions[nameof(Dti)];
        private init => _functions[nameof(Dti)] = value;
    }
    public FinancialReportFunction Dscr 
    {
        get => _functions[nameof(Dscr)];
        private init => _functions[nameof(Dscr)] = value;
    }
    public FinancialReportFunction Roi 
    {
        get => _functions[nameof(Roi)];
        private init => _functions[nameof(Roi)] = value;
    }
    public FinancialReportFunction WorkingCapital 
    {
        get => _functions[nameof(WorkingCapital)];
        private init => _functions[nameof(WorkingCapital)] = value;
    }
    public FinancialReportFunction EfficiencyRatio 
    {
        get => _functions[nameof(EfficiencyRatio)];
        private init => _functions[nameof(EfficiencyRatio)] = value;
    }
    public FinancialReportFunction DebtToEbitda 
    {
        get => _functions[nameof(DebtToEbitda)];
        private init => _functions[nameof(DebtToEbitda)] = value;
    }
    public FinancialReportFunction DebtServiceCoverageRatio 
    {
        get => _functions[nameof(DebtServiceCoverageRatio)];
        private init => _functions[nameof(DebtServiceCoverageRatio)] = value;
    }

    public BalanceReportContext(IRegionalAccountingDataProvider dataProvider) : base(dataProvider)
    {
         var currentLiquidityRatioFunc = dataProvider.CurrentAssets / dataProvider.CurrentLiabilities;
        CurrentLiquidityRatio = currentLiquidityRatioFunc.Current();

        var quickRatioFunc =
            (dataProvider.CurrentAssets - dataProvider.Stocks) / 
            dataProvider.CurrentLiabilities;

        QuickRatio = quickRatioFunc.Current();

        var absoluteLiquidityRatioFunc = 
            (dataProvider.Cash + dataProvider.ShortTermFinancialInvestments) /
            dataProvider.ShortTermLiabilities;

        AbsoluteLiquidityRatio = absoluteLiquidityRatioFunc.Current();

        InventoryTurnoverRatio = 
            dataProvider.CostOfSales.Current() / dataProvider.InventoryCost.Avg();

        ReceivablesTurnoverRatio = 
            dataProvider.NetSales.Current() / dataProvider.AccountsReceivable.Avg();

        AssetTurnover = 
            dataProvider.Revenue.Current() / dataProvider.Assets.Avg();

        Dso = 365 / ReceivablesTurnoverRatio;

        NetProfitMargin =
            dataProvider.NetProfit.Current() / dataProvider.Revenue.Current() * 100;

        Roa = 
            dataProvider.NetProfit.Current() / dataProvider.Assets.Avg() * 100;

        Roe = 
            dataProvider.NetProfit.Current() / dataProvider.Equity.Avg() * 100;

        var equityRatioFunc = dataProvider.Equity / dataProvider.TotalCapital * 100;
        EquityRatio = equityRatioFunc.Current();
        
        var dtiFunc = dataProvider.TotalLiabilities / dataProvider.TotalCapital * 100;
        Dti = dtiFunc.Current();
        
        var dscrFunc = dataProvider.TotalIncome.Monthly() / dataProvider.DeptPayments.Monthly() * 100;
        Dscr = dscrFunc.Current();
        
        var roiFunc = (dataProvider.ProfitFromInvestment - dataProvider.InvestmentCosts) / dataProvider.InvestmentCosts * 100;
        Roi = roiFunc.Current();
        
        var workingCapitalFunc = dataProvider.CurrentAssets - dataProvider.CurrentLiabilities;
        WorkingCapital = workingCapitalFunc.Current();

        var efficiencyRatioFunc = dataProvider.NetSales / workingCapitalFunc;
        EfficiencyRatio = efficiencyRatioFunc.Current();
        
        var debtToEbitdaFunc = dataProvider.GeneralDept / dataProvider.EBITDA;
        DebtToEbitda = debtToEbitdaFunc.Current();

        var debtServiceCoverageRatioFunc = dataProvider.EBIT / dataProvider.DeptService;
        DebtServiceCoverageRatio = debtServiceCoverageRatioFunc.Current();
    }
}