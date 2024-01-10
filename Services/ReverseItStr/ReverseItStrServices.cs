
namespace FiveToSeven.Services.ReverseItStr;

public class ReverseItStrServices : IReverseItStrServices
{
    public string ReverseItStr(string input)
    {
        string reverseStr = "";

        for(int i = input.Length - 1; i >= 0; i--)
        {
            reverseStr += input[i];
        }
        return $"Your string Reversed is {reverseStr}";
    }
}
