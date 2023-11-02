// --------------------------------------------------------------------------------------------
// Training ~ A training program for interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ------------------------------------------------------------------------
// Program.cs
// QUEUE<T>
// Implement a Queue<T> using arrays as the underlying data structure. The queue should grow the array when needed (like the TStack above does).
// If the array does not have to be grown, both Enqueue and Dequeue should be constant time (O(1)) operations. Throw exceptions as needed.
// class TQueue<T> { 
// public void Enqueue (T a) { }
// public T Dequeue () { }
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
         TQueue<int> queue = new ();
         queue.Enqueue (1);
         queue.Enqueue (2);
         queue.Enqueue (3);
         Console.WriteLine ("Top item: " + queue.Peek ());
         while (!queue.IsEmpty)
            Console.WriteLine ("Dequeue item: " + queue.Dequeue ());
      }
      #endregion
   }
   #endregion

   #region TQueue<T> ------------------------------------------------------------------------------
   /// <summary>Create a class</summary>
   /// <typeparam name="T">Datatype of the array</typeparam>
   class TQueue<T> {
      #region Constructor -------------------------------------------
      /// <summary>Creating the constructor for initializing the values</summary>
      public TQueue () {
      }
      #endregion

      #region Implementation ----------------------------------------
      /// <summary>Add a element to the array</summary>
      /// <param name="a">Element to be add</param>
      public void Enqueue (T a) {
         if (mCount == mArray.Length) Array.Resize (ref mArray, mArray.Length * 2);
         mArray[mRear] = a;
         mRear = (mRear + 1) % mArray.Length;
         mCount++;
      }

      /// <summary>Delete a element from the array and return it</summary>
      /// <returns>Element to be return</returns>
      public T Dequeue () {
         InvalidException ();
         T item = mArray[mFront];
         mFront = (mFront + 1) % mArray.Length;
         mCount--;
         return item;
      }

      /// <summary>Display the top elememt</summary>
      /// <returns>Top element in the array</returns>
      public T Peek () {
         InvalidException ();
         return mArray[mFront];
      }

      /// <summary>Check the array is empty or not</summary>
      public bool IsEmpty => mCount == 0;

      /// <summary>Expection handling</summary>
      /// <exception cref="InvalidOperationException">When the array is empty</exception>
      public void InvalidException () {
         if (IsEmpty)
            throw new InvalidOperationException ("It is an empty queue.");
      }
      #endregion

      #region Private data ------------------------------------------
      T[] mArray = new T[4];
      int mCount = 0;
      int mRear = 0;
      int mFront = 0;
      #endregion
   }
   #endregion
}