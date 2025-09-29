using Bravix.Module.FinancialAnalysis.Services.FinancialReport.Models;
using Bravix.Module.FinancialAnalysis.Services.FinancialReport.ReportContexts;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport.ReportBuilders;

public class BalanceReportBuilder : IFinancialReportBuilder<BalanceReportModel, BalanceReportContext>
{
    public BalanceReportModel Build(BalanceReportContext context, RecordStorage storage)
    {
        return new BalanceReportModel(
            CurrentLiquidityRatio: context.CurrentLiquidityRatio.GetAmount(storage).Amount,
            QuickRatio: context.QuickRatio.GetAmount(storage).Amount,
            AbsoluteLiquidityRatio: context.AbsoluteLiquidityRatio.GetAmount(storage).Amount,
            InventoryTurnoverRatio: context.InventoryTurnoverRatio.GetAmount(storage).Amount,
            ReceivablesTurnoverRatio: context.ReceivablesTurnoverRatio.GetAmount(storage).Amount,
            AssetTurnover: context.AssetTurnover.GetAmount(storage).Amount,
            Dso: context.Dso.GetAmount(storage).Amount,
            NetProfitMargin: context.NetProfitMargin.GetAmount(storage).Amount,
            Roa: context.Roa.GetAmount(storage).Amount,
            Roe: context.Roe.GetAmount(storage).Amount,
            EquityRatio: context.EquityRatio.GetAmount(storage).Amount,
            Dti: context.Dti.GetAmount(storage).Amount,
            Dscr: context.Dscr.GetAmount(storage).Amount,
            Roi: context.Roi.GetAmount(storage).Amount,
            WorkingCapital: context.WorkingCapital.GetAmount(storage).Amount,
            EfficiencyRatio: context.EfficiencyRatio.GetAmount(storage).Amount,
            DebtToEbitda: context.DebtToEbitda.GetAmount(storage).Amount,
            DebtServiceCoverageRatio: context.DebtServiceCoverageRatio.GetAmount(storage).Amount
        );
    }
}