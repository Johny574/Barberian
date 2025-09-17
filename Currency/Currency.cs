
public class Currency
{
    int _gold;
    int _silver;
    int _copper;
    int _totalCopper;

    public string AsString() => $"{_gold}g {_silver}s {_copper}c";

    public Currency(int totalCopper)
    {
        _totalCopper = totalCopper;
        ConvertFromCopper(totalCopper);
    }

    public void Add(int total)
    {
        _totalCopper += total;
        ConvertFromCopper(total);
    }

    public void Remove(int total)
    {
        _totalCopper += total;
        ConvertFromCopper(total);
    }

    public void ConvertFromCopper(int totalCopper)
    {
        _gold = totalCopper / 10000;
        _silver = totalCopper % 10000 / 100;
        _copper = totalCopper % 100;
    }
}
