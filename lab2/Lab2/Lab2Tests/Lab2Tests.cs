using NUnit.Framework;

namespace Lab2.Lab2Tests
{
    public class Lab2tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestTwoPersonsAreDifferentObj()
        {
            Person inst1 = new Person("Ivan", "Solomoka", 19);
            Person inst2 = new Person("Gosha", "Gricko", 35);
            bool result = inst1.Equals(inst2);

            Assert.IsFalse(result);
        }

        [Test]
        public void TestTwoPersonsAreEqual()
        {
            Person inst1 = new Person("Ivan", "Solomoka", 35);
            Person inst2 = new Person("Ivan", "Solomoka", 35);
            bool result = inst1.Equals(inst2);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestPersonObjToJson()
        {
            Person inst = new Person("Ivan", "Solomoka", 19);
            string result = inst.ToJson();
            
            Assert.IsTrue(result is string);
            Assert.AreEqual("{\"fName\":\"Ivan\",\"sName\":\"Solomoka\",\"age\":19}", result);

        }
    }
}