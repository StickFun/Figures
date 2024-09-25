using System.Runtime.CompilerServices;

namespace Figures;

public static class DoubleExtensions
{
    public static void ThrowIfNegativeInfinityOrZero(this double value, [CallerArgumentExpression("value")] string message = null)
    {
        if (!double.IsFinite(value) || value <= 0)
        {
            throw new FigureException(message ?? $"{message} число должно быть конечным и больше нуля.");
        }
    }
}
