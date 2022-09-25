using System;

namespace csharp.Items
{
    public class DefaultItem : IItem
    {
        protected readonly Item Item;
        public DefaultItem(Item item)
        {
            this.Item = item;
            MinOrMaxQuality();
        }
        
        protected int MaxQuality = 50;

        public void UpdateItem()
        {
            UpdateItemSellIn();
            UpdateItemQuality();
            MinOrMaxQuality();
        }

        private void MinOrMaxQuality()
        {
            Item.Quality = Math.Min(MaxQuality, Math.Max(0, Item.Quality));
        }

        protected virtual void UpdateItemSellIn()
        {
            Item.SellIn -= 1;
        }
        
        protected virtual void UpdateItemQuality()
        {
            Item.Quality -= CalcAdjustRate();
        }

        protected virtual int CalcAdjustRate()
        {
            if (Item.SellIn < 0)
            {
                return 2;
            }

            return 1;
        }
    }
}