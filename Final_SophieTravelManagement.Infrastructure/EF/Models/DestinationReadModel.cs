using System.Linq;

namespace Final_SophieTravelManagement.Infrastructure.EF.Models
{
    public class DestinationReadModel
    {
        public string City { get; set; }
        public string Country { get; set; }

        public static DestinationReadModel Create(string value)
        {
            var splitLocalization = value.Split(',');
            return new DestinationReadModel
            {
                City = splitLocalization.First(),
                Country = splitLocalization.Last()
            };
        }

        public override string ToString()
        {
            return $"{City},{Country}";
        }
    }
}
