namespace csharp.Items
{
    public class BackstagePassItem : AgedBrieItem
    {
        public BackstagePassItem(Item item) : base(item)
        {
        }

        protected override void UpdateItemQuality()
        {
            if (Item.SellIn < 0)
            {
                Item.Quality = 0;
                return;
            }

            base.UpdateItemQuality();
        }

        protected override int CalcAdjustRate()
        {
            return Item.SellIn switch {
                >= 10 => 1,
                >= 5 => 2,
                >= 0 => 3,
                _ => 0
            };
        }

    }
}