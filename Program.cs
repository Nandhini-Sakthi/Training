using System;
int firstNum = 0, SecondNum = 1, nextNum, num;
Console.Write ("Enter the number: ");
num = int.Parse (Console.ReadLine ());
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
