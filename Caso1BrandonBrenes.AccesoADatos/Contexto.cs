using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso1BrandonBrenes.AccesoADatos.Modelos;

namespace Caso1BrandonBrenes.AccesoADatos
{
    public class Contexto : DbContext
    {
        public Contexto() : base("name=Contexto")
        {

        }
        public DbSet<HabitacionesDA> Habitaciones { get; set; }
        public DbSet<ReservacionesDA> Reservaciones { get; set; }
    }
}
