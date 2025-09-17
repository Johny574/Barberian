
public class Item
{
    public Item(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public Grade _Grade;
    public float Weight;
    int CopperPrice;
    public enum Grade
    {
        Common,
        Uncommon,
        Rare,
        Magical,
        Legendary,
        Mystic,
        Ephereal
    }
}