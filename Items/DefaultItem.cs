using System;

namespace csharp.Items
{
    public class DefaultItem : IItem
    {
        private readonly int _maxQuality = 50;
        private readonly int _minQuality = 0;
        protected readonly Item Item;
        public DefaultItem(Item item)
        {
            this.Item = item;
            Item.Quality = Item.SetQualityInRange(_maxQuality,_minQuality);
        }
        
        public void UpdateItem()
        {
            Item.SellIn -= 1;
            UpdateItemQuality();
            Item.Quality = Item.SetQualityInRange(_maxQuality,_minQuality);
        }
        
        protected virtual void UpdateItemQuality()
        {
            Item.Quality -= CalculateAdjustRate();
        }

        protected virtual int CalculateAdjustRate()
        {
            return Item.SellIn < 0 ? 2 : 1;
        }
    }
}