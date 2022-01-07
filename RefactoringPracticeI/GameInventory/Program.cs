using RefactoringExerciseI.Constants;
using RefactoringExerciseI.Inventory;

namespace RefactoringExerciseI
{
#pragma warning disable S1118 // Utility classes should not have public constructors
    public class Program
#pragma warning restore S1118 // Utility classes should not have public constructors
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


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j]);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}