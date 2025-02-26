using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso1BrandonBrenes.Abstracciones.AccesoADatos.Habitaciones.ActualizarHabitaciones;
using Caso1BrandonBrenes.Abstracciones.ModelosParaUI;
using Caso1BrandonBrenes.AccesoADatos.Modelos;

namespace Caso1BrandonBrenes.AccesoADatos.Habitaciones.ActualizarHabitaciones
{
    public class ActualizarHabitacionesAD : IActualizarHabitacionesAD
    {
        private Contexto elContexto;
        public ActualizarHabitacionesAD()
        {
            elContexto = new Contexto();
        }
        public int Editar(HabitacionesDto laHabitacionParaActualizar)
        {
            HabitacionesDA laHabitacionEnBaseDeDatos = elContexto.Habitaciones.Where(laHabitacion => laHabitacion.id == laHabitacionParaActualizar.id).FirstOrDefault();
            laHabitacionEnBaseDeDatos.nombreDeHabitacion = laHabitacionParaActualizar.nombreDeHabitacion;
            laHabitacionEnBaseDeDatos.cantidadDeHuespedesPermitidos = laHabitacionParaActualizar.cantidadDeHuespedesPermitidos;
            laHabitacionEnBaseDeDatos.cantidadDeCamas = laHabitacionParaActualizar.cantidadDeCamas;
            laHabitacionEnBaseDeDatos.cantidadDeBanos = laHabitacionParaActualizar.cantidadDeBanos;
            laHabitacionEnBaseDeDatos.ubicacion = laHabitacionParaActualizar.ubicacion;
            laHabitacionEnBaseDeDatos.encargadoDeLimpieza = laHabitacionParaActualizar.encargadoDeLimpieza;
            laHabitacionEnBaseDeDatos.tipoDeHabitacion = laHabitacionParaActualizar.tipoDeHabitacion;
            laHabitacionEnBaseDeDatos.costoDeLimpieza = laHabitacionParaActualizar.costoDeLimpieza;
            laHabitacionEnBaseDeDatos.costoDeReserva = laHabitacionParaActualizar.costoDeReserva;
            laHabitacionEnBaseDeDatos.fechaDeRegistro = laHabitacionParaActualizar.fechaDeRegistro;
            laHabitacionEnBaseDeDatos.fechaDeModificacion = laHabitacionParaActualizar.fechaDeModificacion;
            laHabitacionEnBaseDeDatos.estado = laHabitacionParaActualizar.estado;

            EntityState estado = elContexto.Entry(laHabitacionEnBaseDeDatos).State = System.Data.Entity.EntityState.Modified;
            int seGuardolaHabitacion = elContexto.SaveChanges();
            return seGuardolaHabitacion;
        }
    }
}