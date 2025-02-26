using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso1BrandonBrenes.Abstracciones.AccesoADatos.Habitaciones.ObtenerHabitacionesPorId;
using Caso1BrandonBrenes.Abstracciones.ModelosParaUI;

namespace Caso1BrandonBrenes.AccesoADatos.Habitaciones.ObtenerHabitacionesPorId
{
    public class ObtenerHabitacionesPorIdAD : IObtenerHabitacionesPorIdAD
    {
        private Contexto _elContexto;
        public ObtenerHabitacionesPorIdAD()
        {
            _elContexto = new Contexto();
        }

        public HabitacionesDto Obtener(int id)
        {
            HabitacionesDto laListaDeHabitacionesARetornar = (from laHabitacion in _elContexto.Habitaciones
                                                           where laHabitacion.id == id
                                                           select new HabitacionesDto
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
                                                           }).FirstOrDefault();
            return laListaDeHabitacionesARetornar;
        }
    }
}
