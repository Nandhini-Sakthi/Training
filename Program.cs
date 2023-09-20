string[] wordslist = File.ReadAllLines ("D:\\OneDrive - Trumpf Metamation Pvt Ltd\\words.txt");
char[] letters = { 'U', 'X', 'A', 'L', 'T', 'N', 'E' };
Dictionary<string, int> wordPoints = new Dictionary<string, int> ();
int total=0,point = 0;

foreach (string word in wordslist) {
   if (word.Length >= 4 && word.Contains ('U') && word.All (letters.Contains)) {
      if (letters.All (letter => word.Contains (letter)))
         point = word.Length + 7;
      else
         point = word.Length == 4 ? 1 : word.Length;
      wordPoints[word] = point;
      total += point;
   }
}

var sortedWordPoints = wordPoints.OrderByDescending (kv => kv.Value).ToList ();

foreach (var kvp in sortedWordPoints) {
   if (kvp.Value == 15) 
      Console.ForegroundColor = ConsoleColor.Green;
   Console.WriteLine ($"{kvp.Value,2}. {kvp.Key}");
   Console.ResetColor ();
}
Console.WriteLine ("----");
Console.WriteLine ($"{total} total");