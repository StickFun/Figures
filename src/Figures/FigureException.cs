using System.Runtime.Serialization;

namespace Figures;

public class FigureException : Exception
{
    public FigureException()
    {
    }

    public FigureException(string? message) : base(message)
    {
    }

    public FigureException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
