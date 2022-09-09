using PackIT.Domain.ValueObject;

namespace PackIT.Domain.Policies;

public record PolicyData(TravelDays Days, Consts.Gender Gender, ValueObject.Temperature Temperature, Localization Localization);