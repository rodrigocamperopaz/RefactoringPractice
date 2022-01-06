using System.Collections.Generic;

namespace RefactoringExerciseI
{
    public class GameInventory
    {
        private IList<Item> _items;
        public GameInventory(IList<Item> items)
        {
            _items = items;
        }

        public void UpdateQuality()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Name != "Aged Brie" && _items[i].Name != "Backstage passes to a Pokemon Gym concert")
                {
                    if (_items[i].Quality > 0)
                    {
                        if (_items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            _items[i].Quality--;
                        }
                    }
                }
                else
                {
                    if (_items[i].Quality < 50)
                    {
                        _items[i].Quality++;

                        if (_items[i].SellIn < 11)
                        {
                            _items[i].Quality++;
                        }

                        if (_items[i].SellIn < 6)
                        {
                            _items[i].Quality++;
                        }
                    }
                }

                if (_items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    _items[i].SellIn--;
                }

                if (_items[i].SellIn < 0)
                {
                    if (_items[i].Name != "Aged Brie")
                    {
                        if (_items[i].Name != "Backstage passes to a Pokemon Gym concert")
                        {
                            if (_items[i].Quality > 0)
                            {
                                if (_items[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    _items[i].Quality--;
                                }
                            }
                        }
                        else
                        {
                            _items[i].Quality = 0;
                        }
                    }
                    else
                    {
                        if (_items[i].Quality < 50)
                        {
                            _items[i].Quality++;
                        }
                    }
                }
            }
        }
    }
}
