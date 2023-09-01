using System;

class Program {
   static void Main () {
      Random random = new Random ();
      int[] numbers = new int[10];
      int i;

      for ( i = 0; i < numbers.Length; i++)
         numbers[i] = random.Next (1, 10);

      Console.WriteLine ("Original: " + string.Join (" ", numbers));

      Console.Write ("Enter two indices to swap (e.g., 2 3): ");
      string[] input = Console.ReadLine ().Split ();

      if (input.Length == 2 && int.TryParse (input[0], out  i) && int.TryParse (input[1], out int j) && i >= 0 && i < numbers.Length && j >= 0 && j < numbers.Length) {
         int temp = numbers[i];
         numbers[i] = numbers[j];
         numbers[j] = temp;

         Console.WriteLine ("Swapped: " + string.Join (" ", numbers));
      } else {
         Console.WriteLine ("Invalid input or indices.");
      }
   }
}
