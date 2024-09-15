using _07_generics.Classes;
using _07_generics.Structs;

string x = "5"; 
int y = 4;
Animal.GetSum(ref x, ref y);

Rectangle<int> rect1 = new(4, 5);
rect1.GetArea();