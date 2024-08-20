namespace csharp_concept.oops.encapsulation;

public static class Box_Program
{
    public static void Box_Main()
    {
        double length = double.Parse(Console.ReadLine()!);
        double width = double.Parse(Console.ReadLine()!);
        double height = double.Parse(Console.ReadLine()!);
        try
        {
            Box box = new Box(length, width, height);
            Console.WriteLine($"Surface Area - {box.SurfaceArea():f2}");
            Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():f2}");
            Console.WriteLine($"Volume - {box.Volume():f2}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

public class Box
{
    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }
    public double Length
    {
        get => length;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            length = value;
        }
    }
    public double Width
    {
        get => width;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            width = value;
        }
    }
    public double Height
    {
        get => height;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            height = value;
        }
    }

    public double SurfaceArea() => (2 * Length * Width) + (2 * Length * Height) + (2 * Width * Height);
    public double LateralSurfaceArea() => (2 * Length * Height) + (2 * Width * Height);
    public double Volume() => Length * Width * Height;
}
