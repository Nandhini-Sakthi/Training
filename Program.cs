using System;
using System.Linq;
for (; ; ) {
   Console.Write ("Enter the word:");
   string word = Console.ReadLine ().ToLower ();
   if (!Isogram (word))
      Console.WriteLine (word + " is not an isogram.");
   else Console.WriteLine (word + " is an isogram.");
}
bool Isogram (string word) {
   if (word.Distinct ().Count () == word.Length)
      return true;
   else
      return false;
}