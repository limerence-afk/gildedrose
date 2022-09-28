using System.Collections.Generic;
using System.Linq;
using csharp.Items;

namespace csharp
{
    public class GildedRose
    {
        private readonly IEnumerable<Item> _items;
        private readonly ItemFactory _itemFactory = new ItemFactory();

        public GildedRose(IEnumerable<Item> items)
        {
            _items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                _itemFactory.CreateItem(item).UpdateItem();
            }
        }
    }
}