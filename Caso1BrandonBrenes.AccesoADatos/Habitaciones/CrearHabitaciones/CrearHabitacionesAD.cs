using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso1BrandonBrenes.Abstracciones.AccesoADatos.Habitaciones.CrearHabitaciones;
using Caso1BrandonBrenes.Abstracciones.ModelosParaUI;
using Caso1BrandonBrenes.AccesoADatos.Modelos;

namespace Caso1BrandonBrenes.AccesoADatos.Habitaciones.CrearHabitaciones
{
    public class CrearHabitacionesAD : ICrearHabitacionesAD
    {
        private Contexto elContexto;
        public CrearHabitacionesAD()
        {
            elContexto = new Contexto();
        }
        public async Task<int> Guardar(HabitacionesDto laHabitacionAGuardar)
        {
            elContexto.Habitaciones.Add(ConvierteLaHabitacion(laHabitacionAGuardar));
            int seGuardoLaHabitacion = await elContexto.SaveChangesAsync();
            return seGuardoLaHabitacion;
        }
        private HabitacionesDA ConvierteLaHabitacion(HabitacionesDto laHabitacion)
        {
            return new HabitacionesDA
            {
                id = laHabitacion.id,
                codigoDeHabitacion = laHabitacion.codigoDeHabitacion,
                nombreDeHabitacion = laHabitacion.nombreDeHabitacion,
                cantidadDeHuespedesPermitidos = laHabitacion.cantidadDeHuespedesPermitidos,
                cantidadDeCamas = laHabitacion.cantidadDeCamas,
                cantidadDeBanos = laHabitacion.cantidadDeBanos,
                ubicacion = laHabitacion.ubicacion,
                encargadoDeLimpieza = laHabitacion.encargadoDeLimpieza,
                tipoDeHabitacion = laHabitacion.tipoDeHabitacion,
                costoDeLimpieza = laHabitacion.costoDeLimpieza,
                costoDeReserva = laHabitacion.costoDeReserva,
                fechaDeRegistro = laHabitacion.fechaDeRegistro,
                fechaDeModificacion = laHabitacion.fechaDeModificacion,
                estado = laHabitacion.estado
            };
        }
    }
}
