using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso1BrandonBrenes.Abstracciones.General.Fechas;

namespace Caso1BrandonBrenes.LogicaDeNegocio.General.Fechas
{
    public class Fecha : IFecha
    {
            public DateTime ObtenerFecha()
            {
                return DateTime.UtcNow.AddHours(-6);
            }
    }
    
}

