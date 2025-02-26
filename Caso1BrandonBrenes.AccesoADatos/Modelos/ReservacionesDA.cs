using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1BrandonBrenes.AccesoADatos.Modelos
{
    public class ReservacionesDA
    {
        [Column("Id")]
        public int id { get; set; }
        [Column("NombreDeLaPersona")]

        public String nombreDeLaPersona { get; set; }
        [Column("Identificacion")]

        public String identificacion { get; set; }
        [Column("Telefono")]

        public String telefono { get; set; }
        [Column("Correo")]

        public String correo { get; set; }
        [Column("FechaNacimiento")]

        public DateTime? fechaNacimiento { get; set; }
        [Column("Direccion")]

        public String direccion { get; set; }
        [Column("MontoTotal")]

        public decimal montoTotal { get; set; }
        [Column("FechaInicioReserva")]

        public DateTime? fechaInicioReserva { get; set; }
        [Column("FechaFinReserva")]

        public DateTime? fechaFinReserva { get; set; }
        [Column("FechaDeRegistro")]

        public DateTime? fechaDeRegistro { get; set; }
        [Column("IdHabitacion")]

        public int idHabitacion { get; set; }
    }
}
