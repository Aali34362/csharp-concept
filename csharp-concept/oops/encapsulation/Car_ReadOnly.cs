namespace csharp_concept.oops.encapsulation;

public static class Car_ReadOnlyProgram
{
    public static void Car_ReadOnlyMain()
    {
        // Create a new Car object with model and manufacturing date set at runtime
        Car_ReadOnly car = new Car_ReadOnly("Tesla Model S", new DateTime(2023, 1, 15));

        // Display the car's information
        car.DisplayInfo();

        // Attempting to modify the readonly field (uncommenting the following line will cause a compilation error)
        // car.model = "Tesla Model X"; // Error: Cannot assign to 'model' because it is readonly

        // Similarly, you can't modify the manufacturingDate once set
        // car.manufacturingDate = DateTime.Now; // Error: Cannot assign to 'manufacturingDate' because it is readonly
    }
}

public class Car_ReadOnly
{
    // Declare a readonly field
    private readonly string model;
    private readonly DateTime manufacturingDate;

    // Constructor that sets the readonly fields
    public Car_ReadOnly(string model, DateTime manufacturingDate)
    {
        this.model = model;
        this.manufacturingDate = manufacturingDate;
    }

    // Public property to access the model
    public string Model => model;

    // Public property to access the manufacturing date
    public DateTime ManufacturingDate => manufacturingDate;

    public void DisplayInfo()
    {
        Console.WriteLine($"Car Model: {Model}, Manufacturing Date: {ManufacturingDate.ToShortDateString()}");
    }
}
