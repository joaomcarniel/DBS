using System.Text;

namespace ReverseString
{
    internal class Service
    {

        public string ReverseStringByIteration(string word)
        {
            var response = new StringBuilder();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                response.Append(word[i]);
            }
            return response.ToString();
        }

        public string ReverseStringByRecursion(string word, int index)
        {
            if (index == word.Length)
                return "";

            return $"{word[word.Length - 1 - index]}" + ReverseStringByRecursion(word, index + 1);
        }
    }
}
