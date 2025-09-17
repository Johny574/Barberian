
public class ItemStack
{
    public Item item { get; set; }
    public int Count { get; set; }

    public ItemStack(Item item)
    {
        this.item = item;
        Count = 1;
    }

    public void Update(int amount)
    {
        Count += amount;
    }
}