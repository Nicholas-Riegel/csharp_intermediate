// WHERE
List<int> list0 = [1, 9, 2, 6, 3];

var evenIE = list0.Where(x => x % 2 == 0);

List<int> evenList = evenIE.ToList();

evenList.Add(4);

// Console.WriteLine(string.Join(", ", evenList));

//SELECT
List<int> oneToTen = [];
oneToTen.AddRange(Enumerable.Range(1, 10));
// Console.WriteLine(string.Join(", ", oneToTen)); 
var squares = oneToTen.Select(x => Math.Pow(x, 2));
// Console.WriteLine(string.Join(", ", squares)); 

// ZIP
List<int> list1 = [1, 3, 4];
List<int> list2 = [4, 6, 8, 6];
var sumLists = list1.Zip(list2, (x, y) => x + y).ToList();
// Console.WriteLine(string.Join(", ", sumLists));

// AGGREGATES
List<double> listToSum = [1, 2, 3, 4, 5];
// Console.WriteLine(listToSum.Aggregate((a, b) => a + b));

// ALL (does every member meet a condition)
// Console.WriteLine(listToSum.All(x => x > 3));

// ANY
// Console.WriteLine(listToSum.Any(x => x > 3));

// DISTINCT (eliminate duplicates)
List<int> duplicates = [1, 1, 2, 2, 3];
// Console.WriteLine(string.Join(", ", duplicates.Distinct()));

// EXCEPT (find values in first list that are not in second)
List<int> dups0 = [4, 1];
// Console.WriteLine(string.Join(", ", duplicates.Except(dups0)));

// INTERSECT (find values in both)
Console.WriteLine(string.Join(", ", duplicates.Intersect(dups0)));
