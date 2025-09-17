public class Menu
{
    public MenuNode CurrentMenu;
    int inp;

    public Menu(Player player)
    {
        CurrentMenu = CreateNodes(player);
    }

    MenuNode CreateNodes(Player player)
    {
        MenuNode mainMenu = new BasicMenuNode("Main Menu", this, player);
        MenuNode fightMenu = new BasicMenuNode("Fight", this, player, mainMenu);
        mainMenu.AddNavigationAction(fightMenu, this);

        MenuNode locationMenu = new LocationMenuNode("Location", this, player, mainMenu);
        mainMenu.AddNavigationAction(locationMenu, this);


        MenuNode inventoryMenu = new BasicMenuNode("Inventory", this, player, mainMenu);
        mainMenu.AddNavigationAction(inventoryMenu, this);

        MenuNode barberianMenu = new BasicMenuNode("", this, player);
        MenuNode statisticsMenu = new BasicMenuNode("", this, player);
        MenuNode shopMenu = new BasicMenuNode("", this, player);
        MenuNode arenaMenu = new BasicMenuNode("", this, player);
        return mainMenu;
    }

    public void Run(Player player, int consoleWidth)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        // Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(System.DateTime.Now);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{player.Name}" + new string(' ', consoleWidth - player.Name.Length - player.XP.Level.ToString().Length - 1) + $"{player.XP.Level}");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{player._Class.Name}" + new string(' ', consoleWidth - player._Class.Name.Length - player.XP.Amount.ToString().Length - 1) + $"{player.XP.Amount}");
        Console.ForegroundColor = ConsoleColor.Blue;

        Console.WriteLine($"{player.Location.Name}" + new string(' ', consoleWidth - player.Location.Name.Length - player.Action.Name.Length - 1) + $"{player.Action.Name}");
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine($"{player.Inventory.Weight}lb" + new string(' ', consoleWidth - player.Inventory.Weight.ToString().Length - 2 - player.Currency.AsString().Length - 1) + $"{player.Currency.AsString()}");
        DisplayMenu(CurrentMenu);
        string? input = Console.ReadLine();

        if (input == null)
            return;

        if (!int.TryParse(input, out inp))
            return;

        // if (inp == 0 && CurrentMenu.PreviousNode != null)
        // {
        //     CurrentMenu = CurrentMenu.PreviousNode;
        //     return;
        // }

        // if (inp == CurrentMenu.Nodes.Count + 1)
        //     return;


        var actions = CurrentMenu.MenuActions();
        if (actions.ContainsKey(inp))
            actions[inp].Action.Invoke();
    }

    public void DisplayMenu(MenuNode menu)
    {

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(menu.Description());
        Console.WriteLine(new string('-', 10));

        Console.BackgroundColor = ConsoleColor.DarkGray;

        foreach (var action in menu.MenuActions())
        {
            Console.WriteLine($"{action.Key}) {action.Value.Description}");
        }
        Console.BackgroundColor = ConsoleColor.Black;
    }


    public void Refresh()
    {
        DisplayMenu(CurrentMenu);
    }
}