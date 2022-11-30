internal class Program
{
    private static void Main(string[] args)
    {
        ReverseString("hello");
    }

    // Q1: How to reverse a string?
    static void ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        for (int i = 0, j = str.Length - 1; i < j; i++, j--)
        {
            charArray[i] = str[j];
            charArray[j] = str[i];
        }
        string reversedstring = new string(charArray);
        Console.WriteLine(reversedstring);
    }

    // Q2: How to find if the given string is a palindrome or not?
    static void chkPalindrome(string str)
    {
        bool flag = false;
        for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
        {
            if (str[i] != str[j])
            {
                flag = false;
                break;
            }
            else
            {
                flag = true;
            }
            if (flag)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Polindrome");
            }
        }
    }
}