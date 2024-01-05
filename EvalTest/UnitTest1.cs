// ------------------------------------------------------------------------------------------------
// Training ~ A training program for interns at Metamation, Batch- July 2023.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// UnitTest1.cs
// Test case for Expression Evaluator.
// ------------------------------------------------------------------------------------------------
using Eval;
namespace TestTraining;

[TestClass]
public class TestTraining {
   [TestMethod]
   public void TestParse () {
      Evaluator eval = new ();
      // Expressions with their expected results
      Dictionary<string, double> exp = new () {
       { "-10 ^ 2", 100 }, { "a = 4", 4 }, { "b = 3.5", 3.5 }, { "a + b", 7.5 }, { "asin sin 90", 90 },
       { "atan tan 45", 45 }, { "sqrt 25", 5 }, { "log 1", 0 }, { "-2 -2", -4 }, {"10/2+3", 8},
       {"(+10+3)*2", 26}, {"(a+2) * a", 24 }, {"cos 0", 1 }, {"exp 2", 7.3890560989 }, {"cos acos 0", 0},
       { "10 -2 -2", 6 }, { "---5", -5 }, {"-5+10", 5 }, { "-2-4", -6 }, { "---4+5--2+3", 6 },
       { "(2+3)*-4", -20 }, { "(2+3)*+5", 25 }, { "-4*(3+5)", -32 }, { "-4+5--8", 9 }, { "-4+5-(-8)", 9 },
       { "10^(-4+2)", .01 }, { "-10-10^2", -110 }, { "---4+5--6-2", 5 }, {"sin 45", 0.7071067812 },
       {"sin -45", -0.7071067812 }, {"-sin 45", -0.7071067812 }, { "cos 45", 0.7071067812 },
       { "cos -45", 0.7071067812 }, {"tan 45", 1.0 }, {"sin(45+45)", 1.0 }, {"(sin 90)*2", 2 },
       {"sin --90", 1.0 }, {"log 10", 2.302585093 }, { "sqrt 100", 10 }, { "sqrt(10^2)", 10 },
       { "(sqrt 100) - 10", 0 }, { "(tan 45)+10-20", -9 }, { "asin 1", 90 }, { "acos 0", 90 },
       { "(log 10)+5", 7.302585093 }, { "log(10+5)", 2.7080502011 }, { "(sin 90)--1", 2 },
       { "(sin -90)--1", 0 }, { "sqrt(90+10)", 10 }, { "sqrt(110-10)", 10 }, { "atan 1", 45 },
       { "asin -1", -90 }, { "atan -1", -45 }, { "(atan -1)+45", 0 }, { "exp 1", 2.7182818285 },
       { "exp 1-2", .7182818285 }, { "exp(2-1)", 2.7182818285 }, { "exp -1", 0.3678794412 },
       { "sqrt -100", double.NaN }, { "log(-10+5)", double.NaN } ,{ "sin(sqrt-1)",double.NaN },{ " sqrt asin-1",double.NaN }
      };
      List<string> exception = new () { "3 + * 5", "(4 + 6", "2 + abc", "6 *", "5 * (3 + 2))", "3 + 2 *" };
      foreach (var input in exp) {
         double expected = Math.Round (input.Value);
         double actual = Math.Round (eval.Evaluate (input.Key));
         Assert.AreEqual (actual, expected);
      }
      foreach (var ip in exception) Assert.ThrowsException<EvalException> (() => eval.Evaluate (ip));
   }
}