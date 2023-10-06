// --------------------------------------------------------------------------------------------
// Training ~ A training program for interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// Extension of Spelling Bee assignment
// Display the first 7 letters to be used as the seed for the Spelling Bee program from the given word list.
// --------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
// Reading all letter in the wordlist.
string wordsList = File.ReadAllText ("D:\\OneDrive - Trumpf Metamation Pvt Ltd\\words.txt");
Dictionary<char, int> output = new ();

foreach (char ch in wordsList) {
   if (ch >= 'A' && ch <= 'Z') {
      // Initialize count to 1 for a new character
      if (!output.ContainsKey (ch)) output[ch] = 1;
      // Increment count for an existing character
      else output[ch]++; 
   }
}
// Arrange the letters in descending order based on the value.
foreach (var kvp in output.OrderByDescending (kv => kv.Value).Take (7)) 
   Console.WriteLine ($"Character: {kvp.Key} , Count: {kvp.Value}");