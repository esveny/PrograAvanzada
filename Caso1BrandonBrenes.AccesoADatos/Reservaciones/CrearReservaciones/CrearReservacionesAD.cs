using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso1BrandonBrenes.Abstracciones.AccesoADatos.Reservaciones.CrearReservaciones;
using Caso1BrandonBrenes.Abstracciones.ModelosParaUI;
using Caso1BrandonBrenes.AccesoADatos.Modelos;

namespace Caso1BrandonBrenes.AccesoADatos.Reservaciones.CrearReservaciones
{
    public class CrearReservacionesAD : ICrearReservacionesAD
    {
        private Contexto elContexto;
        public CrearReservacionesAD()
        {
            elContexto = new Contexto();
        }
        public async Task<int> Guardar(ReservacionesDto laReservacionAGuardar)
        {
            elContexto.Reservaciones.Add(ConvierteLaReservacion(laReservacionAGuardar));
            int seGuardoLaReservacion = await elContexto.SaveChangesAsync();
            return seGuardoLaReservacion;
        }
        private ReservacionesDA ConvierteLaReservacion(ReservacionesDto laReservacion)
        {
            return new ReservacionesDA
            {
                id = laReservacion.id,
                nombreDeLaPersona = laReservacion.nombreDeLaPersona,
                identificacion = laReservacion.identificacion,
                telefono = laReservacion.telefono,
                correo = laReservacion.correo,
                fechaNacimiento = laReservacion.fechaNacimiento,
                direccion = laReservacion.direccion,
                montoTotal = laReservacion.montoTotal,
                fechaInicioReserva = laReservacion.fechaInicioReserva,
                fechaFinReserva = laReservacion.fechaFinReserva,
                fechaDeRegistro = laReservacion.fechaDeRegistro,
                //idHabitacion = laReservacion.idHabitacion
            };
        }
    }
}
