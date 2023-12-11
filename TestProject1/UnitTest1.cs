using Training;
namespace TestProject {
   [TestClass]
   public class UnitTest1 {
      [TestMethod]
      public void DoubleParseValid () {
         string[] test = { "123", "-123", "123.45", "-123.45", "+123.45e45", "-123.45e-45", "123e-45", ".45e3", "123.", "4.e45", "34.4E3",
            "1-23", "-12-3.45e3", "123.-4e4", "123.45e3.6", "e24", "shr", "123.g", "123e", "123+", "123-", "+-98","12e3","-123.-98" ,".e- ","-e+"};
         foreach (var doubles in test) {
            double.TryParse (doubles, out double result1);
            MyParse.TryParse (doubles, out double result);
            Assert.AreEqual (result1, result);
         }
      }
      [TestMethod]
      public void DoubleParseInvalid () {
         string[] tests = { "1-23", "-12-3.45e3", "123.-4e4", "123.45e3.6", "e24", "shr", "123.g", "123e", "123+", "123-", "+-98","14.54e-7-6","22e45e4","12.45.65","-55-6","t56" };
         foreach (var doubles in tests) Assert.AreEqual (MyParse.TryParse (doubles, out double result), false);
      }
   }
}