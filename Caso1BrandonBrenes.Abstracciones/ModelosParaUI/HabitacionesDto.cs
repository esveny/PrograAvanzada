using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1BrandonBrenes.Abstracciones.ModelosParaUI
{
    public class HabitacionesDto
    {
        [DisplayName("ID")]

        public int id { get; set; }
        [DisplayName("Código de Habitación")]

        public string codigoDeHabitacion { get; set; }
        [DisplayName("Nombre")]

        public string nombreDeHabitacion { get; set; }
        [DisplayName("Cantidad huéspedes permitidos")]

        public int cantidadDeHuespedesPermitidos { get; set; }
        [DisplayName("Cantidad de camas")]

        public int cantidadDeCamas {  get; set; }
        [DisplayName("Cantidad de baños")]

        public int cantidadDeBanos { get; set; }
        [DisplayName("Ubicación")]

        public String ubicacion { get; set; }
        [DisplayName("Responsable de limpieza")]

        public String encargadoDeLimpieza {  get; set; }
        [DisplayName("Tipo de habitación")]

        public int tipoDeHabitacion { get; set; }
        [DisplayName("Costo de limpieza")]

        public decimal costoDeLimpieza { get; set; }
        [DisplayName("Costo de reserva")]

        public decimal costoDeReserva {  get; set; }
        [DisplayName("Fecha de Regsitro")]

        public DateTime? fechaDeRegistro { get; set; }
        [DisplayName("Fecha de Modificación")]

        public DateTime? fechaDeModificacion {  get; set; }
        [DisplayName("Estado")]

        public bool estado {  get; set; }
    }
}
