

namespace DomainLayer.Models
{
    public class Kelvin
    {
        public double Degree { get; set; }
        public Kelvin(double degree)
        {
            Degree = degree;
        }

        public static implicit operator Kelvin(Celsius v)
        {
            return new Kelvin(v.Degree - 273.15);
        }
    }
}
