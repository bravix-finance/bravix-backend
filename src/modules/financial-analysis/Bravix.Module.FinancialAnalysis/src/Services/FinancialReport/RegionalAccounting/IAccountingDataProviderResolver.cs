using ISO3166;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport.RegionalAccounting;

public interface IAccountingDataProviderResolver
{
    IRegionalAccountingDataProvider GetDataProvider(string countryCode);
}