using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS_EurekaBank_REST.Models;
using WS_EurekaBank_REST.Services;

namespace WS_EurekaBank_REST_Test
{
    [TestClass]
    public class TestMovementService
    {
        [TestMethod]
        public void TestGetMovements()
        {
            var service = new MovementService();
            List<Movimiento> movements = service.GetMovementsByClient("00200002");
            Assert.IsTrue(movements.Count > 0, "No se encontraron movimientos.");
        }
    }
}
