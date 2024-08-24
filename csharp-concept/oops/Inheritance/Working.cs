namespace csharp_concept.oops.Inheritance;

public class Working
{
    private readonly IServiceClient _dmsServiceClient;
    private readonly IServiceClient _masterServiceClient;

    public Working(IEnumerable<IServiceClient> serviceClients)
    {
        _dmsServiceClient = serviceClients.OfType<DMSServiceClient>().FirstOrDefault()!;
        _masterServiceClient = serviceClients.OfType<MasterServiceClient>().FirstOrDefault()!;
    }

    public void Execute()
    {
        // Call DMS function
        _dmsServiceClient?.Post();

        // Call Master function
        _masterServiceClient?.Post();
    }
}

public interface IServiceClient
{
    void Post();
}

public class MasterServiceClient : IServiceClient
{
    public void Post()
    {
        Console.WriteLine("From master Service client");
    }
}

public class DMSServiceClient : IServiceClient
{
    public void Post()
    {
        Console.WriteLine("From DMS Service client");
    }
}
