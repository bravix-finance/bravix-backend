namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport.Accounting;

public interface IAccountingDataProviderResolver
{
    IAccountingDataProvider GetDataProvider(string countryCode);
}