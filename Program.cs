using Microsoft.Extensions.Configuration;

using YetAnotherBurgerFactory;

// The appsettings is located in the root of the project not where the program is running
var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();

var burgerConfigurations = configuration.GetSection("BurgerConfigurations");

Console.WriteLine("Welcome to Yet Another Burger Factory!");


foreach (var burgerConfiguration in burgerConfigurations.GetChildren())
{
    Console.WriteLine("######################################");
    var burgerName = burgerConfiguration.Key;
    var burger = BurgerFactory.CreateBurger(burgerName);

    // Ensure we only select non-null values and provide an empty collection if the source is null
    var toppings = burgerConfiguration.GetSection("Toppings").GetChildren()
                      .Select(x => x.Value)
                      .Where(x => x != null) // Exclude any null values just in case
                      .ToList(); // ToList() to avoid multiple enumerations

    Console.WriteLine($"Creating a {burgerName} with {toppings.Count} toppings");
    if (toppings.Any())
    {
        BurgerSettingsParser.ApplyToppings(burger, toppings);
    }

    burger.Cook();

    Console.WriteLine($"{burger.Print()}");
}





