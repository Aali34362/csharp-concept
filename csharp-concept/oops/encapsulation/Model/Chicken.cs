namespace csharp_concept.oops.encapsulation.Model;

public class Chicken
{
    public const int MinAge = 0;
    public const int MaxAge = 15;

    private string name;
    private int age;

    public Chicken(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public string Name 
    { 
        get => name; 
        private set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value));
            name = value;
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
