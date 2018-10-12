using GildedRose;
using System.Collections.Generic;

namespace GildedRose
{
    public class GildedRose
    {
        public IList<RoseItem> Items;

        public void UpdateQuality()
        {
            var strategyResolver = new QualityUpdaterStrategy();

            foreach (var item in Items)
            {
                strategyResolver.GetStrategy(item.Name).UpdateQuality(item);
            }
        }
    }

    public class RoseItem
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
    }

}
