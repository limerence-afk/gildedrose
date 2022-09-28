namespace csharp.Items
{
    public class ConjuredItem : DefaultItem
    {
        protected override int CalculateAdjustRate()
        {
            return base.CalculateAdjustRate()*2;
        }

        public ConjuredItem(Item item) : base(item)
        {
        }
    }
}