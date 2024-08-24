namespace csharp_concept.oops.encapsulation;

public class FootballTeam_Program
{

}

////public class Player_Program
////{
////    public string Name
////    {
////        get => name!;
////        set
////        {
////            if (string.IsNullOrWhiteSpace(value)
////                throw new ArgumentException("A name should not be empty");
////            name = value;
////        }
////    }

////    private string? name;
////    private readonly int endurance;
////    private readonly int sprint;
////    private readonly int dribble;
////    private readonly int passing;
////    private readonly int shooting;

////    public Player_Program
////        (
////        string name, int endurance, int sprint,
////        int dribble, int passing, int shooting
////        )
////    {
////        Name = name;

////        ValidateStat("Endurance", endurance);
////        ValidateStat("Endurance", sprint);
////        ValidateStat("Endurance", dribble);
////        ValidateStat("Endurance", passing);
////        ValidateStat("Endurance", shooting);

////        this.endurance = endurance;
////        this.sprint = sprint;
////        this.shooting = shooting;
////        this.passing = passing;
////        this.dribble = dribble;
////    }

////    Action<string, int> ValidateStat = (skillName, skillPoint) =>
////    {
////        if (skillPoint < 0 || skillPoint > 100)
////            throw new ArgumentOutOfRangeException($"{skillName} should be between 0 and 100;");
////    };
////}
