namespace GildedRose
{
    public class BackStageQualityUpdater : IQualityUpdater
    {
        public void UpdateQuality(RoseItem roseItem)
        {
            if (roseItem.Quality < 50)
            {
                roseItem.Quality = roseItem.Quality + 1;

                if (roseItem.SellIn < 11)
                {
                    if (roseItem.Quality < 50)
                    {
                        roseItem.Quality = roseItem.Quality + 1;
                    }
                }

                if (roseItem.SellIn < 6)
                {
                    if (roseItem.Quality < 50)
                    {
                        roseItem.Quality = roseItem.Quality + 1;
                    }
                }

                if (roseItem.SellIn < 0)
                {
                    roseItem.Quality = roseItem.Quality - roseItem.Quality;
                }
            }

            roseItem.SellIn = roseItem.SellIn - 1;
        }
    }
}