using System;
for(; ; ) { 
Console.Write("Enter the number:");
if (int.TryParse (Console.ReadLine (), out int n)) {
   for (int i = 1; i <= 10; i++)
      Console.Write ("{0} X {1,2}  = {2} \n", n, i, n * i);
} else Console.WriteLine ("Enter valid number");
}
   