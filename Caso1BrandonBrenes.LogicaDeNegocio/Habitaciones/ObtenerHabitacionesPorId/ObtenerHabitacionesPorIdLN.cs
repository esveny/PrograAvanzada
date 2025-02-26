using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso1BrandonBrenes.Abstracciones.AccesoADatos.Habitaciones.ObtenerHabitacionesPorId;
using Caso1BrandonBrenes.Abstracciones.LogicaDeNegocio.Habitaciones.ObtenerHabitacionesPorId;
using Caso1BrandonBrenes.Abstracciones.ModelosParaUI;
using Caso1BrandonBrenes.AccesoADatos.Habitaciones.ObtenerHabitacionesPorId;

namespace Caso1BrandonBrenes.LogicaDeNegocio.Habitaciones.ObtenerHabitacionesPorId
{
    public class ObtenerHabitacionesPorIdLN : IObtenerHabitacionesPorIdLN
    {
            private IObtenerHabitacionesPorIdAD _obtenerHabitacionPorId;
            public ObtenerHabitacionesPorIdLN()
            {
            _obtenerHabitacionPorId = new ObtenerHabitacionesPorIdAD();
            }

            public HabitacionesDto ObtenerHabitacion(int id)
            {
            HabitacionesDto laHabitacion = _obtenerHabitacionPorId.Obtener(id);
                return laHabitacion;
            }
        }
}
