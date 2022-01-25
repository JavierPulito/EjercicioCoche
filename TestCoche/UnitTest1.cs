using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioCoche;

namespace TestCoche
{
    public class UnitTest1
    {
        private Rueda rueda1;
        private Motor motor1;

        [TestInitialize]
        public void SetUp()
        {
            this.rueda1 = new Rueda(true);
            this.motor1 = new Motor(true);
        }
        [TestMethod]
        public void TestArrancar()
        {

            motor1.Arrancar();

            Assert.IsTrue(motor1.estado);

        }

        [TestMethod]
        public void TestApagar()
        {

            motor1.Apagar();

            Assert.IsFalse(motor1.estado);

        }

        [TestMethod]
        public void TestRodar()
        {

            rueda1.Rodar();

            Assert.IsTrue(rueda1.rueda.movimiento);

        }

        [TestMethod]
        public void TestParar()
        {

            rueda1.Parar();

            Assert.IsTrue(rueda1.rueda.movimiento);

        }
    }
}
