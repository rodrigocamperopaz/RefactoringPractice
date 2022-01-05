using NUnit.Framework;

namespace RefactoringExerciseI
{
    [TestFixture]
    public class GameInventoryTest
    {
        [Test]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GameInventory app = new GameInventory(Items);
            app.UpdateQuality();
            Assert.AreEqual("fixme", Items[0].Name);
        }
    }
}