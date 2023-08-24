using System;
Console.Write ("Enter a word or phrase:");
string text = Console.ReadLine ();
text = text.Replace (" ", "").ToLower ();
string ReverseString (string text) {
   char[] ch = text.ToCharArray ();
   Array.Reverse (ch);
   string rev = new string (ch);
   return rev;
}
if (text == ReverseString (text)) Console.WriteLine (text + " is a Palindrome!");
else Console.WriteLine (text + " is not a Palindrome!");