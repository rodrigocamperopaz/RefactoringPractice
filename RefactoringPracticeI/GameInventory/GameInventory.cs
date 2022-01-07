using System.Collections.Generic;

namespace RefactoringExerciseI
{
    public class GameInventory
    {
        IList<Item> _Items;
        public GameInventory(IList<Item> items)
        {
            _Items = items;
        }

        public void UpdateQuality()
        {
            for (int i = 0; i < _Items.Count; i++)
            {
                if (_Items[i].Name != "Aged Brie" && _Items[i].Name != "Backstage passes to a Pokemon Gym concert")
                {
                    if (_Items[i].Quality > 0)
                    {
                        if (_Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            _Items[i].Quality--;
                        }
                    }
                }
                else
                {
                    if (_Items[i].Quality < 50)
                    {
                        _Items[i].Quality++;

                        if (_Items[i].Name == "Backstage passes to a Pokemon Gym concert")
                        {
                            if (_Items[i].SellIn < 11 && _Items[i].Quality < 50)
                            {
                                _Items[i].Quality++;
                            }

                            if (_Items[i].SellIn < 6 && _Items[i].Quality < 50)
                            {
                                _Items[i].Quality++;
                            }
                        }
                    }
                }

                if (_Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    _Items[i].SellIn--;
                }

                if (_Items[i].SellIn < 0)
                {
                    if (_Items[i].Name != "Aged Brie")
                    {
                        if (_Items[i].Name != "Backstage passes to a Pokemon Gym concert")
                        {
                            if (_Items[i].Quality > 0)
                            {
                                if (_Items[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    _Items[i].Quality--;
                                }
                            }
                        }
                        else
                        {
                            _Items[i].Quality = 0;
                        }
                    }
                    else
                    {
                        if (_Items[i].Quality < 50)
                        {
                            _Items[i].Quality++;
                        }
                    }
                }
            }
        }
    }
}
