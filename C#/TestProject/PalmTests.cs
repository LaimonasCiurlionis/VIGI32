using Topic_8_Library_OOP;

namespace TestProject
{
    public class PalmTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SkaiciuotiPalmesVaisiuKieki_KaiPalmesAmzius6_VaisiuSkaicius18()
        {
            //ARRANGE & ACT
            Palme palme = SkaiciuotiPalmesAmziu(6);

            //ASSERT
            int expected = 18;
            Assert.AreEqual(expected, palme.VaisiuKiekis);
        }

        [Test]
        public void SkaiciuotiPalmesVaisiuKieki_KaiPalmesAmzius3_VaisiuSkaicius0() 
        {
            //ARRANGE & ACT
            Palme palme = SkaiciuotiPalmesAmziu(3);

            //ASSERT
            Assert.Zero(palme.VaisiuKiekis);
        }

        [Test]
        public void SkaiciuotiPalmesAmziu_KaiPalmesAmzius14_PalmesAmzius0()
        {
            //ARRANGE & ACT
            Palme palme = SkaiciuotiPalmesAmziu(14);

            //ASSERT
            Assert.Zero(palme.Amzius);
        }

        private Palme SkaiciuotiPalmesAmziu(int amzius) 
        {
            Palme palme = new Palme();

            for (int i = 0; i < amzius; i++)
            {
                palme.Prideti1MenAmziaus();
            }

            return palme;
        }
    }
}