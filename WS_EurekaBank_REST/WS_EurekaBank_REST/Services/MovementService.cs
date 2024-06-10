using System.Collections.Generic;
using System.Linq;
using System.Data.Entity; // Necesario para usar Include
using WS_EurekaBank_REST.Models;

namespace WS_EurekaBank_REST.Services
{
    public class MovementService
    {
        public List<Movimiento> GetMovementsByClient(string clientCode)
        {
            using (var db = new EUREKABANKEntities())
            {
                // Eager loading de la propiedad relacionada Cuenta
                return db.Movimiento
                         .Where(m => m.chr_cuencodigo == clientCode)
                         .Include(m => m.Cuenta) 
                         .ToList();
            }
        }
    }
}
