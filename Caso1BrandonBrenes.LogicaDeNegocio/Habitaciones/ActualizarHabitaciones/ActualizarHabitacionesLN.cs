using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso1BrandonBrenes.Abstracciones.AccesoADatos.Habitaciones.ActualizarHabitaciones;
using Caso1BrandonBrenes.Abstracciones.LogicaDeNegocio.Habitaciones.ActualizarHabitaciones;
using Caso1BrandonBrenes.Abstracciones.ModelosParaUI;
using Caso1BrandonBrenes.AccesoADatos.Habitaciones.ActualizarHabitaciones;
using static Caso1BrandonBrenes.LogicaDeNegocio.Habitaciones.ActualizarHabitaciones.ActualizarHabitacionesLN;

namespace Caso1BrandonBrenes.LogicaDeNegocio.Habitaciones.ActualizarHabitaciones
{
    public class ActualizarHabitacionesLN : IActualizarHabitacionesLN
    {

            private IActualizarHabitacionesAD _actualizarHabitaciones;

            public ActualizarHabitacionesLN()
            {
            _actualizarHabitaciones = new ActualizarHabitacionesAD();
            }

            public int Actualizar(HabitacionesDto laHabitacionParaActualizar)
            {
                return _actualizarHabitaciones.Editar(laHabitacionParaActualizar);
            }
    }
}
