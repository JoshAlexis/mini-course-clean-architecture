using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class InvalidTemperatureException : PackITException
{
    public double Value { get; }
    
    public InvalidTemperatureException(double value) : base($"Value '{value}' is invalid temperature") => Value = value;
}