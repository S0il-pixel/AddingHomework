namespace TestProject1 
{
    [TestClass]
    public class UnitTest1 : AddingHomework.PROJECT
    {
        [TestMethod]
        public void AdditionTest()
        {
            Random random = new Random();
            int i = random.Next(1, 1000);
            int j = random.Next(1, 1000);

            int result = Add(i, j);

            Assert.AreEqual(i + j, result);
        }

        [TestMethod]
        public void SubtractionTest()
        {
            Random rand = new Random();
            int i = rand.Next(1, 1000);
            int j = rand.Next(1, 1000);

            int result = Subtract(i, j);

            if (i > j)
            {
                Assert.AreEqual(i - j, result);
            }
            else
            {
                Assert.AreEqual(j - i, result);
            }
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            Random rand = new Random();
            int i = rand.Next(1, 1000);
            int j = rand.Next(1, 1000);

            int result = Multiplication(i, j);

            Assert.AreEqual(i * j, result);
        }

        [TestMethod]
        public void DivisionTest()
        {
            Random rand = new Random();
            int i = rand.Next(1, 1000);
            int j = rand.Next(1, 1000);

            int result = Divide(i, j);

            if (i > j)
            {
                Assert.AreEqual(i / j, result);
            }
            else { Assert.AreEqual(j / i, result); }
        }
    }
}