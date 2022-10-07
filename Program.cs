// See https://aka.ms/new-console-template for more information
using System.Text;
Console.WriteLine(NextLetter("Znb0y"));
Console.WriteLine(NextLetter("£7eBm"));
Console.WriteLine(StarredLetters("*a*%=3=*"));
Console.WriteLine(StarredLetters("%*3*b%3"));


static string NextLetter(string word)
{
    if (word.Equals(string.Empty) || word.Contains(" "))
    {
        throw new Exception("Argument cannot be an empty string and must not include spaces");
    }
    char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
    string modifiedWord = String.Empty;
    string vowelCheck = String.Empty;
    foreach (var item in word)
    {
        if (Char.IsLetter(item))
        {
            if (Char.IsUpper(item))
            {

                var x = (int)item + 2;
                if (x.Equals(91))
                {
                    x = 65;
                }
                if (x.Equals(92))
                {
                    x = 66;
                }
                modifiedWord += ((char)x).ToString();
            }
            if (Char.IsLower(item))
            {
                var x = (int)item + 2;
                if (x.Equals(123))
                {
                    x = 97;
                }
                if (x.Equals(124))
                {
                    x = 98;
                }
                modifiedWord += ((char)x).ToString();
            }
        }
        else
        {
            modifiedWord += item;
        }
    }

    foreach (var item in modifiedWord)
    {
        foreach (var x in vowels)
        {
            if (item.Equals(x))
            {
                vowelCheck += item.ToString().ToUpper();
            }
        }
        if (modifiedWord.Length != vowelCheck.Length)
        {
            vowelCheck += item;
        }
    }

    return vowelCheck.Trim();
}


static bool StarredLetters(string args)
{
    bool flag = false;
    bool letterCheckFlag = false;
    foreach (var x in args)
    {
        if (Char.IsLetter(x))
        {
            letterCheckFlag = true;
            break;
        }
    }
    if (!letterCheckFlag || args.Equals(string.Empty))
    {
        throw new Exception("Given string must contain at least one letter and must not be an empty string");
    }
    for (int i = 1; i < args.Length - 1; i++)
    {
        if (Char.IsLetter(args[i]) && args[i - 1].Equals('*') && args[i + 1].Equals('*'))
        {
            flag = true;
            break;
        }
    }
    return flag;
}