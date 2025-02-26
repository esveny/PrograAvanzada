using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1BrandonBrenes.Abstracciones.ModelosParaUI
{
    public class ReservacionesDto
    {
        [DisplayName("ID")]

       public int id { get; set; }
        [DisplayName("Nombre De La Persona")]

        public String nombreDeLaPersona { get; set; }
        [DisplayName("Identificacion")]

        public String identificacion {  get; set; }
        [DisplayName("Teléfono")]

        public String telefono { get; set; }
        [DisplayName("Correo")]

        public String correo { get; set; }
        [DisplayName("Fecha de Nacimiento")]

        public DateTime? fechaNacimiento { get; set; }
        [DisplayName("Direccion")]

        public String direccion { get; set; }
        [DisplayName("Monto Total")]

        public decimal montoTotal { get; set; }
        [DisplayName("Fecha Inicio de Reserva")]

        public DateTime? fechaInicioReserva {  get; set; }
        [DisplayName("Fecha Fin de Reserva")]

        public DateTime? fechaFinReserva { get; set; }
        [DisplayName("Fecha de Registro")]

        public DateTime? fechaDeRegistro { get; set; }
        [DisplayName("Id de la Habitacion")]

        public int idHabitacion {  get; set; }

    }
}
