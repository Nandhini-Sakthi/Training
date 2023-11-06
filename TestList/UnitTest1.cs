// --------------------------------------------------------------------------------------------
// Training ~ A training program for interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ------------------------------------------------------------------------
// Program.cs
// MYLIST<T> 
// Implement a custom MyList<T> class using arrays as the underlying data structure.
// --------------------------------------------------------------------------------------------
using Training;
namespace LIST {
   [TestClass]
   public class UnitTest1 {
      MyList<int> list = new ();
      [TestMethod]
      public void TestAdd () {
         for (int i = 1; i <= 5; i++) list.Add (i);
         Assert.AreEqual (5, list.Count);
         Assert.AreEqual (8, list.Capacity);
         list[1] = 4;
         list.Display ();
      }
      [TestMethod]
      public void TestRemove () {
         for (int i = 1; i <= 7; i++) list.Add (i);
         list.Remove (4);
         list.Remove (5);
         list.Remove (6);
         Assert.AreEqual (4, list.Count);
         Assert.AreEqual (7, list[3]);
         Assert.ThrowsException<InvalidOperationException> (() => list.Remove (10));
      }
      [TestMethod]
      public void TestClear () {
         for (int i = 1; i <= 7; i++) list.Add (i);
         list.Clear ();
         Assert.AreEqual (0, list.Count);
      }
      [TestMethod]
      public void TestInsert () {
         for (int i = 1; i <= 4; i++) list.Add (i);
         list.Insert (2, 8);
         Assert.AreEqual (5, list.Count);
         Assert.AreEqual (8, list.Capacity);
         Assert.AreEqual (3, list[3]);
         Assert.ThrowsException<IndexOutOfRangeException> (() => list.Insert (8, 9));
         Assert.ThrowsException<IndexOutOfRangeException> (() => list.Insert (-2, 9));
      }
      [TestMethod]
      public void TestRemoveAt () {
         for (int i = 1; i <= 5; i++) list.Add (i);
         list.RemoveAt (0);
         Assert.AreEqual (4, list.Count);
         list.RemoveAt (1);
         Assert.AreEqual (3, list.Count);
         Assert.ThrowsException<IndexOutOfRangeException> (() => list.RemoveAt (10));
         Assert.ThrowsException<IndexOutOfRangeException> (() => list.RemoveAt (-2));

      }
   }
}