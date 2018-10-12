using System.Collections.Generic;

namespace GildedRose
{
    public class QualityUpdaterStrategy
    {
        private readonly Dictionary<string, IQualityUpdater> _resolver;

        public QualityUpdaterStrategy()
        {
            _resolver = new Dictionary<string, IQualityUpdater>
            {
                ["Aged Brie"] = new AgedBrieQualiyUpdater(),
                ["Backstage passes to a TAFKAL80ETC concert"] = new BackStageQualityUpdater(),
                [""] = new OrdinaryRoseQualityUpdater()
            };
        }

        public IQualityUpdater GetStrategy(string name)
        {
            if (!_resolver.ContainsKey(name))
                return _resolver[""];

            return _resolver[name];
        }
    }
}