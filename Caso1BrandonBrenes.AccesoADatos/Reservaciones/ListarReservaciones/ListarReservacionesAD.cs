using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso1BrandonBrenes.Abstracciones.AccesoADatos.Reservaciones.ListarReservaciones;
using Caso1BrandonBrenes.Abstracciones.ModelosParaUI;
using Caso1BrandonBrenes.AccesoADatos.Modelos;

namespace Caso1BrandonBrenes.AccesoADatos.Reservaciones.ListarReservaciones
{
    public class ListarReservacionesAD : IListarReservacionesAD
    {
        private Contexto _elContexto;
        public ListarReservacionesAD()
        {
            _elContexto = new Contexto();
        }
        public List<ReservacionesDto> Obtener()
        {
            List<ReservacionesDA> laListaDeReservaciones = _elContexto.Reservaciones.ToList();
            List<ReservacionesDto> laListaDeReservacionesARetornar = (from laReservacion in _elContexto.Reservaciones
                                                                    select new ReservacionesDto
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
                                                                        idHabitacion = laReservacion.idHabitacion
                                                                    }).ToList();
            return laListaDeReservacionesARetornar;
        }

    }
}
