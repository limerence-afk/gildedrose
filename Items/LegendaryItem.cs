namespace csharp.Items
{
    public class LegendaryItem : DefaultItem
    {
        public LegendaryItem(Item item) : base(item)
        {
            Item.Quality = 80;
            this.MaxQuality = 80;
        }

        protected override void UpdateItemQuality()
        {
            Item.Quality = 80;
        }

        protected override void UpdateItemSellIn()
        {
            
        }

        protected override int CalcAdjustRate()
        {
            return 0;
        }
    }
}