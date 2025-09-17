


public class BasicMenuNode : MenuNode
{
    public BasicMenuNode(string name, Menu menu, Player player, MenuNode? previousMenu = null) : base(name, menu, player, previousMenu)
    {
    }

    public override string Description()
    {
        return "";
    }

    protected override List<MenuAction> GetMenuActions()
    {
        return new();
    }
}