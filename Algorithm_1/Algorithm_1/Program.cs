using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        //ReverseString("hello");
        //chkPalindrome("1221");
        //ReverseWordOrder("selam arkadaşlar nasılsınız");
        //ReverseWords("selam arkadaşlar nasılsınız");
        //CountCharacter("hello");
        //removeDuplicate("charpcorner");
        //findAllSubstring("abcd");
        //int[] sayilar = new int[] { 5, 6, 7, 8, 9 };
        //RotateLeft(sayilar);
        //RotateRight(sayilar);
        //if (FindPrime(47))
        //{
        //    Console.WriteLine("prime");
        //}
        //else
        //{
        //    Console.WriteLine("not prime");
        //}
        SumOfDigits(168);
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

    // Q3: how to reverse the order of words in a given string?
    static void ReverseWordOrder(string str)
    {
        int i;
        StringBuilder reverseSentence = new StringBuilder();

        int Start = str.Length - 1;
        int End = str.Length - 1;

        while (Start > 0)
        {
            if (str[Start] == ' ')
            {
                i = Start + 1;
                while (i <= End)
                {
                    reverseSentence.Append(str[i]);
                    i++;
                }
                reverseSentence.Append(' ');
                End = Start - 1;
            }
            Start--;
        }

        for (i = 0; i <= End; i++)
        {
            reverseSentence.Append(str[i]);
        }

        Console.WriteLine(reverseSentence.ToString());
    }

    // Q4: how to reverse each word in a given string?
    static void ReverseWords(string str)
    {
        StringBuilder output = new StringBuilder();
        List<char> charlist = new List<char>();

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ' || i == str.Length - 1)
            {
                if (i == str.Length - 1)
                    charlist.Add(str[i]);
                for (int j = charlist.Count - 1; j >= 0; j--)
                    output.Append(charlist[j]);
                output.Append(' ');
                charlist = new List<char>();
            }
            else
            {
                charlist.Add(str[i]);
            }
        }
        Console.WriteLine(output.ToString());
    }

    // Q5: how to count the occurrence of each character in a string?
    static void CountCharacter(string str)
    {
        Dictionary<char, int> characterCount = new Dictionary<char, int>();

        foreach (var character in str)
        {
            if (character != ' ')
            {
                if (!characterCount.ContainsKey(character))
                {
                    characterCount.Add(character, 1);
                }
                else
                {
                    characterCount[character]++;
                }
            }
        }
        foreach (var character in characterCount)
        {
            Console.WriteLine("{0} - {1}", character.Key, character.Value);
        }
    }

    // Q6: how to remove duplicate characters from a string?
    static void removeDuplicate(string str)
    {
        string result = string.Empty;

        for (int i = 0; i < str.Length; i++)
        {
            if (!result.Contains(str[i]))
            {
                result += str[i];
            }
        }

        Console.WriteLine(result);
    }

    // Q7: how to find all possible substring of a given string?
    static void findAllSubstring(string str)
    {
        for (int i = 0; i < str.Length; ++i)
        {
            StringBuilder subString = new StringBuilder(str.Length - i);
            for (int j = i; j < str.Length; ++j)
            {
                subString.Append(str[j]);
                Console.Write(subString + " ");
            }
        }
    }

    // Q8: how to perform left circular rotation of an array?
    static void RotateLeft(int[] array)
    {
        int size = array.Length;
        int temp;
        for (int j = size - 1; j > 0; j--)
        {
            temp = array[size - 1];
            array[array.Length - 1] = array[j - 1];
            array[j - 1] = temp;
        }

        foreach (var num in array)
        {
            Console.Write(num + " ");
        }
    }

    // Q9: how to perform right circular rotation of an array?
    static void RotateRight(int[] array)
    {
        int size = array.Length;
        int temp;
        for (int j = 0; j < size - 1; j++)
        {
            temp = array[0];
            array[0] = array[j + 1];
            array[j + 1] = temp;
        }

        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }

    // Q10: how to find if a positive integer is a prime number or not?
    static bool FindPrime(int number)
    {
        if (number == 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;
        168
        var squareRoot = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= squareRoot; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }

    // Q11: how to find the sum of digits of a positive integer?
    static void SumOfDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        Console.WriteLine(sum);
    }
}