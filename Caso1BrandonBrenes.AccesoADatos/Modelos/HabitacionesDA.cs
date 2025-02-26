using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1BrandonBrenes.AccesoADatos.Modelos
{
    [Table("HABITACIONES")]
    public class HabitacionesDA
    {
        [Key]
        [Column("Id")]
        public int id { get; set; }

        [Column("CodigoDeHabitacion")]
        public string codigoDeHabitacion { get; set; }
        [Column("NombreDeHabitacion")]

        public string nombreDeHabitacion { get; set; }
        [Column("CantidadDeHuespedesPermitidos")]

        public int cantidadDeHuespedesPermitidos { get; set; }
        [Column("CantidadDeCamas")]

        public int cantidadDeCamas { get; set; }
        [Column("CantidadDeBanos")]
        public int cantidadDeBanos { get; set; }
        [Column("Ubicacion")]

        public String ubicacion { get; set; }
        [Column("EncargadoDeLimpieza")]

        public String encargadoDeLimpieza { get; set; }
        [Column("TipoDeHabitacion")]

        public int tipoDeHabitacion { get; set; }
        [Column("CostoDeLimpieza")]

        public decimal costoDeLimpieza { get; set; }
        [Column("CostoDeReserva")]

        public decimal costoDeReserva { get; set; }
        [Column("FechaDeRegistro")]

        public DateTime? fechaDeRegistro { get; set; }
        [Column("FechaDeModificacion")]

        public DateTime? fechaDeModificacion { get; set; }
        [Column("Estado")]

        public bool estado { get; set; }



    }
}
