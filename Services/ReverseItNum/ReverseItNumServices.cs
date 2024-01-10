
namespace FiveToSeven.Services.ReverseItNum;
public class ReverseItNumServices : IReverseItNumServices
{
    public string ReverseItNum(string input)
    {
        int reversedNum = 0;
        bool number = int.TryParse(input, out int num);

        if(number)
        {
            while (num != 0)
            {
                reversedNum = reversedNum * 10 + (num % 10);
                num = num / 10;
            }
        }
        else
        {
            return "Error Integer Required";
        }
        return $"Your Number Reversed Is {reversedNum}";
    }
}
