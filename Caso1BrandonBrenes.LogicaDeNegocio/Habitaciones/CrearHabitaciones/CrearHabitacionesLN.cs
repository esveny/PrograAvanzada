using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso1BrandonBrenes.Abstracciones.AccesoADatos.Habitaciones.CrearHabitaciones;
using Caso1BrandonBrenes.Abstracciones.General.Fechas;
using Caso1BrandonBrenes.Abstracciones.LogicaDeNegocio.Habitaciones.CrearHabitaciones;
using Caso1BrandonBrenes.Abstracciones.ModelosParaUI;
using Caso1BrandonBrenes.AccesoADatos.Habitaciones.CrearHabitaciones;
using Caso1BrandonBrenes.LogicaDeNegocio.General.Fechas;
using Inventario.Abstracciones.ModelosParaUI;
using static Caso1BrandonBrenes.LogicaDeNegocio.Habitaciones.CrearHabitaciones.CrearHabitacionesLN;

namespace Caso1BrandonBrenes.LogicaDeNegocio.Habitaciones.CrearHabitaciones
{
    public class CrearHabitacionesLN : ICrearHabitacionesLN
    {
            private ICrearHabitacionesAD _crearHabitaciones;
            private IFecha _fecha;

            public CrearHabitacionesLN()
            {
            _crearHabitaciones = new CrearHabitacionesAD();
                _fecha = new Fecha();
            }

            public async Task<int> Guardar(HabitacionesDto laHabitacionAGuardar)
            {
            laHabitacionAGuardar.fechaDeRegistro = _fecha.ObtenerFecha();
            laHabitacionAGuardar.fechaDeModificacion = _fecha.ObtenerFecha();
            laHabitacionAGuardar.estado = EstadosDeHabitaciones.activo;
                int seGuardoElInventario = await _crearHabitaciones.Guardar(laHabitacionAGuardar);
                return seGuardoElInventario;
            }
    }
}
