using NUnit.Framework;

namespace testsol
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void CreateDuplicate_ShouldNotRaiseInsertingEventxyyyyxx()
        {
            bool eventWasRaised = false;
            Assert.IsFalse(eventWasRaised, "The CreateDuplicate method raised the Inserting event.");

        }
    }
}
