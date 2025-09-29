using NodaMoney;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport.Models;

public record BalanceReportModel(
    decimal CurrentLiquidityRatio,
    decimal QuickRatio,
    decimal AbsoluteLiquidityRatio,
    decimal InventoryTurnoverRatio,
    decimal ReceivablesTurnoverRatio,
    decimal AssetTurnover,
    decimal Dso,
    decimal NetProfitMargin,
    decimal Roa,
    decimal Roe,
    decimal EquityRatio,
    decimal Dti,
    decimal Dscr,
    decimal Roi,
    decimal WorkingCapital,
    decimal EfficiencyRatio,
    decimal DebtToEbitda,
    decimal DebtServiceCoverageRatio
) : IFinancialReportModel;