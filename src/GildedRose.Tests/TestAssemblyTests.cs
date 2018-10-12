using GildedRose;
using System.Collections.Generic;
using NFluent;
using Xunit;

namespace GildedRose.Tests
{
    public class TestAssemblyTests
    {
        [Fact]
        public void Backstage_sellin_negative_and_quality_less_50()
        {
            var app = new GildedRose()
            {
                Items = new List<RoseItem>
                {
                    new RoseItem {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -1, Quality = 20}
                }
            };
            app.UpdateQuality();

            Check.That(app.Items[0].Quality).IsEqualTo(0);
        }

        [Fact]
        public void OrdinaryRose_sellin_negative_and_quality_less_50()
        {
            var app = new GildedRose()
            {
                Items = new List<RoseItem>
                {
                    new RoseItem {Name = "Elixir", SellIn = -1, Quality = 20}
                }
            };
            app.UpdateQuality();

            Check.That(app.Items[0].Quality).IsEqualTo(18);
        }

        [Fact]
        public void AgedBrie_sellin_negative_and_quality_less_50()
        {
            var app = new GildedRose()
            {
                Items = new List<RoseItem>
                {
                    new RoseItem {Name = "Aged Brie", SellIn = -1, Quality = 20}
                }
            };
            app.UpdateQuality();

            Check.That(app.Items[0].Quality).IsEqualTo(22);
        }
    }
}