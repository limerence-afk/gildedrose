namespace csharp.Items
{
    public class AgedBrieItem : DefaultItem
    {
        protected override void UpdateItemQuality()
        {
            Item.Quality += CalcAdjustRate(); 
        }

        public AgedBrieItem(Item item) : base(item)
        {
        }
    }
}