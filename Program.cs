using System;
using System.Linq;
for (; ; ) {
   Console.Write ("Enter the word:");
   string word = Console.ReadLine ().ToLower ();
   if (word.Distinct ().Count () == word.Length)
      Console.WriteLine ("True." + word + " is an isogram");
   else Console.WriteLine ("False." + word + "is not an isogram");
}