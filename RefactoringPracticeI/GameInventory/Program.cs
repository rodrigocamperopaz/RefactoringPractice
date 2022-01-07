using RefactoringExerciseI.Constants;
using RefactoringExerciseI.Inventory;

namespace RefactoringExerciseI
{

    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Here we are!");

            IList<Item> Items = new List<Item>{
                new Item {Name = ItemConstants.Dexterity, SellIn = 10, Quality = 20},
                new Item {Name = ItemConstants.AgedBrie, SellIn = 2, Quality = 0},
                new Item {Name = ItemConstants.Mongoose, SellIn = 5, Quality = 7},
                new Item {Name = ItemConstants.Sulfuras, SellIn = 0, Quality = 80},
                new Item {Name = ItemConstants.Sulfuras, SellIn = -1, Quality = 80},
                new Item
                {
                    Name = ItemConstants.BackstagePasses,
                    SellIn = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = ItemConstants.BackstagePasses,
                    SellIn = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = ItemConstants.BackstagePasses,
                    SellIn = 5,
                    Quality = 49
                },
				// this conjured item does not work properly yet
				new Item {Name = ItemConstants.ConjuredManaCake, SellIn = 3, Quality = 6}
            };

            var app = new GameInventory(Items);


            for (int index = 0; index < 31; index++)
            {
                Console.WriteLine($"-------- day {index} --------");
                Console.WriteLine("name, sellIn, quality");
                for (int pivot = 0; pivot < Items.Count; pivot++)
                {
                    Console.WriteLine(Items[pivot]);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}