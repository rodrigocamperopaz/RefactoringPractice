namespace RefactoringExerciseI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Here we are!");

            IList<Item> items = new List<Item> {
                new Item("+5 Dexterity Vest", 10, 20),
                new Item("Aged Brie", 2, 0),
                new Item("Elixir of the Mongoose", 5, 7),
                new Item("Sulfuras, Hand of Ragnaros", 0, 80),
                new Item("Sulfuras, Hand of Ragnaros", -1, 80),
                new Item("Backstage passes to a Pokemon Gym concert", 15, 20),
                new Item("Backstage passes to a Pokemon Gym concert", 10, 49),
                new Item("Backstage passes to a Pokemon Gym concert", 5, 49),
				new Item("Conjured Mana Cake", 3, 6)
            };

            GameInventory gameInventory = new GameInventory(items);

            for (int i = 0; i < 31; i++)
            {
                Console.WriteLine($"-------- day {i} --------");
                Console.WriteLine("name, sellIn, quality");
                for (int j = 0; j < items.Count; j++)
                {
                    Console.WriteLine(items[j]);
                }
                Console.WriteLine();
                gameInventory.UpdateQuality();
            }
        }
    }
}