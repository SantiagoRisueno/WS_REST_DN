using System;
using System.Linq;
using System.Web.Http;
using WS_EurekaBank_REST.Models;

namespace WS_EurekaBank_REST.Controllers
{
    [RoutePrefix("api/importe")]
    public class DepositsController : ApiController
    {
        // POST api/importe
        [HttpPost]
        [Route("")]
        public IHttpActionResult RegisterDeposit([FromBody] DepositRequest request)
        {
            using (var db = new EUREKABANKEntities())
            {
                int maxMoviNumero = db.Movimiento
                                      .Where(m => m.chr_cuencodigo == request.Account)
                                      .Max(m => (int?)m.int_movinumero) ?? 0;

                var deposit = new Movimiento
                {
                    chr_cuencodigo = request.Account,
                    int_movinumero = maxMoviNumero + 1, // Genera un valor único
                    dec_moviimporte = request.Amount,
                    dtt_movifecha = DateTime.Now,
                    chr_emplcodigo = "0001", // Proporciona un valor adecuado
                    chr_tipocodigo = "001", // Proporciona un valor adecuado o dinámico
                    // Asigna otros campos necesarios
                };

                db.Movimiento.Add(deposit);
                db.SaveChanges();
            }

            return Ok("Deposit registered successfully.");
        }
    }

    public class DepositRequest
    {
        public string Account { get; set; }
        public decimal Amount { get; set; }
    }
}
