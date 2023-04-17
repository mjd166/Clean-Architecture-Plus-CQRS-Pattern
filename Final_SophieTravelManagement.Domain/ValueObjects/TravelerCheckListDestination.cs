using System.Linq;
namespace Final_SophieTravelManagement.Domain.ValueObjects
{
    public record TravelerCheckListDestination(string city, string country)
    {
        public static TravelerCheckListDestination Create(string value)
        {
            var splitDestination = value.Split(',');
            return new TravelerCheckListDestination(splitDestination.First(), splitDestination.Last());

        }

        public override string ToString() => $"{city},{country}";
    }
}
