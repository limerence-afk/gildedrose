namespace csharp.Items
{
    public class ConjuredItem : DefaultItem
    {
        protected override int CalcAdjustRate()
        {
            return base.CalcAdjustRate()*2;
        }

        public ConjuredItem(Item item) : base(item)
        {
        }
    }
}