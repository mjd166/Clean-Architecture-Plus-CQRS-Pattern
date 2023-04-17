using Final_SophieTravelManagement.Domain.Exceptions;

namespace Final_SophieTravelManagement.Domain.ValueObjects
{
    public record Tempreture
    {
        public double Value { get; }

        public Tempreture(double value)
        {
            if (value is < -100 or > 100)
            {
                throw new InvalidTempretureException(value);
            }
            Value = value;
        }

        public static implicit operator double(Tempreture tempreture)
            => tempreture.Value;

        public static implicit operator Tempreture(double tempreture)
            => new(tempreture);
    }

}
