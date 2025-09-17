
public class TrainingAction : Action
{
    public float XPReward;
    public Location Location;

    public TrainingAction(string name, Location location) : base(name)
    {
        Location = location;
    }

    public override void Complete()
    {
        throw new NotImplementedException();
    }
};
