namespace GildedRose
{
    public class OrdinaryRoseQualityUpdater : IQualityUpdater
    {
        public void UpdateQuality(RoseItem roseItem)
        {
            roseItem.Quality = roseItem.Quality - 1;

            if (roseItem.SellIn < 0)
            {
                if (roseItem.Quality > 0)
                {
                    roseItem.Quality = roseItem.Quality - 1;
                }
            }

            roseItem.SellIn = roseItem.SellIn - 1;
        }
    }
}