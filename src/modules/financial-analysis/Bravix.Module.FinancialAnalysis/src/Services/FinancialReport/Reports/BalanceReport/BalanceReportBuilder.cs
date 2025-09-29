namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport.Reports.BalanceReport;

public class BalanceReportBuilder : IFinancialReportBuilder<BalanceReportModel, BalanceReportContext, BalanceReportThresholds>
{
    public BalanceReportModel Build(
        BalanceReportContext context,
        RecordStorage storage,
        BalanceReportThresholds thresholds)
    {
        return new BalanceReportModel(
            CurrentLiquidityRatio: new (
                context.CurrentLiquidityRatio.GetAmount(storage).Amount, 
                thresholds.CurrentLiquidityRatio
                ),
            QuickRatio: new (
                context.QuickRatio.GetAmount(storage).Amount,
                thresholds.QuickRatio
                ),
            AbsoluteLiquidityRatio: new (
                context.AbsoluteLiquidityRatio.GetAmount(storage).Amount,
                thresholds.AbsoluteLiquidityRatio
                ),
            InventoryTurnoverRatio: new (
                context.InventoryTurnoverRatio.GetAmount(storage).Amount,
                thresholds.InventoryTurnoverRatio
                ),
            ReceivablesTurnoverRatio: new (
                context.ReceivablesTurnoverRatio.GetAmount(storage).Amount,
                thresholds.ReceivablesTurnoverRatio
                ),
            AssetTurnover: new (
                context.AssetTurnover.GetAmount(storage).Amount,
                thresholds.AssetTurnover
                ),
            Dso: new (
                context.Dso.GetAmount(storage).Amount,
                thresholds.Dso
                ),
            NetProfitMargin: new (
                context.NetProfitMargin.GetAmount(storage).Amount,
                thresholds.NetProfitMargin
                ),
            Roa: new (
                context.Roa.GetAmount(storage).Amount,
                thresholds.Roa
                ),
            Roe: new (
                context.Roe.GetAmount(storage).Amount,
                thresholds.Roe
                ),
            EquityRatio: new (
                context.EquityRatio.GetAmount(storage).Amount,
                thresholds.EquityRatio
                ),
            Dti: new (
                context.Dti.GetAmount(storage).Amount,
                thresholds.Dti
                ),
            Dscr: new (
                context.Dscr.GetAmount(storage).Amount,
                thresholds.Dscr
                ),
            Roi: new (
                context.Roi.GetAmount(storage).Amount,
                thresholds.Roi
                ),
            WorkingCapital: new (
                context.WorkingCapital.GetAmount(storage).Amount,
                thresholds.WorkingCapital
                ),
            EfficiencyRatio: new (
                context.EfficiencyRatio.GetAmount(storage).Amount,
                thresholds.EfficiencyRatio
                ),
            DebtToEbitda: new (
                context.DebtToEbitda.GetAmount(storage).Amount,
                thresholds.DebtToEbitda
                ),
            DebtServiceCoverageRatio: new (
                context.DebtServiceCoverageRatio.GetAmount(storage).Amount,
                thresholds.DebtServiceCoverageRatio
                )
        );
    }
}