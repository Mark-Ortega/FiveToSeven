
namespace FiveToSeven.Services.OddOrEven
{
    public class OddOrEvenServices : IOddOrEvenServices
    {
        public string OddOrEven(int num)
        {
            if (num % 2 == 0)
            {
                return $"{num} is Even";
            }
            else
            {
                return $"{num} is Odd";
            }
        }
    }
}