// --------------------------------------------------------------------------------------------
// Training ~ A training program for interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ------------------------------------------------------------------------
// Program.cs
// STACK<T>
// Implement a Stack<T> class using arrays as the underlying data structure. The Stack<T> should start with an initial capacity of 4 and double its capacity when needed.
// Use the template shown below for implementation. Throw exceptions when necessary.
// class TStack<T> { 
// public void Push (T a) { }
// public T Pop () { }
// public T Peek () { }
// public bool IsEmpty { get; }
// }
// --------------------------------------------------------------------------------------------
using System;
namespace Training {
   #region Program ------------------------------------------------------------------------------
   class Program {
      #region Method ---------------------------------------------
      static void Main () {
         TStack<int> stack = new ();
         stack.Push (1);
         stack.Push (2);
         stack.Push (3);
         Console.WriteLine ("Top item: " + stack.Peek ());
         while (!stack.IsEmpty)
            Console.WriteLine ("Popped: " + stack.Pop ());
      }
      #endregion
   }
   #endregion
   #region TStack<T> ------------------------------------------------------------------------------
   /// <summary>Create a class</summary>
   /// <typeparam name="T">Datatype of the array</typeparam>
   class TStack<T> {
      #region Constructor -------------------------------------------
      /// <summary>Creating the constructor</summary>
      public TStack () {
      }
      #endregion

      #region Implementation ----------------------------------------
      /// <summary>Add an element to the array</summary>
      /// <param name="item">Element to be added</param>
      public void Push (T item) {
         if (mCount == mArray.Length) Array.Resize (ref mArray, mArray.Length * 2);
         mArray[mCount++] = item;
      }

      /// <summary>Delete a element from the array and return it</summary>
      /// <returns>Element to be return</returns>
      public T Pop () {
         InvalidException ();
         T item = mArray[--mCount];
         return item;
      }

      /// <summary>Display the top elememt</summary>
      /// <returns>Top element in the array</returns>
      public T Peek () {
         InvalidException ();
         return mArray[mCount - 1];
      }

      /// <summary>Expection handling</summary>
      /// <exception cref="InvalidOperationException">When the array is empty</exception>
      public void InvalidException () {
         if (IsEmpty)
            throw new InvalidOperationException ("It is an empty stack.");
      }
      #endregion

      #region Properties --------------------------------------------
      /// <summary>Check the array is empty or not</summary>
      public bool IsEmpty => mCount == 0;
      #endregion

      #region Private data ------------------------------------------
      T[] mArray = new T[4];
      int mCount = 0;
      #endregion
   }
   #endregion
}