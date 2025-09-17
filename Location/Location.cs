
public class Location
{
    public string Name { get; set; }
    public Dictionary<string, float> ConnectedLocations;

    public Location(string name, Dictionary<string, float> connectedLocations)
    {
        Name = name;
        ConnectedLocations = connectedLocations;
    }
}