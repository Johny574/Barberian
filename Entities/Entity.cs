
public class Entity
{
    public Entity(string name)
    {
        Name = name;
        Inventory = new();
        Currency = new(0);
        XP = new();
        Stats = new();
    }

    public string Name { get; set; }
    public Inventory Inventory { get; set; }
    public Currency Currency { get; set; }
    public XP XP { get; set; }
    public Stats Stats { get; set; }
}