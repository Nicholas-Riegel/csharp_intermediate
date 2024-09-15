string[] dogs = ["K9", "Benji", "Lassie", "Snoopy", "Willy", "Sky", "Pippa", "Scooby Doo", "Old Yeller"];

var dogSpaces = from dog in dogs 
    where dog.Contains(" ")
    // orderby dog descending
    select dog;

Console.WriteLine(string.Join("\n", dogSpaces));

int[] nums = [5, 10, 15, 20, 25, 30, 35];

var gt20 = from num in nums
    where num > 20
    orderby num
    select num;

var listGt20 = gt20.ToList();
listGt20.Add(40);
Console.WriteLine(string.Join(", ", listGt20));

// ask chatGPT how linq works with joins