public abstract class MenuNode
{

    Dictionary<int, MenuAction> _options, _navigation;
    public string Tag;
    protected Player _player;
    protected Menu _menu;
    public MenuNode(string name, Menu menu, Player player, MenuNode? previousMenu = null)
    {
        _player = player;
        Tag = name;
        _menu = menu;
        _options = new();
        _navigation = new();
        if (previousMenu != null)
            _options[0] = new MenuAction("Return", () => menu.CurrentMenu = previousMenu);
    }

    public abstract string Description();

    public void AddNavigationAction(MenuNode node, Menu menu)
    {
        _navigation.Add(_navigation.Count + 1, new MenuAction(node.Tag, () => menu.CurrentMenu = node));
    }

    public Dictionary<int, MenuAction> MenuActions()
    {
        _options.Clear();
        _options = _navigation;

        var actions = GetMenuActions();
        foreach (var Action in actions)
        {
            _options.Add(_options.Count + 1, Action);
        }

        return _options;
    }

    protected abstract List<MenuAction> GetMenuActions();
}

public class MenuAction
{
    public string Description;
    public System.Action Action;

    public MenuAction(string description, System.Action action)
    {
        Description = description;
        Action = action;
    }
}