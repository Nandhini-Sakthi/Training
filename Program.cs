using System;
for (; ; ) {
   Console.Write ("Enter the number: ");
   int firstNum = 0, SecondNum = 1, nextNum, num;
   if (int.TryParse (Console.ReadLine (), out num)) {
      if (num < 2) {
         Console.Write ("Please Enter a number greater than two");
      } else {
         Console.Write (firstNum + " " + SecondNum + " ");
         for (int i = 2; i < num; i++) {
            nextNum = firstNum + SecondNum;
            Console.Write (nextNum + " ");
            firstNum = SecondNum;
            SecondNum = nextNum;
         }
      }
   } else Console.WriteLine ("Enter Valid number");
}





