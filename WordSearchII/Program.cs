namespace WordSearchII
{
    public class Solution
    {
        public IList<string> FindWords(char[][] board, string[] words)
        {
            TrieNode root = BuildTrie(words);
            List<string> result = new List<string>();

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    Dfs(board, i, j, root, result);
                }
            }

            return result;
        }

        public void Dfs(char[][] board, int i, int j, TrieNode p, List<string> result)
        {
            char c = board[i][j];
            if (c == '#' || p.next[c - 'a'] == null) return;

            p = p.next[c - 'a'];
            if (p.word != null)
            {
                result.Add(p.word);
                p.word = null;   // Avoid duplicate
            }

            board[i][j] = '#';
            if (i > 0) Dfs(board, i - 1, j, p, result);
            if (j > 0) Dfs(board, i, j - 1, p, result);
            if (i < board.Length - 1) Dfs(board, i + 1, j, p, result);
            if (j < board[0].Length - 1) Dfs(board, i, j + 1, p, result);
            board[i][j] = c;
        }

        public TrieNode BuildTrie(string[] words)
        {
            TrieNode root = new TrieNode();

            foreach (string word in words)
            {
                TrieNode node = root;
                foreach (char c in word.ToCharArray())
                {
                    int i = c - 'a';
                    if (i < 0 || i >= 26) // ensure the character is a lowercase letter
                    {
                        throw new Exception($"Invalid character '{c}' in word. Words should only contain lowercase letters.");
                    }
                    if (node.next[i] == null) node.next[i] = new TrieNode();
                    node = node.next[i];
                }
                node.word = word;
            }

            return root;
        }

    }

    public class TrieNode
    {
        public TrieNode[] next = new TrieNode[26];
        public string word;
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Initialize the board
            char[][] board = new char[][] {
            new char[] {'a', 'b', 'c', 'e'},
            new char[] {'s', 'f', 'c', 's'},
            new char[] {'a', 'd', 'e', 'e'}
        };

            // Initialize the words
            string[] words = new string[] { "abccd", "see", "abcb" };

            // Initialize the Solution class
            Solution solution = new Solution();

            // Use the FindWords method
            IList<string> foundWords = solution.FindWords(board, words);

            // Print the found words
            foreach (string word in foundWords)
            {
                Console.WriteLine(word);
            }
        }
    }

}