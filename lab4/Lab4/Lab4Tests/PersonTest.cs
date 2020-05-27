using Lab4.Persons;
using NUnit.Framework;

namespace Lab4.Tests
{
    public class PersonTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPersonGetType()
        {
            IPerson p_common = new Person(Constants.PERSON_TYPE_COMMON);
            IPerson p_police = new Person(Constants.PERSON_TYPE_POLICE);
            IPerson p_ff = new Person(Constants.PERSON_TYPE_FIREFIGHTER);

            Assert.IsTrue(p_common.GetPersonType() == Constants.PERSON_TYPE_COMMON);

            Assert.IsTrue(p_police.GetPersonType() == Constants.PERSON_TYPE_POLICE);

            Assert.IsTrue(p_ff.GetPersonType() == Constants.PERSON_TYPE_FIREFIGHTER);

        }
    }
}