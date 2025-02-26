using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso1BrandonBrenes.Abstracciones.ModelosParaUI;

namespace Caso1BrandonBrenes.Abstracciones.AccesoADatos.Habitaciones.ActualizarHabitaciones
{
    public interface IActualizarHabitacionesAD
    {
        int Editar(HabitacionesDto laHabitacionParaActualizar);
    }
}
