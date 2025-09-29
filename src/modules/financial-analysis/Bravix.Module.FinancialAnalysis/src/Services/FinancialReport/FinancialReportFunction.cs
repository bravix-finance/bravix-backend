using Bravix.Module.FinancialAnalysis.Services.FinancialReport.Accounting;
using NodaMoney;

namespace Bravix.Module.FinancialAnalysis.Services.FinancialReport;

public record FinancialReportFunction(
    string[] DependentKeys,
    Func<RecordStorage, Money> GetAmount
)
{
    public static FinancialReportFunction operator /(FinancialReportFunction a, FinancialReportFunction b)
    {
        var dependentKeys = a.DependentKeys.Concat(b.DependentKeys).Distinct().ToArray();

        return new FinancialReportFunction(
            dependentKeys,
            (ctx) =>
                new Money(a.GetAmount(ctx) / b.GetAmount(ctx), Currency.NoCurrency)
        );
    }
    
    public static FinancialReportFunction operator /(decimal a, FinancialReportFunction b)
    {
        return b with { GetAmount = (ctx) =>
            new Money(a / b.GetAmount(ctx).Amount, Currency.NoCurrency) };
    }
    
    public static FinancialReportFunction operator /(FinancialReportFunction a, decimal b)
    {
        return a with { GetAmount = (ctx) =>
            a.GetAmount(ctx) / b };
    }
    
    public static FinancialReportFunction operator *(FinancialReportFunction a, decimal b)
    {
        return a with { GetAmount = (ctx) =>
            a.GetAmount(ctx) * b };
    }
    
    public static FinancialReportFunction operator *(decimal a, FinancialReportFunction b)
    {
        return b with
        {
            GetAmount = (ctx) =>
                a * b.GetAmount(ctx)
        };
    }
}

public static class FinancialReportFunctionHelper
{
    public static FinancialReportFunction Current(this FinancialMetric metric)
    {
        return new FinancialReportFunction(
            metric.DependentKeys,
            (ctx) => metric.GetAmount(ctx.Latest)
        );
    }

    public static FinancialReportFunction Avg(this FinancialMetric metric)
    {
        return new FinancialReportFunction(
            metric.DependentKeys,
            (ctx) =>
            {
                var sum = ctx.History
                    .Aggregate(Money.Zero, (a, d) => a + metric.GetAmount(d));
                return sum / ctx.History.Count();
            }
        );
    }
}