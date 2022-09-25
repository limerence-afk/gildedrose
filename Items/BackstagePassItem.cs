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
            if (Item.SellIn >= 10)
            {
                return 1;
            }

            if (Item.SellIn >= 5)
            {
                return 2;
            }

            if (Item.SellIn >= 0)
            {
                return 3;
            }

            return 0;
        }

    }
}