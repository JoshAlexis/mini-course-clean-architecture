using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class EmptyPackingListIdException : PackITException
{
    public EmptyPackingListIdException() : base("Packing list ID cannot be empty.")
    {
    }
}