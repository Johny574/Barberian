
public class Player : Entity
{
    public Class _Class { get; set; }
    public Location Location { get; set; }
    public Action Action { get; set; }
    public Gear Gear { get; set; }
    public DateTime Time { get; set; }

    public Player(string name) : base(name)
    {
        _Class = new();
        Location = LocationManager.Locations["Aerenthal"];
        Gear = new();
        Action = new IdleAction("Idle");
    }

    public void StartAction(Action action)
    {
        Action = action;
    }
}