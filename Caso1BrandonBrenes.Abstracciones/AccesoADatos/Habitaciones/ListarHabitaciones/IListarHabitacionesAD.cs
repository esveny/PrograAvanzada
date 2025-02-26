using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso1BrandonBrenes.Abstracciones.ModelosParaUI;

namespace Caso1BrandonBrenes.Abstracciones.AccesoADatos.Habitaciones.ListarHabitaciones
{
    public interface IListarHabitacionesAD
    {
         List<HabitacionesDto> Obtener();
    }
}
