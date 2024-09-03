// CASTING
// bool boolFromString = bool.Parse("true");
// int intFromString = int.Parse("10");
// double doubleFromString = double.Parse("13.464");
// string stringFromDouble = doubleFromString.ToString();
// Console.WriteLine(stringFromDouble.GetType());
// explicit conversion loses data
// Console.WriteLine((int)doubleFromString); //= 13
// implicit conversion goes to a bigger data type
// int intNum = 3;
// long longNum = intNum;

// STRINGS
// string randoString = "This is a string.";
// Console.WriteLine("The length is: {0}", randoString.Length);
// Console.WriteLine("The string contains 'is': {0}", randoString.Contains("is"));
// Console.WriteLine("The index of 'is': {0}", randoString.IndexOf(" is") + 1);
// Console.WriteLine("Remove string: {0}", randoString.Remove(10, 6)); // does not change original string; prints out all but part removed
// Console.WriteLine("Insert string: {0}", randoString.Insert(10, "short ")); // does not change original string; 
// Console.WriteLine("Insert string: {0}", randoString.Replace("string", "sentence")); // does not change original string; 
// Console.WriteLine(randoString);
// Console.WriteLine("Compare A to a: {0}", string.Compare("ccc", "ccc", StringComparison.OrdinalIgnoreCase)); // 0 if zero characters are different; plus or minus integer if characters precede one another
// Console.WriteLine("A = a: {0}", string.Equals("A", "a", StringComparison.OrdinalIgnoreCase));

// STRINGBUILDER
// using System.Text;

// StringBuilder sb = new ("Random text");
// Console.WriteLine(sb);
// Console.WriteLine("Default size: {0}", sb.Capacity);

// StringBuilder sb2 = new ("Increasing default size to 256.", 256);
// Console.WriteLine("Default size: {0}", sb2.Capacity);
// Console.WriteLine("Length: {0}", sb2.Length);
// sb2.Append(" More important text.");
// sb2.Replace("text", "characters");
// Console.WriteLine(sb2);
// sb2.Clear();
// sb2.Append("Random text");
// Console.WriteLine(sb2);

// Console.WriteLine(sb.Equals(sb2)); //= True
// Console.WriteLine(sb == sb2); //= False !!! because these are objects, they are passed by reference

// sb2.Insert(11, " that is great!");
// Console.WriteLine(sb2);
// sb2.Remove(11, 14);
// Console.WriteLine(sb2);

// METHOD OVERLOADING
// allows methods of the same name to accept different parameters
// using basics_01;
// double result1 = MethodOverload.GetSum(2.0, 3.0); // Calls the first method
// double result2 = MethodOverload.GetSum("2.0", "3.0"); // Calls the second method
// Console.WriteLine(result1);
// Console.WriteLine(result2);

// ENUMERATED TYPES
// using basics_01;

// Console.WriteLine((int)WeekEnum.Monday);

