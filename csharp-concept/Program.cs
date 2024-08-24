////using csharp_concept.oops.encapsulation;
////using csharp_concept.oops.Inheritance;
////using Microsoft.Extensions.Configuration;
////using Microsoft.Extensions.DependencyInjection;
////using Microsoft.Extensions.Hosting;
////using Microsoft.Extensions.Logging;

///////Encapsulation///
////public class Program
////{
////    private static void Main(string[] args)
////    {
////        var host = CreateHostBuilder(args).Build();

////        // Resolve the App service and call its Run method
////        var app = host.Services.GetRequiredService<App>();
////        app.Run();

////        host.Run();
////    }
////    public static IHostBuilder CreateHostBuilder(string[] args) =>
////            Host.CreateDefaultBuilder(args)
////                .ConfigureAppConfiguration((hostingContext, config) =>
////                {
////                    var env = hostingContext.HostingEnvironment;
////                    ////config.SetBasePath(env.ContentRootPath)
////                    ////      .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
////                    ////      .AddEnvironmentVariables();
////                })
////                .ConfigureServices((context, services) =>
////                {
////                    services.AddSingleton<App>();
////                    services.AddTransient<IServiceClient, MasterServiceClient>();
////                    services.AddTransient<IServiceClient, DMSServiceClient>();
////                    ////services.AddSingleton<UserOperations>();
////                    ////services.AddTransient<IMongoRepository, MongoRepository>();
////                    ////services.AddTransient<ILockService, LockService>();
////                    ////services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
////                    ////var mongoDbConfig = context.Configuration.GetSection("MongoDbConfiguration").Get<MongoDbConfiguration>();
////                    ////services.AddSingleton(mongoDbConfig);

////                    ////services.AddMongoDBServices();
////                });
////}
////public class App(ILogger<App> logger/*, UserOperations userOperations, MongoDbConfiguration mongoDbConfig*/)
////{
////    private readonly ILogger<App> _logger = logger;
////    ////private readonly UserOperations _userOperations = userOperations;
////    ////private readonly MongoDbConfiguration _mongoDbConfig = mongoDbConfig;

////    public async void Run()
////    {
////        // Application logic here
////        //_logger.LogInformation("Console app running with MongoDB connection string: {ConnectionString}", _mongoDbConfig.ConnectionString);
////        Console.WriteLine("Console app running...");

////        //////OOPS//////
////        ///Encapsulation
////        ChickenProgram.ChickenMain();

////        Box_Program.Box_Main();

////        Car_ReadOnlyProgram.Car_ReadOnlyMain();

////        Person_Get_and_Set_Program.Person_Get_and_Set_Main();

////        PasswordManager_OnlySetter_Program.PasswordManager_OnlySetter_Main();


////        ///Interface

////    }
////}



using csharp_concept.oops.encapsulation;
using csharp_concept.oops.Inheritance;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();
// Register services
serviceCollection.AddSingleton<IServiceClient, MasterServiceClient>();
serviceCollection.AddSingleton<IServiceClient, DMSServiceClient>();
serviceCollection.AddSingleton<Working>();
// Build the service provider
var serviceProvider = serviceCollection.BuildServiceProvider();


//////OOPS//////
///Encapsulation
//ChickenProgram.ChickenMain();
//Car_ReadOnlyProgram.Car_ReadOnlyMain();
//Person_Get_and_Set_Program.Person_Get_and_Set_Main();
//PasswordManager_OnlySetter_Program.PasswordManager_OnlySetter_Main();


///Interface
// Resolve the Working class and call Execute
var working = serviceProvider.GetService<Working>();
working.Execute();