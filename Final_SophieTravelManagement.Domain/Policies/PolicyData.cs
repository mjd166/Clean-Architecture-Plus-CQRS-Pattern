using Final_SophieTravelManagement.Domain.ValueObjects;

namespace Final_SophieTravelManagement.Domain.Policies
{
    public record PolicyData(TravelDays days, Consts.Gender gender, Domain.ValueObjects.Tempreture tempreture, TravelerCheckListDestination destination);
}
