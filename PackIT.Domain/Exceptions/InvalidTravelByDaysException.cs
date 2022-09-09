using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class InvalidTravelByDaysException : PackITException
{
    public ushort Days { get; }

    public InvalidTravelByDaysException(ushort days) : base($"Value '{days}' is invalid travel days") => Days = days;
}