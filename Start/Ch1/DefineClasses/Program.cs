// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// TODO: Create some new Rectangle objects with dimensions
Rectangle r1 = new Rectangle(10, 20);
Rectangle r2 = new Rectangle(5);
Rectangle r3 = new Rectangle(20, 30);

Console.WriteLine($"r1 area is: {r1.Area()}");
Console.WriteLine($"r2 area is: {r2.Area()}");
Console.WriteLine($"r3 area is: {r3.Area()}");

// TODO: Change the values of width and height
r1.Width = 4;
r1.Height = 6;
Console.WriteLine($"r1 area is: {r1.Area()}");

r1.BorderSize = 10;
Console.WriteLine($"r1 border size is: {r1.BorderSize}");

