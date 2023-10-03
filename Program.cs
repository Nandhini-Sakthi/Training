// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ------------------------------------------------------------------------
// VOTING CONTEST 
// Given a string S to a method, with each character in it representing a vote for a contestant, return the winner with the most votes.
// For example,input=Helloworld;output wil be L, 3 => Winner and votes.
// --------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>Voting Contest</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>getting input from the user</summary>
      static void Main () {
         Console.WriteLine ("Enter the string: ");
         string input = Console.ReadLine ()!;
         FindWinner (input, out char winner, out int votes);
         Console.WriteLine ($"{winner}, {votes} => Winner and votes");
      }
      /// <summary>find the winner based on votes</summary>
      /// <param name="input">word</param>
      /// <param name="winner">letter with maximum votes</param>
      /// <param name="votes">votes</param>
      static void FindWinner (string input, out char winner, out int votes) {
         Dictionary<char, int> voteCount = new Dictionary<char, int> ();//store character and votes.
         foreach (char c in input.ToLower ()) {
            if (Char.IsLetter (c)) {
               if (voteCount.ContainsKey (c)) voteCount[c]++;
               else voteCount[c] = 1;
            }
         }
         char currentWinner = ' ';
         int maxVotes = 0;
         foreach (var kvp in voteCount) {
            if (kvp.Value >= maxVotes || (kvp.Value == maxVotes && kvp.Key < currentWinner)) {//find which char has the most votes.
               currentWinner = kvp.Key;
               maxVotes = kvp.Value;
            }
         }
         winner = currentWinner;
         votes = maxVotes;
      }
      #endregion
   }
   #endregion
}