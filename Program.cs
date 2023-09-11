using System;
using System.Linq;
for (; ; ) {
   Console.Write ("Enter the word:");
   string word = Console.ReadLine ().ToLower ();
   var res = (!Isogram (word)) ? word + " is not an isogram." : word + " is an isogram.";
   Console.WriteLine (res);
}

bool Isogram (string word) => word.Distinct ().Count () == word.Length;