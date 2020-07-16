using System;
using System.Collections.Generic;

  namespace Scrabble.Models
  {
    public class Words 
    {
      public string InputWord { get; set; }
      public int Score { get; set; }

      public Words(string word)
      {
        InputWord = word;
        Score = 0;
      }

      public int ArraySplit()
      {
        char[] NewArray = (InputWord.ToUpper()).ToCharArray();
        for (int i = 0; i < NewArray.Length; i++)
        {
          Score += LetterScores[NewArray[i]];
        }
        return Score;
      }
      public Dictionary<char, int> LetterScores = new Dictionary<char, int>()
      {
        {'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, {'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1},
        {'D', 2}, {'G', 2},
        {'B', 3}, {'C', 3}, {'M', 3}, {'P', 3},
        {'F', 4}, {'H', 4}, {'V', 4}, {'W', 4}, {'Y', 4},
        {'K', 5},
        {'J', 8}, {'X', 8},
        {'Q', 10}, {'Z', 10}
      };
    }
  }