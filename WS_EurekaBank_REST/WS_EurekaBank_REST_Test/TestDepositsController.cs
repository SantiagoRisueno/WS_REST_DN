using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS_EurekaBank_REST.Controllers;

namespace WS_EurekaBank_REST_Test
{
    [TestClass]
    public class TestDepositsController
    {
        [TestMethod]
        public void TestRegisterDeposit()
        {
            var controller = new DepositsController();
            var request = new DepositRequest
            {
                Account = "00200002",
                Amount = 1000.00m
            };

            IHttpActionResult actionResult = controller.RegisterDeposit(request);
            var contentResult = actionResult as OkNegotiatedContentResult<string>;

            Assert.IsNotNull(contentResult);
            Assert.AreEqual("Deposit registered successfully.", contentResult.Content);
        }
    }
}
