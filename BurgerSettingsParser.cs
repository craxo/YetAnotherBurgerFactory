using YetAnotherBurgerFactory;

public static class BurgerSettingsParser
{
    private static readonly Dictionary<string, Action<Burger>> toppingActions = new Dictionary<string, Action<Burger>>
    {
        { "bun", burger => burger.AddBun() },
        { "tomato", burger => burger.AddTomato() },
        { "lettuce", burger => burger.AddLettuce() },
        { "cheese", burger => burger.AddCheese() },
        { "onion", burger => burger.AddOnion() },
        { "paddy", burger => burger.AddPaddy() },
        { "mushroom", burger => burger.AddMushroom() }
    };

    public static Burger ApplyToppings(Burger burger, IEnumerable<string?>? toppings)
    {
        if (toppings == null)
        {
            return burger;
        }

        foreach (var topping in toppings)
        {
            if (topping == null)
            {
                continue;
            }

            if (toppingActions.TryGetValue(topping.ToLower(), out var action))
            {
                action(burger);
            }
            else
            {
                Console.WriteLine($"Unknown topping: {topping}");
            }
        }

        return burger;
    }
}