// ------------------------------------------------------------------------------------------------
// Training ~ A training program for interns at Metamation, Batch - July 2023.
// Copyright (c) Metamation India.
// ----------------------------------------------------------------------------
// Program.cs
// A10.1:
// Implementation of file name parser using state machine.
// ------------------------------------------------------------------------------------------------
using System;
using static System.Console;
namespace Training {

   #region Class Program -----------------------------------------------------------------------
   /// <summary>Program</summary>
   public class Program {
      #region Methods --------------------------------------------
      /// <summary>Gets filepath as an input from the user</summary>
      static void Main () {
         WriteLine ("Enter a file path:");
         string s = ReadLine ()!;
         if (FileParse.FileNameParse (s, out (string driveLetter, string folderPath, string fileName, string extension) res)) {
            WriteLine ($"Drive letter: {res.driveLetter}");
            WriteLine ($"Folder Path: {res.folderPath}");
            WriteLine ($"File name: {res.fileName}");
            WriteLine ($"Extension: {res.extension}");
         } else WriteLine ("Enter a valid file path name");
      }
      #endregion
   }
   #endregion

   #region Class FileParse ---------------------------------------------------------------------
   /// <summary>File name parse</summary>
   public class FileParse {
      #region Methods --------------------------------------------
      /// <summary>When given a string it parses it into parts and returns the components of file path</summary>
      /// <param name="input">Given string</param>
      /// <param name="driveLetter">Drive letter parsed</param>
      /// <param name="folderPath">Folder path parsed</param>
      /// <param name="fileName">File name parsed</param>
      /// <param name="extension">File extension</param>
      /// <returns>True if parsing was successful; otherwise, false</returns>
      public static bool FileNameParse (string input, out (string drive,string folder,string file,string ext)res) {
         State s = State.A;
         Action none = () => { }, todo;
         string folder = "", drive = "", file = "", ext = "";
         foreach (var ch in input.Trim ().ToUpper () + '~') {
            (s, todo) = (s, ch) switch {
               (State.A, >= 'A' and <= 'Z') => (State.B, () => drive = ch.ToString ()),
               (State.B, ':') => (State.C, none),
               (State.C, '\\') => (State.D, none),
               (State.D or State.E, >= 'A' and <= 'Z') => (State.E, () => folder += ch),
               (State.E, '\\') => (State.F, none),
               (State.F or State.G, >= 'A' and <= 'Z') => (State.G, () => file += ch),
               (State.G, '\\') => (State.F, () => { folder += '\\' + file; file = string.Empty; }),
               (State.G, '.') => (State.H, none),
               (State.H or State.I, >= 'A' and <= 'Z') => (State.I, () => ext += ch),
               (State.I, '~') => (State.J, none),
               _ => (State.Z, none),
            };
            todo ();
         }
         if (s == State.J) {
            res = (drive, folder, file, ext);
            return true;
         } else {
            res = ("", "", "", "");
            return false;  
         }
      }

      /// <summary>States invloved
      /// see file://D:/Work/statemachinedia.png</summary>
      public enum State { A, B, C, D, E, F, G, H, I, J, Z };
      #endregion
   }
   #endregion
}