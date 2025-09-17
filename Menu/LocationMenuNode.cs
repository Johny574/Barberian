


public class LocationMenuNode : MenuNode
{
    public LocationMenuNode(string name, Menu menu, Player player, MenuNode? previousMenu = null) : base(name, menu, player, previousMenu)
    {
    }

    public override string Description()
    {
        string s = $"You are currently at {_player.Location.Name}\n";
        s += "The following places are nearby :\n";
        foreach (var location in _player.Location.ConnectedLocations.Keys)
        {
            s += $"{location}\n";
        }
        return s;
    }

    protected override List<MenuAction> GetMenuActions()
    {
        List<MenuAction> result = new();
        foreach (var location in _player.Location.ConnectedLocations.Keys)
        {
            var action = new TravelingAction($"Travel to {location}", _player, LocationManager.Locations[location]);
            result.Add(
            new MenuAction($"Travel to {location}",
            () =>
            {
                _player.StartAction(action);
                _menu.Refresh();
            }));
        };
        return result; ;
    }
}