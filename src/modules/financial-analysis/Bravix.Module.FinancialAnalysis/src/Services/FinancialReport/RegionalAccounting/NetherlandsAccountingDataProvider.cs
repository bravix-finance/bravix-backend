using Bravix.Shared.Common;
using ISO3166;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport.RegionalAccounting;

public class NetherlandsAccountingDataProvider : IRegionalAccountingDataProvider
{
    public Country Country => Countries.GetCountry("NL");
    public FinancialMetric Stocks => new FinancialMetric("3100") +
                                    new FinancialMetric("3150");

    public FinancialMetric Cash => new FinancialMetric("1010");

    public FinancialMetric ShortTermFinancialInvestments => new FinancialMetric("1020");
    
    public FinancialMetric ShortTermReceivables => new FinancialMetric("1580") +
                                                  new FinancialMetric("1586") +
                                                  new FinancialMetric("1589");
    
    public FinancialMetric CurrentAssets => Stocks + 
                                            Cash + 
                                            ShortTermFinancialInvestments + 
                                            ShortTermReceivables;
    
    public FinancialMetric CurrentLiabilities => new FinancialMetric("1700") +
                                                 new FinancialMetric("1701") +
                                                 new FinancialMetric("1987") +
                                                 new FinancialMetric("1988") +
                                                 new FinancialMetric("1989") +
                                                 new FinancialMetric("1990");
    
    public FinancialMetric ShortTermLiabilities => new FinancialMetric("1700") +
                                                   new FinancialMetric("1701") +
                                                   new FinancialMetric("1987") +
                                                   new FinancialMetric("1988") +
                                                   new FinancialMetric("1989") +
                                                   new FinancialMetric("1990");
    
    public FinancialMetric CostOfSales => new FinancialMetric("7110") +
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
    
    public FinancialMetric InventoryCost => new FinancialMetric("3100") +
                                            new FinancialMetric("3150");

    public FinancialMetric NetProfit => new FinancialMetric("Resultaat");
    
    public FinancialMetric NetSales => new FinancialMetric("8110");
    
    public FinancialMetric AccountsReceivable => new FinancialMetric("1580") +
                                                 new FinancialMetric("1586") +
                                                 new FinancialMetric("1589");
    
    public FinancialMetric Revenue => new FinancialMetric("8110");
    
    public FinancialMetric Assets => new FinancialMetric("Activa");
    
    public FinancialMetric Equity => new FinancialMetric("Eigen vermogen");
    
    public FinancialMetric TotalCapital => new FinancialMetric("Passiva");
    
    public FinancialMetric TotalLiabilities => TotalCapital - Equity;
    
    public FinancialMetric TotalIncome => new FinancialMetric("8110");
    
    public FinancialMetric DeptPayments => new FinancialMetric("1990");
    
    public FinancialMetric ProfitFromInvestment => new FinancialMetric("Resultaat");
    
    public FinancialMetric InvestmentCosts => new FinancialMetric("0130") +
                                              new FinancialMetric("0160") +
                                              new FinancialMetric("0462") +
                                              new FinancialMetric("0463");
    
    public FinancialMetric GeneralDept => new FinancialMetric("Passiva") -
                                          new FinancialMetric("Eigen vermogen");
    
    public FinancialMetric EBITDA => new FinancialMetric("Resultaat") - new FinancialMetric("Afschrijvingen");
    
    public FinancialMetric EBIT => new FinancialMetric("Resultaat") + new FinancialMetric("Afschrijvingen");
    
    public FinancialMetric DeptService =>  new FinancialMetric("1990") +
                                           new FinancialMetric("4920") +
                                           new FinancialMetric("4921") +
                                           new FinancialMetric("4925") +
                                           new FinancialMetric("4940");
}