using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso1BrandonBrenes.Abstracciones.AccesoADatos.Habitaciones.ListarHabitaciones;
using Caso1BrandonBrenes.Abstracciones.LogicaDeNegocio.Habitaciones.ListarHabitaciones;
using Caso1BrandonBrenes.Abstracciones.ModelosParaUI;
using Caso1BrandonBrenes.AccesoADatos.Habitaciones.ListarHabitaciones;
using static Caso1BrandonBrenes.LogicaDeNegocio.Habitaciones.ListarHabitaciones.ListarHabitacionesLN;

namespace Caso1BrandonBrenes.LogicaDeNegocio.Habitaciones.ListarHabitaciones
{
    public class ListarHabitacionesLN : IListarHabitacionesLN
    {
            private IListarHabitacionesAD _listarHabitacionesAD;
            public ListarHabitacionesLN()
            {
                _listarHabitacionesAD = new ListarHabitacionesAD();
            }

            public List<HabitacionesDto> Obtener()
            {
                List<HabitacionesDto> laListaDeHabitaciones = _listarHabitacionesAD.Obtener();
                return laListaDeHabitaciones;
            }

        }
    }
