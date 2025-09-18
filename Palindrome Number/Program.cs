class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome(121)); //output true
        Console.WriteLine(IsPalindrome(-121)); //output false
        Console.WriteLine(IsPalindrome(21)); //output false
        Console.WriteLine(IsPalindrome(123)); //output false
    }
    public static bool IsPalindrome(int palindrome)
    {
        int temp = palindrome;
        int rev = 0;
        int digit = 0;
        while(palindrome > 0)
        {
            digit = palindrome % 10;
            rev=rev*10+digit;
            palindrome = palindrome / 10;
        }
        if(rev== temp)
        {
            return true;
        }
        return false;
    }
}