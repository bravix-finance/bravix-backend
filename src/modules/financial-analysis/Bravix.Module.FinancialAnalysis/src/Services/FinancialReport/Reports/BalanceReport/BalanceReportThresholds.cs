namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport.Reports.BalanceReport;

public record BalanceReportThresholds(
    ReportThresholdItem CurrentLiquidityRatio,
    ReportThresholdItem QuickRatio,
    ReportThresholdItem AbsoluteLiquidityRatio,
    ReportThresholdItem InventoryTurnoverRatio,
    ReportThresholdItem ReceivablesTurnoverRatio,
    ReportThresholdItem AssetTurnover,
    ReportThresholdItem Dso,
    ReportThresholdItem NetProfitMargin,
    ReportThresholdItem Roa,
    ReportThresholdItem Roe,
    ReportThresholdItem EquityRatio,
    ReportThresholdItem Dti,
    ReportThresholdItem Dscr,
    ReportThresholdItem Roi,
    ReportThresholdItem WorkingCapital,
    ReportThresholdItem EfficiencyRatio,
    ReportThresholdItem DebtToEbitda,
    ReportThresholdItem DebtServiceCoverageRatio
) : IFinancialReportThresholds<BalanceReportModel>
{
    public static BalanceReportThresholds Default => new(
        CurrentLiquidityRatio: new(Min: 1.5m, Max: 2m),
        QuickRatio: new(Min: 1.5m, Max: 2m),
        AbsoluteLiquidityRatio: new(Min: 0.2m),
        InventoryTurnoverRatio: new(Min: 5m, Max: 10m),
        ReceivablesTurnoverRatio: new(Min: 5m, Max: 12m),
        AssetTurnover: new(Min: 1m, Max: 2m),
        Dso: new(Max: 45m),
        NetProfitMargin: new(Min: 10m),
        Roa: new(Min: 5m),
        Roe: new(Min: 15m),
        EquityRatio: new(Min: 50m),
        Dti: new(Max: 40m),
        Dscr: new(Min: 1.5m),
        Roi: new(Min: 15m),
        WorkingCapital: new(Min: 0),
        EfficiencyRatio: new(Min: 1.5m),
        DebtToEbitda: new(Max: 3.5m),
        DebtServiceCoverageRatio: new(Min: 1.2m)
    );
}