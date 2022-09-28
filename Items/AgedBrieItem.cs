namespace csharp.Items
{
    public class AgedBrieItem : DefaultItem
    {
        protected override void UpdateItemQuality()
        {
            Item.Quality += CalculateAdjustRate(); 
        }

        public AgedBrieItem(Item item) : base(item)
        {
        }
    }
}