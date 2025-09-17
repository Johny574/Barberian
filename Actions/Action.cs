
public abstract class Action
{
    public Action(string name)
    {
        Name = name;
    }
    public abstract void Complete();
    public string Name { get; set; }
    public float Duration { get; set; }
    public DateTime StartTime {get; set;}
}