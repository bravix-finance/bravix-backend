using Bravix.Module.FinancialAnalysis.Services.FinancialReport.Models;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport.Reports.BalanceReport;

public record BalanceReportModel(
    BalanceReportItem CurrentLiquidityRatio,
    BalanceReportItem QuickRatio,
    BalanceReportItem AbsoluteLiquidityRatio,
    BalanceReportItem InventoryTurnoverRatio,
    BalanceReportItem ReceivablesTurnoverRatio,
    BalanceReportItem AssetTurnover,
    BalanceReportItem Dso,
    BalanceReportItem NetProfitMargin,
    BalanceReportItem Roa,
    BalanceReportItem Roe,
    BalanceReportItem EquityRatio,
    BalanceReportItem Dti,
    BalanceReportItem Dscr,
    BalanceReportItem Roi,
    BalanceReportItem WorkingCapital,
    BalanceReportItem EfficiencyRatio,
    BalanceReportItem DebtToEbitda,
    BalanceReportItem DebtServiceCoverageRatio
) : IFinancialReportModel;

public record BalanceReportItem(
    decimal Value,
    ReportThresholdItem Threshold
);