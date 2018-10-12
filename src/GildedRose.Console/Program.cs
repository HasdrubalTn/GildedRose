using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Program
    {
        public IList<Item> Items;
        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new Program()
                          {
                              Items = new List<Item>
                                          {
                                              new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                                              new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                                              new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                                              new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                                              new Item
                                                  {
                                                      Name = "Backstage passes to a TAFKAL80ETC concert",
                                                      SellIn = 15,
                                                      Quality = 20
                                                  },
                                              new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                                          }

                          };

            app.UpdateQuality();

            System.Console.ReadKey();

        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                switch (Items[i].Name)
                {
                    case "Aged Brie":
                    {
                        UpdateAgedBrieQuality(i);
                        break;
                    }
                    case "Backstage passes to a TAFKAL80ETC concert":
                    {
                        UpdateBackStageQuality(i);
                        break;
                    }
                    default:
                    {
                        UpdateOrdinaryQuality(i);
                        break;
                    }
                }
            }
        }

        private void UpdateOrdinaryQuality(int i)
        {
            Items[i].Quality = Items[i].Quality - 1;

            if (Items[i].SellIn < 0)
            {
                if (Items[i].Quality > 0)
                {
                    Items[i].Quality = Items[i].Quality - 1;
                }
            }

            Items[i].SellIn = Items[i].SellIn - 1;
        }

        private void UpdateBackStageQuality(int i)
        {
            if (Items[i].Quality < 50)
            {
                Items[i].Quality = Items[i].Quality + 1;

                if (Items[i].SellIn < 11)
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;
                    }
                }

                if (Items[i].SellIn < 6)
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;
                    }
                }

                if (Items[i].SellIn < 0)
                {
                    Items[i].Quality = Items[i].Quality - Items[i].Quality;
                }
            }

            Items[i].SellIn = Items[i].SellIn - 1;
        }

        private void UpdateAgedBrieQuality(int i)
        {
            if (Items[i].Quality < 50)
            {
                Items[i].Quality = Items[i].Quality + 1;

                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;
                    }
                }
            }

            Items[i].SellIn = Items[i].SellIn - 1;
        }
    }

    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
    }

}
