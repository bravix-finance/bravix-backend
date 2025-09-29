using Bravix.Module.FinancialAnalysis.Services.FinancialReport.Models;
using ISO3166;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport.RegionalAccounting;

public interface IRegionalAccountingDataProvider
{
    public Country Country { get; }
    
    public FinancialMetric Stocks { get; }
    
    public FinancialMetric Cash { get; }
    
    public FinancialMetric ShortTermFinancialInvestments { get; }
    
    public FinancialMetric ShortTermReceivables { get; }
    
    public FinancialMetric CurrentAssets { get; }
    
    public FinancialMetric CurrentLiabilities { get; }
    
    public FinancialMetric ShortTermLiabilities { get; }
    
    public FinancialMetric CostOfSales { get; }
    
    public FinancialMetric InventoryCost { get; }
    
    public FinancialMetric NetProfit { get; }
    
    public FinancialMetric NetSales { get; }
    
    public FinancialMetric AccountsReceivable { get; }
    
    public FinancialMetric Revenue { get; }
    
    public FinancialMetric Assets { get; }
    
    public FinancialMetric Equity { get; }
    
    public FinancialMetric TotalCapital { get; }
    
    public FinancialMetric TotalLiabilities { get; }
    
    public FinancialMetric TotalIncome { get; }
    
    public FinancialMetric DeptPayments { get; }
    
    public FinancialMetric ProfitFromInvestment { get; }
    
    public FinancialMetric InvestmentCosts { get; }
    
    public FinancialMetric GeneralDept { get; }
    
    public FinancialMetric EBITDA { get; }
    
    public FinancialMetric EBIT { get; }
    
    public FinancialMetric DeptService { get; }
}