using System.Text;
(bool, int) PalindromeChecker(string Str)
{
    Str = Str.ToLower();
    var sb = new StringBuilder();
    int i;
    foreach (char c in Str)
    {
        if (char.IsPunctuation(c) || char.IsWhiteSpace(c))
        {
            continue;
        }
        sb.Append(c);
    }
    string tempStr = sb.ToString();
    int begin = 0;
    int end = tempStr.Length - 1;
    for (; begin <= end; begin++, end--)
    {
        if (tempStr[begin] != tempStr[end])
            return (false, 0);
    }
    return (true, Str.Length);
}
string stringInput = "";
(bool, int) result;
Console.WriteLine("Let's begin:");
while (true)
{
    stringInput = Console.ReadLine();
    if (stringInput == "exit")
        break;
    result = PalindromeChecker(stringInput);
    Console.WriteLine($"Palindrome: {result.Item1}, Length: {result.Item2}");
}