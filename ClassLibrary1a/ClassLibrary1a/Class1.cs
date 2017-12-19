using NUnit.Framework;

namespace testsol
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void CreateDuplicate_ShouldNotRaiseInsertingEventxxx()
        {
            bool eventWasRaised = true;
            Assert.IsFalse(eventWasRaised, "The CreateDuplicate method raised the Inserting event.");

        }
    }
}
