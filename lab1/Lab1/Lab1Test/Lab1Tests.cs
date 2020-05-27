using NUnit.Framework;

namespace Lab1.Lab1Test
{
    public class Tests
    {
        string[] mockInput;
        string[] mockOutput;

        [SetUp]
        public void Setup()
        {
            mockInput = new string[7] {
                "string one",
                "string one plus two",
                "string three plus some string",
                "string number four some extra string",
                "it's five",
                "it's five or six",
                "it's five or six or seven",
            };

            mockOutput = new string[4] {
                "string one",
                "string one plus two",
                "it's five",
                "it's five or six"
            };
        }

        [Test]
        public void TestCalculateAvarageOfSymbols()
        {
            Lab1 lab1Instance = new Lab1();
            int result = lab1Instance.CalculateAvarageOfSymbols(mockInput);
            Assert.AreEqual(result, 20);
        }

        [Test]
        public void TestGetStringMethodShouldReturnString()
        {
            Lab1 lab1Instance = new Lab1();
            string[] result = lab1Instance.getStringsLengthLessThen(20, mockInput);
            Assert.AreEqual(result, mockOutput);
        }
    }
}