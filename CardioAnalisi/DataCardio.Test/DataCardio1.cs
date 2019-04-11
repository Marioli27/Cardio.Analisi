using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardioLibrary;

namespace DataCardio.Test
{
    [TestClass]
    public class DataCardio1
    {
        [TestMethod]
        public void TestBattiti()
        {
            int età = 18;
            string asp = "141,4;181,8";
            string consigliato = CardioLibrary.DataCardio.Battiti(età);
            Assert.AreEqual(asp, consigliato);
        }

        [TestMethod]
        public void TestBattiti1()
        {
            int età = 0;
            string asp = "Impossibile";
            string consigliato = CardioLibrary.DataCardio.Battiti(età);
            Assert.AreEqual(asp, consigliato);

        }

        [TestMethod]
        public void TestBattiti2()
        {
            int età = -5;
            string asp = "Impossibile";
            string consigliato = CardioLibrary.DataCardio.Battiti(età);
            Assert.AreEqual(asp, consigliato);
        }

        [TestMethod]
        public void TestFrequenza()
        {
            int battiti = 0;
            string asp = "Morto";
            string freguenza_Cardiaca = CardioLibrary.DataCardio.FrequenzaCardio(battiti);
            Assert.AreEqual(asp,freguenza_Cardiaca);
        }

        [TestMethod]
        public void TestFrequenza1()
        {
            int battiti = -5;
            string asp = "Impossibile";
            string freguenza_Cardiaca = CardioLibrary.DataCardio.FrequenzaCardio(battiti);
            Assert.AreEqual(asp, freguenza_Cardiaca);
        }

        [TestMethod]
        public void TestFrequenza2()
        {
            int battiti = 35;
            string asp = "Bradicardia";
            string freguenza_Cardiaca = CardioLibrary.DataCardio.FrequenzaCardio(battiti);
            Assert.AreEqual(asp, freguenza_Cardiaca);
        }

        [TestMethod]
        public void TestFrequenza3()
        {
            int battiti = 70;
            string asp = "Normale";
            string freguenza_Cardiaca = CardioLibrary.DataCardio.FrequenzaCardio(battiti);
            Assert.AreEqual(asp, freguenza_Cardiaca);
        }

        [TestMethod]
        public void TestFrequenza4()
        {
            int battiti = 120;
            string asp = "Tachicardia";
            string freguenza_Cardiaca = CardioLibrary.DataCardio.FrequenzaCardio(battiti);
            Assert.AreEqual(asp, freguenza_Cardiaca);
        }

        
    }
}
