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
         mArray = new T[4];  // Initialize the array capacity as 4. 
         mCount = 0;
      }
      #endregion

      #region Implementation ----------------------------------------
      /// <summary>Add a element to the array</summary>
      /// <param name="a">Element to be add</param>
      public void Enqueue (T a) {
         if (mCount == mArray.Length) Array.Resize (ref mArray, mArray.Length * 2);
         mArray[mCount] = a;
         mCount++;
      }

      /// <summary>Delete a element from the array and return it</summary>
      /// <returns>Element to be return</returns>
      public T Dequeue () {
         InvalidException ();
         T dequeueItem = mArray[0];
         for (int i = 1; i < mCount; i++) mArray[i - 1] = mArray[i];  // Shift the elements to remove the first item
         mCount--;
         return dequeueItem;
      }

      /// <summary>Display the top elememt</summary>
      /// <returns>Top element in the array</returns>
      public T Peek () {
         InvalidException ();
         return mArray[0];
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
      T[] mArray;
      int mCount;
      #endregion
   }
   #endregion
}