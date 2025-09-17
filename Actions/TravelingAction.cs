
public class TravelingAction : Action
{
    Location _destination;
    Player _player;

    public TravelingAction(string name, Player player, Location destination) : base(name)
    {
        _destination = destination;
        _player = player;
    }

    public override void Complete()
    {
        _player.Location = _destination;
        Console.WriteLine("Finished traveling");
    }
}
