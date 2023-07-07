# WordSearchII

WordSearchII is a C# program that finds words in a 2D board of characters using a Trie data structure and depth-first search (DFS).

## Problem Description

Given a 2D board of characters and a list of words, the program finds all the words in the board that can be constructed by connecting adjacent letters horizontally or vertically. Each letter in the board can only be used once in a word.

## Usage

1. Ensure you have the .NET SDK installed on your machine.

2. Clone the repository or download the source code.

3. Open the project in your preferred IDE.

4. Modify the `Main` method in the `Program` class to set up the board and words.

5. Build and run the program.

6. The program will output the words found in the board.

## Example

Here's an example of how to use the WordSearchII program:

```csharp
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
```



In this example, the program sets up the board and words, creates an instance of the Solution class, and calls the FindWords method to find the words in the board. The found words are then printed to the console.

## Dependencies
The WordSearchII project has no external dependencies.

## License

This project is licensed under the [MIT License](LICENSE).

