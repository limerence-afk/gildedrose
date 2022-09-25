namespace csharp.Items
{
    public class ItemFactory 
    {
        public IItem CreateItem(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    return new AgedBrieItem(item);
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackstagePassItem(item);
                case "Sulfuras, Hand of Ragnaros":
                    return new LegendaryItem(item);
                case "Conjured Mana Cake":
                    return new ConjuredItem(item);
                default:
                    return new DefaultItem(item);
            }
        }
    }
}