namespace GildedRose
{
    public class AgedBrieQualiyUpdater : IQualityUpdater
    {
        public void UpdateQuality(RoseItem roseItem)
        {
            if (roseItem.Quality < 50)
            {
                roseItem.Quality = roseItem.Quality + 1;

                if (roseItem.SellIn < 0)
                {
                    if (roseItem.Quality < 50)
                    {
                        roseItem.Quality = roseItem.Quality + 1;
                    }
                }
            }

            roseItem.SellIn = roseItem.SellIn - 1;
        }
    }
}