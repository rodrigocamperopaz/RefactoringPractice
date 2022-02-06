using NUnit.Framework;
using RefactoringExerciseI.Inventory;

namespace RefactoringExerciseI.UnitTest
{
    [TestFixture]
    public class GameInventoryTest
    {
        [Test]
        public void BackstagePasses()
        {
            // ToDo
        }

        [Test]
        public void Sulfuras()
        {
            // ToDo
        }

        [Test]
        public void AgedBrie()
        {
            // ToDo
        }

        [Test]
        public void Foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GameInventory app = new(Items);
            app.UpdateQuality();

            Assert.That(Items[0].Name, Is.EqualTo("bar"));
            Assert.That(Items[0].Quality, Is.EqualTo(5));
            Assert.That(Items[0].SellIn, Is.EqualTo(0));
        }
    }
}