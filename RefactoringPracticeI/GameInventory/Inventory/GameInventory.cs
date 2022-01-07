using RefactoringExerciseI.Constants;

namespace RefactoringExerciseI.Inventory
{
    public class GameInventory
    {
        private readonly IList<Item> _items;

        public GameInventory(IList<Item> Items)
        {
            _items = Items;
        }

        public void UpdateQuality()
        {
            for (var index = 0; index < _items.Count; index++)
            {
                ItemsQualityHandling(index);

                if (_items[index].Name != ItemConstants.Sulfuras)
                {
                    ItemDepreciation(index);
                }

                if (_items[index].SellIn < 0)
                {
                    ItemsWear(index);
                }
            }
        }

        private void ItemsQualityHandling(int index)
        {
            if (_items[index].Name != ItemConstants.AgedBrie && _items[index].Name != ItemConstants.BackstagePasses)
            {
                if (_items[index].Quality > ItemConstants.MinItemQuality && _items[index].Name != ItemConstants.Sulfuras)
                {
                    _items[index].Quality = _items[index].Quality - 1;
                }
            }
            else
            {
                if (_items[index].Quality < ItemConstants.MaxItemQuality)
                {
                    _items[index].Quality = _items[index].Quality + 1;

                    if (_items[index].Name == ItemConstants.BackstagePasses)
                    {
                        BackstagePassLogic(index);
                    }
                }
            }
        }

        private void ItemsWear(int index)
        {
            if (_items[index].Name != ItemConstants.AgedBrie)
            {
                if (_items[index].Name != ItemConstants.BackstagePasses)
                {
                    if (_items[index].Quality > ItemConstants.MinItemQuality && _items[index].Name != ItemConstants.Sulfuras)
                    {
                        _items[index].Quality = _items[index].Quality - 1;
                    }
                }
                else
                {
                    OneUseItem(index);
                }
            }
            else
            {
                HandleItemDecay(index);
            }
        }

        private void OneUseItem(int index)
        {
            _items[index].Quality = _items[index].Quality - _items[index].Quality;
        }

        private void HandleItemDecay(int index)
        {
            if (_items[index].Quality < ItemConstants.MaxItemQuality)
            {
                _items[index].Quality = _items[index].Quality + 1;
            }
        }

        private void ItemDepreciation(int index)
        {
            _items[index].SellIn = _items[index].SellIn - 1;
        }

        private void BackstagePassLogic(int index)
        {
            if (_items[index].SellIn < 11 && _items[index].Quality < ItemConstants.MaxItemQuality)
            {
                _items[index].Quality = _items[index].Quality + 1;
            }

            if (_items[index].SellIn < 6 && _items[index].Quality < ItemConstants.MaxItemQuality)
            {
                _items[index].Quality = _items[index].Quality + 1;
            }
        }
    }
}
