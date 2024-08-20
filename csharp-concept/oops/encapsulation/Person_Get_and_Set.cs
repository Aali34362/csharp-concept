namespace csharp_concept.oops.encapsulation;

public static class Person_Get_and_Set_Program
{
    public static void Person_Get_and_Set_Main()
    {
        //Standard get and set
        Person_Get_and_Set person = new Person_Get_and_Set();
        person.Name = "Alice";  // Using the set accessor
        Console.WriteLine(person.Name);  // Using the get accessor

        //get with private set
        Person_Get_and_PrivateSet person1 = new Person_Get_and_PrivateSet("Alice");
        Console.WriteLine(person1.Name);  // Can read the Name property
        // person1.Name = "Bob"; // Error: The set accessor is private

        //get with init
        Person_Get_and_Init person2 = new Person_Get_and_Init { Name = "Alice" };  // Can set during initialization
        Console.WriteLine(person.Name);
        // person.Name = "Bob"; // Error: The set accessor is `init` only
    }
}

//Standard get and set
public class Person_Get_and_Set
{
    private string name;
    private string color;
    // It's a so-called auto property
    public string Name
    {
        get { return this.name; }
        //get { return name; } allows you to read the value of name.

        set { this.name = value; }
        //set { name = value; } allows you to set the value of name.
        //The keyword value represents the value being assigned.
    }
    public string Color   // This is your property
    {
        get => this.color;
        set => this.color = value;
    }
}
//get with private set
public class Person_Get_and_PrivateSet
{
    public string Name { get; private set; }
    //private set ensures that the Name property can only be assigned within the Person class.
    //Outside the class, you can only read the Name value, not modify it.
    public Person_Get_and_PrivateSet(string name)
    {
        Name = name;  // Can be set inside the class
    }

}
//get with init
public class Person_Get_and_Init
{
    public string Name { get; init; }
    //The init accessor allows the Name property to be set only when the object is being initialized
    //(e.g., in an object initializer).
    //After that, the property becomes effectively read-only.
}
