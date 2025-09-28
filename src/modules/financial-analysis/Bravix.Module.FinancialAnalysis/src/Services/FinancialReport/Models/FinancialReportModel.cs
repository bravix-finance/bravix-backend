using NodaMoney;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport.Models;

public record FinancialReportModel(
    decimal CurrentLiquidityRatio,
    decimal QuickRatio,
    decimal AbsoluteLiquidityRatio,
    decimal InventoryTurnoverRatio,
    decimal ReceivablesTurnoverRatio,
    decimal AssetTurnover,
    decimal AverageTurnoverPeriodOfAccountsReceivable,
    decimal NetProfitMargin,
    decimal ReturnOnAssets,
    decimal ReturnOnEquity,
    decimal EquityRatio,
    decimal DebtToIncomeRatio,
    decimal DebtServiceCoverageRatio,
    decimal ReturnOnInvestment,
    decimal WorkingCapital,
    decimal EfficiencyRatio,
    decimal DebtToEbitda
);