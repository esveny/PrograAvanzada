using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso1BrandonBrenes.Abstracciones.ModelosParaUI;

namespace Caso1BrandonBrenes.Abstracciones.LogicaDeNegocio.Reservaciones.ObtenerReservacionesPorId
{
    public interface IObtenerReservacionesPorIdLN
    {
        ReservacionesDto ObtenerReservacion(int id);
    }
}
