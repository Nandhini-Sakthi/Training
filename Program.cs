// --------------------------------------------------------------------------------------------
// Training ~ A training program for interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// MYLIST<T> 
// Implement a custom MyList<T> class using arrays as the underlying data structure.
// --------------------------------------------------------------------------------------------
using System;
// Test cases
MyList<int> list = new ();
list.Add (1);
list.Add (2);
list.Add (3);
list.Add (4);
list.Add (5);
list.Add (6);
list.Add (7);
list.Display ();
list.Remove (7);
list.Clear ();
list.Display ();
list.Insert (0, 1);
list.Insert (1, 2);
list.Insert (2, 3);
list.Insert (3, 4);
list.Insert (4, 5);
list.Insert (5, 6);
list.Display ();
list.RemoveAt (0);
list.RemoveAt (1);
list.Display ();


/// <summary> Create a class  </summary>
/// <typeparam name="T"> Datatype of the list </typeparam>
public class MyList<T> {
   private T[] mArray;
   private int mCount;

   /// <summary> Creating a Constructor for initializing the values </summary>
   public MyList () {
      // Initialize the array capacity as 4. 
      mArray = new T[4];
      mCount = 0;
   }
   /// <summary> Counting the elememt in the list </summary>
   public int Count => mCount;

   /// <summary> Calculating capacity of the array </summary>
   public int Capacity => mArray.Length;

   /// <summary> Set and return the value based on the index </summary>
   /// <param name="index"> Index to be change </param>
   /// <returns> Changed value of the index  </returns>
   /// <exception cref="IndexOutOfRangeException"> When the index is out of range </exception>
   public T this[int index] {
      get {
         if (index < 0 || index >= mCount) throw new IndexOutOfRangeException ("Index is out of the valid range.");
         return mArray[index];
      }
      set {
         if (index < 0 || index >= mCount) throw new IndexOutOfRangeException ("Index is out of the valid range.");
         mArray[index] = value;
      }
   }
   /// <summary> Add the value to the end </summary>
   /// <param name="a"> Value to be add </param>
   public void Add (T a) {
      if (mCount == mArray.Length) Array.Resize (ref mArray, mArray.Length * 2); // Double the capacity when needed
      mArray[mCount] = a;
      mCount++;
   }
   /// <summary> Remove the value </summary>
   /// <param name="a"> Value to be remove </param>
   /// <returns> True </returns>
   /// <exception cref="InvalidOperationException"> When the index is out of range </exception>
   public bool Remove (T a) {
      int index = Array.IndexOf (mArray, a);
      if (index < 0)
         throw new InvalidOperationException ("Item not found in the list.");
      for (int i = index; i < mCount - 1; i++)
         mArray[i] = mArray[i + 1];
      mCount--;
      return true;
   }
   /// <summary> Clear the elements </summary>
   public void Clear () {
      Array.Clear (mArray, 0, mCount);
      mCount = 0;
   }
   /// <summary> Insert the value  </summary>
   /// <param name="index"> The index where to add </param>
   /// <param name="item"> The value to be add </param>
   /// <exception cref="IndexOutOfRangeException"> When the index is not in range </exception>
   public void Insert (int index, T item) {
      if (index < 0 || index > mCount)
         throw new IndexOutOfRangeException ("Index is out of the valid range.");
      if (mCount == mArray.Length)
         Array.Resize (ref mArray, mArray.Length * 2);
      for (int i = mCount; i > index; i--)
         mArray[i] = mArray[i - 1];
      mArray[index] = item;
      mCount++;
   }
   /// <summary> Remove the value </summary>
   /// <param name="index"> Index where to remove the element </param>
   /// <exception cref="IndexOutOfRangeException"> When the index is not in range </exception>
   public void RemoveAt (int index) {
      if (index < 0 || index >= mCount)
         throw new IndexOutOfRangeException ("Index is out of the valid range.");
      for (int i = index; i < mCount - 1; i++)
         mArray[i] = mArray[i + 1];
      mCount--;
   }
   /// <summary> Display the list </summary>
   public void Display () {
      for (int i = 0; i < mCount; i++)
         Console.Write (mArray[i]);
      Console.WriteLine ();
   }
}