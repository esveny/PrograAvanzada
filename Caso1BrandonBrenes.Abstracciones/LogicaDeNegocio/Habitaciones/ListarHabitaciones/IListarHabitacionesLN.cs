using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso1BrandonBrenes.Abstracciones.ModelosParaUI;

namespace Caso1BrandonBrenes.Abstracciones.LogicaDeNegocio.Habitaciones.ListarHabitaciones
{
    public interface IListarHabitacionesLN
    {
        List<HabitacionesDto> Obtener();
    }
}
