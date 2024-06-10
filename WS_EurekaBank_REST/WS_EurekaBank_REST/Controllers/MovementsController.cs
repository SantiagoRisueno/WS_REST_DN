using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WS_EurekaBank_REST.Models;

namespace WS_EurekaBank_REST.Controllers
{
    [RoutePrefix("api/movimientos")]
    public class MovementsController : ApiController
    {
        // GET api/movimientos/{clientCode}
        [HttpGet]
        [Route("{clientCode}")]
        public IEnumerable<Movimiento> GetMovements(string clientCode)
        {
            using (var db = new EUREKABANKEntities())
            {
                return db.Movimiento.Where(m => m.chr_cuencodigo == clientCode).ToList();
            }
        }
    }
}
