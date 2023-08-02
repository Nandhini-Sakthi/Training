string[] wordslist = File.ReadAllLines ("D:\\OneDrive - Trumpf Metamation Pvt Ltd\\words.txt");
char[] letters = { 'U', 'X', 'A', 'L', 'T', 'N', 'E' };
string[] words = new string[wordslist.Length];
int[] pointArr = new int[wordslist.Length];
int point = 0, index = 0, total = 0;

foreach (string word in wordslist) {
   if (word.Length >= 4 && word.Contains ('U') && word.All (letters.Contains)) {
      if (letters.All (letter => word.Contains (letter))) {
         point = word.Length + 7;
         //Console.WriteLine ($"{word}    {point}");
      } else
         point = word.Length == 4 ? 1 : word.Length;
      // Console.WriteLine ($"{word}    {point}");
      words[index] = word;
      pointArr[index] = point;
      index++;
      total = total + point;
   }
}
Array.Sort (pointArr, words, 0, index, Comparer<int>.Create ((a, b) => b.CompareTo (a)));
for (int i = 0; i < index; i++) {
   if (pointArr[i] == 15) {
      Console.ForegroundColor = ConsoleColor.Green;

   }

   Console.WriteLine ($"{pointArr[i],4}. {words[i]}");
   Console.ResetColor ();
}

Console.WriteLine ("----");
Console.WriteLine ($"{total} totat points");