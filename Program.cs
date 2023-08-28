using System;
for (; ; ) {
   Console.Write ("Enter a password: ");
   string password = Console.ReadLine ();
   bool hasLength = password.Length >= 6;
   bool hasDigit = false;
   bool hasLower = false;
   bool hasUpper = false;
   bool hasSpecial = false;
   foreach (char c in password) {
      if (char.IsDigit (c))
         hasDigit = true;
      else if (char.IsLower (c))
         hasLower = true;
      else if (char.IsUpper (c))
         hasUpper = true;
      else if ("!@#$%^&*()-+".Contains (c))
         hasSpecial = true;
   }
   bool var = hasLength && hasDigit && hasLower && hasUpper && hasSpecial;
   if (var == true) Console.WriteLine ("Password is strong.");
   else {
      Console.WriteLine ("Password is not strong.");
      if (hasLength == false) Console.WriteLine ("Password should be at least 6 characters long.");
      if (hasDigit == false) Console.WriteLine ("Password should contain at least one digit.");
      if (hasLower == false) Console.WriteLine ("Password should contain at least one lowercase character.");
      if (hasUpper == false) Console.WriteLine ("Password should contain at least one uppercase character.");
      if (hasSpecial == false) Console.WriteLine ("Password should contain at least one special character (!@#$%^&*()-+).");
   }
}