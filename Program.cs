using System;
Console.Write ("Enter a word or phrase:");
string text = Console.ReadLine ();
text = text.Replace (" ", "").ToLower ();
if (text.Equals (ReverseString (text))) Console.WriteLine (text + " is a Palindrome!");
else Console.WriteLine (text + " is not a Palindrome!");

string ReverseString (string text) {
   char[] chars = text.ToCharArray ();
   char[] reverse = new char[chars.Length];
   int j = chars.Length - 1;
   for (int i = 0; i < chars.Length; i++) {
      reverse[i] = chars[j];
      j--;
   }
   return new string (reverse);
}