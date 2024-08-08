//////OOPS//////

///Encapsulation///

// Create a Chicken instance
using csharp_concept.oops.encapsulation.Model;

Chicken myChicken = new Chicken("Henrietta",1,"black");

// Accessing the Name property getter
Console.WriteLine(myChicken.Name); // Output: Henrietta

// Trying to change the Name property from outside the class
// Uncommenting the following line will cause a compilation error
// myChicken.Name = "Cluck"; // Error: 'Name' setter is inaccessible due to its protection level

// Changing the name through a method within the Chicken class
myChicken.ChangeName("Cluck");
Console.WriteLine(myChicken.Name); // Output: Cluck
