using System.Xml.Linq;

namespace csharp_concept.oops.encapsulation.Model;

public class Chicken
{
    public const int MinAge = 0;
    public const int MaxAge = 15;

    private string name;
    private int age;
    private readonly string color;

    public Chicken(string name, int age, string color)
    // 1) Constructor : When you create a new instance of Chicken, the constructor is called, passing the name parameter to it.
    {
        Name = name;
        //2) Property Assignment:
        //In the constructor, Name = name; is called.
        //This means the Name property is being accessed, which in turn triggers the property’s set accessor.
        Age = age;
        Color = color;
    }
    public string Name 
    {
        //4) Get Accessor:
        get => name;
        //The get accessor simply returns the value of the private field name.

        private set
        //3) Set Accessor:
        {
            if (string.IsNullOrWhiteSpace(value)) 
                //The set accessor checks if the value is null or whitespace using string.IsNullOrWhiteSpace(value).                
                throw new ArgumentNullException(nameof(value));
                //If the value is invalid, it throws an ArgumentNullException.
            
            name = value;
            //If the value is valid, it assigns the value to the private field name.
        }
    }
    // Method to change the name from within the Chicken class
    public void ChangeName(string newName)
    {
        Name = newName;
    }

    public string Color
    {
        get => color;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value));
            color = value;
        }
    }
    public int Age
    {
        get => age;
        private set
        {
            if (value > MaxAge || value < MinAge)
                throw new ArgumentOutOfRangeException(nameof(value));
            age = value;
        }
    }
}
/*
 Key Points
    Is Name the Same as name?:
        No, Name (the property) and name (the private field) are not the same. 
        Name is a public property that provides controlled access to the private field name.

    get => name:
        This syntax is a shorthand for a read-only getter. 
        It returns the value of the private field name.

    private set { ... }:
        The private keyword restricts the setter’s access so that it can only be called within the Chicken class. 
        This means the property value can be set only from within the class, not from outside.

    Order of get and set:
        The set accessor is called when a value is assigned to the property (Name = someValue;).
        The get accessor is called when the property value is accessed (var value = Name;).
        In your case, set is called first when assigning the value, and get is called when retrieving the value.

Correctness of Your Code

Your code is correct. Here’s a summary:

    When creating a Chicken instance, the constructor sets the Name property.
    The Name property’s setter validates the value and then assigns it to the private field name.
    The Name property’s getter returns the value of the private field name.
 */