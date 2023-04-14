internal class Program
{
    public static bool AreAnagrams(string s1, string s2)
    {
        if (s1 == null) throw new ArgumentNullException("s1");
        if (s2 == null) throw new ArgumentNullException("s2");

        var chars = new Dictionary<char, int>();
        foreach (char c in s1)
        {
            if (!chars.ContainsKey(c))
                chars[c] = 0;
            chars[c]++;
        }
        foreach (char c in s2)
        {
            if (!chars.ContainsKey(c))
                return false;
            chars[c]--;
        }

        return chars.Values.All(i => i == 0);
    }
    static void Main(string[] args)
    {
        var word1 = "ali";
        var word2 = "ila";
        var checkAnagram = AreAnagrams(word1, word2);
        Console.WriteLine($"Is Anagram: {checkAnagram}");
    }
}