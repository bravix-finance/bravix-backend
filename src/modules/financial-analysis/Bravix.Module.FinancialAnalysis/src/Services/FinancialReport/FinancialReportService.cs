using Bravix.Module.FinancialAnalysis.Services.FinancialRecord;
using Bravix.Module.FinancialAnalysis.Services.FinancialRecord.Models;
using Bravix.Module.FinancialAnalysis.Services.FinancialReport.Models;
using Bravix.Module.FinancialAnalysis.Services.FinancialReport.RegionalAccounting;
using Bravix.Module.FinancialAnalysis.Services.FinancialReport.ReportBuilders;
using Bravix.Module.FinancialAnalysis.Services.FinancialReport.ReportContexts;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport;

public class FinancialReportService : IFinancialReportService
{
    private readonly IFinancialRecordService _financialRecordService;
    private readonly IAccountingDataProviderResolver _accountingDataProviderResolver;

    public FinancialReportService(
        IFinancialRecordService financialRecordService,
        IAccountingDataProviderResolver accountingDataProviderResolver
    )
    {
        _financialRecordService = financialRecordService;
        _accountingDataProviderResolver = accountingDataProviderResolver;
    }

    public async Task<BalanceReportModel> GetBalanceReport(GetFinancialReportCommand command, CancellationToken token)
    {
        var dataProvider = _accountingDataProviderResolver.GetDataProvider(command.CountryCode);

        var context = new BalanceReportContext(dataProvider);

        var dependentKeys = context
            .Functions
            .SelectMany(x => x.DependentKeys)
            .Distinct()
            .ToArray();

        var records = await _financialRecordService.GetFinancialRecords(
            new GetFinancialRecordsCommand(
                command.OrganizationId,
                dependentKeys
            ),
            token
        );
        
        var recordStorage = new RecordStorage(records);

        var reportBuilder = new BalanceReportBuilder();
        
        return reportBuilder.Build(context, recordStorage);
    }
}