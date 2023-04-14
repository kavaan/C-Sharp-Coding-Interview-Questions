internal class Program
{
    static bool AreAnagrams(string word1, string word2)
    {
        var word1ToChar = word1.ToCharArray();
        var word2ToChar = word2.ToCharArray();

        Array.Sort(word1ToChar);
        Array.Sort(word2ToChar);

        return word1ToChar.SequenceEqual(word2ToChar);
    }

    private static void Main(string[] args)
    {
        var word1 = "ali";
        var word2 = "ila";
        var checkAnagram = AreAnagrams(word1, word2);
        Console.WriteLine($"Is Anagram: {checkAnagram}");
    }
}