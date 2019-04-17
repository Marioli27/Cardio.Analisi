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
            string frequenza_Cardiaca = CardioLibrary.DataCardio.FrequenzaCardio(battiti);
            Assert.AreEqual(asp,frequenza_Cardiaca);
        }

        [TestMethod]
        public void TestFrequenza1()
        {
            int battiti = -5;
            string asp = "Impossibile";
            string frequenza_Cardiaca = CardioLibrary.DataCardio.FrequenzaCardio(battiti);
            Assert.AreEqual(asp, frequenza_Cardiaca);
        }

        [TestMethod]
        public void TestFrequenza2()
        {
            int battiti = 35;
            string asp = "Bradicardia";
            string frequenza_Cardiaca = CardioLibrary.DataCardio.FrequenzaCardio(battiti);
            Assert.AreEqual(asp, frequenza_Cardiaca);
        }

        [TestMethod]
        public void TestFrequenza3()
        {
            int battiti = 70;
            string asp = "Normale";
            string frequenza_Cardiaca = CardioLibrary.DataCardio.FrequenzaCardio(battiti);
            Assert.AreEqual(asp, frequenza_Cardiaca);
        }

        [TestMethod]
        public void TestFrequenza4()
        {
            int battiti = 120;
            string asp = "Tachicardia";
            string frequenza_Cardiaca = CardioLibrary.DataCardio.FrequenzaCardio(battiti);
            Assert.AreEqual(asp, frequenza_Cardiaca);
        }

        [TestMethod]
        public void TestCalorie()
        {
            int A = 30;
            double P = 85;
            int F = -138;
            int T = 25;
            string sesso = "donna";
            string asp = "Impossibile";

            string C = CardioLibrary.DataCardio.CalorieBruciate(A, P, F, T,sesso);
            Assert.AreEqual(C,asp);
        }

        [TestMethod]
        public void TestCalorie1()
        {
            int A = -20;
            double P = 55;
            int F = 115;
            int T = 70;
            string sesso = "donna";
            string asp = "Impossibile";

            string C = CardioLibrary.DataCardio.CalorieBruciate(A, P, F, T, sesso);
            Assert.AreEqual(C, asp);
        }

        [TestMethod]
        public void TestCalorie2()
        {
            int A = 17;
            double P = -85;
            int F = 127;
            int T = 20;
            string sesso = "donna";
            string asp = "Impossibile";

            string C = CardioLibrary.DataCardio.CalorieBruciate(A, P, F, T, sesso);
            Assert.AreEqual(C, asp);
        }

        [TestMethod]
        public void TestCalorie3()
        {
            int A = 16;
            double P = 70;
            int F = 113;
            int T = -80;
            string sesso = "donna";
            string asp = "Impossibile";

            string C = CardioLibrary.DataCardio.CalorieBruciate(A, P, F, T, sesso);
            Assert.AreEqual(C, asp);
        }

        [TestMethod]
        public void TestCalorie4()
        {
            int A = 18;
            double P = 60;
            int F = 133;
            int T = -60;
            string sesso = "uomo";
            string asp = "Impossibile";

            string C = CardioLibrary.DataCardio.CalorieBruciate(A, P, F, T, sesso);
            Assert.AreEqual(C, asp);
        }

        [TestMethod]
        public void TestCalorie5()
        {
            int A = 22;
            double P = 80;
            int F = -123;
            int T = 30;
            string sesso = "uomo";
            string asp = "Impossibile";

            string C = CardioLibrary.DataCardio.CalorieBruciate(A, P, F, T, sesso);
            Assert.AreEqual(C, asp);
        }

        [TestMethod]
        public void TestCalorie6()
        {
            int A = 50;
            double P = -85;
            int F = 124;
            int T = 65;
            string sesso = "uomo";
            string asp = "Impossibile";

            string C = CardioLibrary.DataCardio.CalorieBruciate(A, P, F, T, sesso);
            Assert.AreEqual(C, asp);
        }

        [TestMethod]
        public void TestCalorie7()
        {
            int A = -20;
            double P = 95;
            int F = 156;
            int T = 90;
            string sesso = "uomo";
            string asp = "Impossibile";

            string C = CardioLibrary.DataCardio.CalorieBruciate(A, P, F, T, sesso);
            Assert.AreEqual(C, asp);
        }

        [TestMethod]
        public void TestCalorie8()
        {
            int A = 45;
            double P = 90;
            int F = 125;
            int T = 45;
            string sesso = "donna";
            string asp = "295,638384321224";

            string C = CardioLibrary.DataCardio.CalorieBruciate(A, P, F, T, sesso);
            Assert.AreEqual(C, asp);
        }

        [TestMethod]
        public void TestCalorie9()
        {
            int A = 19;
            double P = 80;
            int F = 120;
            int T = 40;
            string sesso = "uomo";
            string asp = "81,4856596558318";

            string C = CardioLibrary.DataCardio.CalorieBruciate(A, P, F, T, sesso);
            Assert.AreEqual(C, asp);
        }

        [TestMethod]
        public void TestSpesa()
        {
            double km = -5;
            double kg = 60;
            string movimento = "corsa";
            string asp = "Impossibile";

            string spesa_energetica = CardioLibrary.DataCardio.SpesaEnergie(km, kg, movimento);
            Assert.AreEqual(asp, spesa_energetica);
        }

        [TestMethod]
        public void TestSpesa1()
        {
            double km = 3;
            double kg = -65;
            string movimento = "corsa";
            string asp = "Impossibile";

            string spesa_energetica = CardioLibrary.DataCardio.SpesaEnergie(km, kg, movimento);
            Assert.AreEqual(asp, spesa_energetica);
        }

        [TestMethod]
        public void TestSpesa2()
        {
            double km = 4;
            double kg = -70;
            string movimento = "camminata";
            string asp = "Impossibile";

            string spesa_energetica = CardioLibrary.DataCardio.SpesaEnergie(km, kg, movimento);
            Assert.AreEqual(asp, spesa_energetica);
        }

        [TestMethod]
        public void TestSpesa3()
        {
            double km = -6;
            double kg = 75;
            string movimento = "camminata";
            string asp = "Impossibile";

            string spesa_energetica = CardioLibrary.DataCardio.SpesaEnergie(km, kg, movimento);
            Assert.AreEqual(asp, spesa_energetica);
        }

        [TestMethod]
        public void TestSpesa4()
        {
            double km = 8;
            double kg = 80;
            string movimento = "corsa";
            string asp = "576";

            string spesa_energetica = CardioLibrary.DataCardio.SpesaEnergie(km, kg, movimento);
            Assert.AreEqual(asp, spesa_energetica);
        }

        [TestMethod]
        public void TestSpesa5()
        {
            double km = 2;
            double kg = 60;
            string movimento = "camminata";
            string asp = "60";

            string spesa_energetica = CardioLibrary.DataCardio.SpesaEnergie(km, kg, movimento);
            Assert.AreEqual(asp, spesa_energetica);
        }




    }
}
