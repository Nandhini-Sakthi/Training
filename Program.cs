using System;
int n = new Random ().Next (1, 101);
int g;
for (; ; ) {
   Console.Write ("Enter your guess:");
   g = int.Parse (Console.ReadLine ());
   if (g > n)
      Console.WriteLine ("Your guess is too high.");

   else if (g < n)
      Console.WriteLine ("Your guess is too low.");

   else {
      Console.WriteLine ("Your guessed correctly.");
      break;
   }
}
   








