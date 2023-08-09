using System;
Console.Write ("Enter a word or phrase:");
string text = Console.ReadLine ();
text = text.Replace (" ", "").ToLower ();
char[] ch = text.ToCharArray ();
Array.Reverse (ch);
string rev = new string (ch);
bool b = text.Equals (rev); 
if (b == true) {
   Console.WriteLine ("" + text + " is a Palindrome!");
} else {
   Console.WriteLine (" " + text + " is not a Palindrome!");
}

      

