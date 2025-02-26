using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso1BrandonBrenes.Abstracciones.LogicaDeNegocio.Reservaciones.ObtenerReservacionesPorId;
using Caso1BrandonBrenes.Abstracciones.ModelosParaUI;
using Caso1BrandonBrenes.AccesoADatos.Reservaciones.ObtenerReservacionesPorId;

namespace Caso1BrandonBrenes.LogicaDeNegocio.Reservaciones.ObtenerReservacionesPorId
{
    public class ObtenerReservacionesPorIdLN : IObtenerReservacionesPorIdLN
    {
        
            private ObtenerReservacionesPorIdAD _obtenerReservacionPorId;
            public ObtenerReservacionesPorIdLN()
            {
            _obtenerReservacionPorId = new ObtenerReservacionesPorIdAD();
            }

            public ReservacionesDto ObtenerReservacion(int id)
            {
            ReservacionesDto laReservacion = _obtenerReservacionPorId.ObtenerReservacion(id);
                return laReservacion;
            }
    }
}
