namespace csharp.Items
{
    public class ItemFactory 
    {
        public IItem CreateItem(Item item)
        {
            return item.Name switch
            {
                "Aged Brie" => new AgedBrieItem(item),
                "Backstage passes to a TAFKAL80ETC concert" => new BackstagePassItem(item),
                "Sulfuras, Hand of Ragnaros" => new LegendaryItem(item),
                "Conjured Mana Cake" => new ConjuredItem(item),
                _ => new DefaultItem(item)
            };
        }
    }
}