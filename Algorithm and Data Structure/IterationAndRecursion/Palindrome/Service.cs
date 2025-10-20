namespace Palindrome
{
    internal class Service
    {
        public bool IsPalindromeByIteration(string word)
        {
            for (int i = 0; i < word.Length / 2; i++) 
            {
                if(word[i] != word[word.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsPalindromeByRecursion(string word, int index)
        {
            if (index > word.Length / 2)
            {
                return true;
            }
            if (word[index] != word[word.Length - 1 - index]) 
            { 
                return false; 
            }
            return IsPalindromeByRecursion(word, index + 1);    
        }
    }
}
