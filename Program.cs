


using System.Data;
using System.Data.Common;
public static class Program
{
    // static Player _player = new();
    // static Menu _menu = new();
    public static void Main(string[] args)
    {
        Player _player = new Player("abcs");
        Menu _menu = new Menu(_player);
        _player.Time = DateTime.Now;

        LocationManager.Setup();
        try
        {
            Player? save = Serializer.LoadFile<Player>("player.json");
            if (save != null)
                _player = save;
        }
        catch
        {

        }

       int width = 60;

        Console.CancelKeyPress += (sender, e) =>
        {
            Serializer.SaveFile(_player, "player.json");
            Console.BackgroundColor = ConsoleColor.Black;
        };
        AppDomain.CurrentDomain.ProcessExit += (sender, e) =>
        {
            Serializer.SaveFile(_player, "player.json");
            Console.BackgroundColor = ConsoleColor.Black;
        };

        while (true)
        {
            if (_player.Action != null && _player.Action.GetType() != typeof(IdleAction) && DateTime.Now > _player.Action.StartTime.AddMinutes(_player.Action.Duration))
            {
                _player.Action.Complete();   
            }
                    
            _menu.Run(_player, width);
        }
    }
}