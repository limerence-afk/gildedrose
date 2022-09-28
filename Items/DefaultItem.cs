using System;

namespace csharp.Items
{
    public class DefaultItem : IItem
    {
        protected int maxQuality = 50;
        protected int minQuality = 0;
        protected readonly Item Item;
        public DefaultItem(Item item)
        {
            this.Item = item;
            Item.Quality = Item.CheckQualityAndSetInRange(maxQuality,minQuality);
        }
        
        public void UpdateItem()
        {
            Item.SellIn -= 1;
            UpdateItemQuality();
            Item.Quality = Item.CheckQualityAndSetInRange(maxQuality,minQuality);
        }
        
        protected virtual void UpdateItemQuality()
        {
            Item.Quality -= CalcAdjustRate();
        }

        protected virtual int CalcAdjustRate()
        {
            return Item.SellIn < 0 ? 2 : 1;
        }
    }
}