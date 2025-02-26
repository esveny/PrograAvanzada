using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso1BrandonBrenes.Abstracciones.AccesoADatos.Habitaciones.ListarHabitaciones;
using Caso1BrandonBrenes.Abstracciones.ModelosParaUI;
using Caso1BrandonBrenes.AccesoADatos.Modelos;

namespace Caso1BrandonBrenes.AccesoADatos.Habitaciones.ListarHabitaciones
{
    public class ListarHabitacionesAD : IListarHabitacionesAD
    {
        private Contexto _elContexto;
        public ListarHabitacionesAD()
        {
            _elContexto = new Contexto();
        }
        public List<HabitacionesDto> Obtener()
        {
            List<HabitacionesDA> laListaDeHabitaciones = _elContexto.Habitaciones.ToList();
            List<HabitacionesDto> laListaDeHabitacionesARetornar = (from laHabitacion in _elContexto.Habitaciones
                                                                    select new HabitacionesDto {
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
                                                                        estado = laHabitacion.estado,

                                                                    }).ToList();
            return laListaDeHabitacionesARetornar;
        }
    }
}
