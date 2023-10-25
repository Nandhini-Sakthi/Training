// --------------------------------------------------------------------------------------------
// Training ~ A training program for interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// MYLIST<T> 
// Implement a custom MyList<T> class using arrays as the underlying data structure.
// --------------------------------------------------------------------------------------------
using System;
namespace Training {
   #region Program ------------------------------------------------------------------------------
   class Program {
      #region Method ---------------------------------------------
      static void Main () {
         MyList<int> list = new ();
         for (int i = 1; i <= 7; i++) list.Add (i);
         list.Display ();
         list.Remove (7);
         list.Clear ();
         list.Display ();
         for (int i = 1; i <= 6; i++) list.Insert (i - 1, i);
         list.Display ();
         list.RemoveAt (0);
         list.RemoveAt (1);
         list.Display ();
      }
      #endregion
   }
   #endregion

   #region MyList<T> ------------------------------------------------------------------------------
   /// <summary>Create a class</summary>
   /// <typeparam name="T">Datatype of the list</typeparam>
   public class MyList<T> {
      #region Constructor -------------------------------------------
      /// <summary>Creating a Constructor for initializing the values</summary>
      public MyList () {
         mArray = new T[4];  // Initialize the array capacity as 4. 
         mCount = 0;
      }
      #endregion

      #region Properties --------------------------------------------
      /// <summary>Calculating capacity of the array</summary>
      public int Capacity => mArray.Length;

      /// <summary>Gets the number of elements in the list</summary>
      public int Count => mCount;

      /// <summary>Set and return the value based on the index</summary>
      /// <param name="index">Index to be change</param>
      /// <returns>Changed value of the index</returns>
      public T this[int index] {
         get {
            CheckIndexRange (index);
            return mArray[index];
         }
         set {
            CheckIndexRange (index);
            mArray[index] = value;
         }
      }
      #endregion

      #region Implementation ----------------------------------------
      /// <summary>Add the value to the end</summary>
      /// <param name="a">Value to be add</param>
      public void Add (T a) {
         CheckCapacity (mCount + 1);
         mArray[mCount] = a;
         mCount++;
      }

      /// <summary>Check the array capacity</summary>
      /// <param name="minCapacity">The minimum capacity required</param>
      private void CheckCapacity (int minCapacity) {
         if (minCapacity > mArray.Length) {
            int newCapacity = mArray.Length * 2;  // Double the capacity when needed
            if (newCapacity < minCapacity) newCapacity = minCapacity;
            Array.Resize (ref mArray, newCapacity);
         }
      }

      /// <summary>Checking the index valid or not</summary>
      /// <param name="index">Index</param>
      /// <exception cref="IndexOutOfRangeException">When the index is not in range</exception>
      private void CheckIndexRange (int index) {
         if (index < 0 || index >= mCount)
            throw new IndexOutOfRangeException ("Index is out of the valid range.");
      }

      /// <summary>Clear the elements</summary>
      public void Clear () {
         Array.Clear (mArray, 0, mCount);
         mCount = 0;
      }

      /// <summary>Display the list</summary>
      public void Display () {
         for (int i = 0; i < mCount; i++)
            Console.Write (mArray[i]);
         Console.WriteLine ();
      }

      /// <summary>Insert the value</summary>
      /// <param name="index">The index where to add</param>
      /// <param name="item">The value to be add</param>
      /// <exception cref="IndexOutOfRangeException">When the index is not in range</exception>
      public void Insert (int index, T item) {
         if (index < 0 || index > mCount)
            throw new IndexOutOfRangeException ("Index is out of the valid range.");
         CheckCapacity (mCount + 1);
         for (int i = mCount; i > index; i--)
            mArray[i] = mArray[i - 1];
         mArray[index] = item;
         mCount++;
      }

      /// <summary>Remove the value</summary>
      /// <param name="a">Value to be remove</param>
      /// <returns>Removes the value at the index</returns>
      public bool Remove (T a) {
         int index = Array.IndexOf (mArray, a);
         CheckIndexRange (index);
         for (int i = index; i < mCount - 1; i++)
            mArray[i] = mArray[i + 1];
         mCount--;
         return true;
      }

      /// <summary>Remove the value</summary>
      /// <param name="index">Index where to remove the element</param>
      public void RemoveAt (int index) {
         CheckIndexRange (index);
         T item = mArray[index];
         Remove (item);
      }
      #endregion
      #region Private data ------------------------------------------
      T[] mArray;
      int mCount;
      #endregion
   }
   #endregion
}