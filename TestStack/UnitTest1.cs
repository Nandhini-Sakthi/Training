// --------------------------------------------------------------------------------------------
// Training ~ A training program for interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ------------------------------------------------------------------------
// UnitTest1.cs
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
using Training;
namespace TestStack {

   [TestClass]
   public class UnitTest1 {
      TStack<int> stack1 = new ();
      Stack<int> stack2 = new ();

      [TestMethod]
      public void TestPush () {
         stack1.Push (1);
         stack1.Push (2);
         stack1.Push (3);
         stack2.Push (1);
         stack2.Push (2);
         stack2.Push (3);
         Assert.AreEqual (stack1.Count, stack2.Count);
         stack1.Push (4);
         stack1.Push (5);
         Assert.AreEqual (8, stack1.Capacity);
      }
      [TestMethod]
      public void TestPop () {
         stack1.Push (1);
         stack1.Push (2);
         stack1.Push (3);
         stack2.Push (1);
         stack2.Push (2);
         stack2.Push (3);
         Assert.AreEqual (stack1.Pop (), stack2.Pop ());
         Assert.AreEqual (stack1.Count, stack2.Count);
         stack1.Pop ();
         stack1.Pop ();
         Assert.ThrowsException<InvalidOperationException> (() => stack1.Pop ());
      }
      [TestMethod]
      public void PeekTest () {
         stack1.Push (1);
         stack1.Push (2);
         stack1.Push (3);
         stack2.Push (1);
         stack2.Push (2);
         stack2.Push (3);
         Assert.AreEqual (stack1.Peek (), stack2.Peek ());
         Assert.AreEqual (stack1.Pop (), stack2.Pop ());
         Assert.AreEqual (stack1.Pop (), stack2.Pop ());
         Assert.AreEqual (stack1.Pop (), stack2.Pop ());
         Assert.IsTrue (stack1.IsEmpty);
         Assert.ThrowsException<InvalidOperationException> (() => stack1.Peek ());
      }
   }
}