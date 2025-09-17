
public class InventoryMenuNode : MenuNode
{
    public InventoryMenuNode(string name, Menu menu, Player player, MenuNode? previousMenu = null) : base(name, menu, player, previousMenu)
    {
    }

    public override string Description()
    {
        throw new NotImplementedException();
    }

    protected override List<MenuAction> GetMenuActions()
    {
        throw new NotImplementedException();
    }
}