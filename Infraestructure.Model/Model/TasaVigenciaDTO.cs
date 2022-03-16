using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Model.Model
{
    public class TasaVigenciaDTO
    {
        public int TasaVigenciaID { get; set; }
        public int ClaseTasa { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime FechaFinVigencia { get; set; }
        public decimal Valor { get; set; }
        public bool Vigente { get; set; }
        public int EstadoRegistro { get; set; }
        public bool Borrado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaUltMod { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioUltMod { get; set; }
    }
}
