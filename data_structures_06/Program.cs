// LISTS
using System.Collections;

List<dynamic> list0 = ["a", 1, false];
list0.Add("Bob");

// Console.WriteLine("Count: {0}", list0.Count);
// Console.WriteLine("Capacity: {0}", list0.Capacity);
// Console.WriteLine(string.Join(", ", list0));

List<object> list1 = [];
list1.AddRange(["Mike", "Sally", "Jane"]);
list1.Sort();
list1.Reverse();
list1.Insert(1, "Turkey");
list1.Remove("Jane");
// list1.RemoveAt(0); // remove from beginning
list1.RemoveAt(list1.Count -1); // remove from end
// list1.RemoveRange(0, 1);
// Console.WriteLine(string.Join(", ", list1.ToArray()));
// Console.WriteLine("Index of Turkey: {0}", list1.IndexOf("Turkey", 0)); // 0: starting at...
/*
Use .Add() when working with mutable collections where you want to modify the existing collection by adding an element.
Use .Append() when working with IEnumerable<T> where you want to create a new sequence with an additional element without modifying the original sequence.
*/

// DICTIONARIES
Dictionary<string, string> superheroes = new()
{
    { "Clark Kent", "Superman" },
    { "Bruce Wayne", "Batman" }
};
superheroes.Add("Peter Parker", "Spiderman");
// superheroes.Remove("Bruce Wayne");
// Console.WriteLine(superheroes.Count);
// Console.WriteLine(superheroes.ContainsKey("Clark Kent"));
// superheroes.TryGetValue("Clark Kent", out string? val);
// Console.WriteLine(val);
// Console.WriteLine(string.Join("\n", superheroes.Select(kvp => $"{kvp.Key} : {kvp.Value}")));

// QUEUES (fist in first out FIFO)
// queues are fifo
Queue<dynamic> queue = new();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
// Console.WriteLine(queue.Contains(3)); // true
// Console.WriteLine(queue.Peek()); // shows first element
// Console.WriteLine(queue.Dequeue()); // removes first
// Console.WriteLine(string.Join(", ", queue));
List<dynamic> list3 = queue.ToList();
List<dynamic> list4 = [.. queue];
// queue.Clear();

// STACKS (last in first out LIFO)
Stack stack0 = new();
stack0.Push(1);
stack0.Push(2);
stack0.Push(3);
// Console.WriteLine(stack0.Peek());
// Console.WriteLine(stack0.Contains(2));
// Console.WriteLine(stack0.Pop());
// Console.WriteLine(string.Join(", ", stack0.ToArray()));
