namespace csharp.Items
{
    public class LegendaryItem : IItem
    {
        protected readonly Item _item;
        public LegendaryItem(Item item)
        {
            _item = item;
            UpdateItem();
        }

        public void UpdateItem()
        {
            _item.Quality = 80;
        }
    }
}