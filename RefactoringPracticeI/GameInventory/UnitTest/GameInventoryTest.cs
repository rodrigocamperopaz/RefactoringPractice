using NUnit.Framework;
using RefactoringExerciseI.Constants;
using RefactoringExerciseI.Inventory;

namespace RefactoringExerciseI.UnitTest
{
    [TestFixture]
    public class GameInventoryTest
    {
        [Test]
        public void BackstagePasses()
        {
            IList<Item> Items = new List<Item> { new Item { Name = ItemConstants.BackstagePasses, SellIn = 0, Quality = 0 } };
            GameInventory app = new(Items);
            app.UpdateQuality();

            Assert.That(Items[0].Name, Is.EqualTo(ItemConstants.BackstagePasses));
            Assert.That(Items[0].Quality, Is.EqualTo(0));
            Assert.That(Items[0].SellIn, Is.EqualTo(-1));
        }

        [Test]
        public void Sulfuras()
        {
            IList<Item> Items = new List<Item> { new Item { Name = ItemConstants.Sulfuras, SellIn = 10, Quality = 10 } };
            GameInventory app = new(Items);
            app.UpdateQuality();

            Assert.That(Items[0].Name, Is.EqualTo(ItemConstants.Sulfuras));
            Assert.That(Items[0].Quality, Is.EqualTo(10));
            Assert.That(Items[0].SellIn, Is.EqualTo(10));
        }

        [Test]
        public void AgedBrie()
        {
            IList<Item> Items = new List<Item> { new Item { Name = ItemConstants.AgedBrie, SellIn = 5, Quality = 7 } };
            GameInventory app = new(Items);
            app.UpdateQuality();

            Assert.That(Items[0].Name, Is.EqualTo(ItemConstants.AgedBrie));
            Assert.That(Items[0].Quality, Is.EqualTo(8));
            Assert.That(Items[0].SellIn, Is.EqualTo(4));
        }

        [Test]
        public void Foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GameInventory app = new(Items);
            app.UpdateQuality();

            Assert.That(Items[0].Name, Is.EqualTo("foo"));
            Assert.That(Items[0].Quality, Is.EqualTo(0));
            Assert.That(Items[0].SellIn, Is.EqualTo(-1));
        }
    }
}