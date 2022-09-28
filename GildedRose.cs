using System.Collections.Generic;
using System.Linq;
using csharp.Items;

namespace csharp
{
    public class GildedRose
    {
        private readonly List<IItem> _items;

        
        public GildedRose(IEnumerable<Item> items)
        {
            var factory = new ItemFactory();
            _items = items.Select(item => factory.CreateItem(item)).ToList();
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                item.UpdateItem();
            }
        }
    }
}