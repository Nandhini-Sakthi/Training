using System;
using System.Linq;
for (; ; ) {
   Console.Write ("Enter the word : ");
   string word = Console.ReadLine ().ToLower ();
   char[] input = word.ToArray ();
   Array.Sort (input);
   string sortedInput = "";
   foreach (char c in input) {
      sortedInput += c;
   }
   string result = (word == sortedInput) ? "It is an Abecedarian word." : "It is NOT an Abecedarian word.";
   Console.WriteLine (result);
   Console.WriteLine ("Longest Abecedarian word : " + sortedInput);
}