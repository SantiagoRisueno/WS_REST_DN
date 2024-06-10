using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS_EurekaBank_REST.Models;

namespace WS_EurekaBank_REST_Test
{
    [TestClass]
    public class TestDatabaseConnection
    {
        [TestMethod]
        public void TestConnection()
        {
            try
            {
                using (var db = new EUREKABANKEntities())
                {
                    Assert.IsNotNull(db.Database.Connection);
                    Console.WriteLine("Conexión exitosa.");
                }
            }
            catch (Exception ex)
            {
                Assert.Fail("Error al conectar a la base de datos: " + ex.Message);
            }
        }
    }
}
