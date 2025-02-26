using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Abstracciones.ModelosParaUI
{
	public static class EstadosDeHabitaciones
	{

		public static bool activo = true;
		public static bool inactivo = false;
	}

	public enum MultiplesEstados
	{
        Junior = 1,
        Superior = 2,
        Suite = 3,
	}
}
