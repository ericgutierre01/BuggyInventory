using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuggyInventory.Entities
{
    public class Piezas
    {
        public int PieId { get; set; }
        public string PieNombre { get; set; }
        public string PieDescripcion { get; set; }
        public DateTime PieFechaCreacion { get; set; }
        public DateTime? PieFechaActualizacion { get; set; }
        public string PieCodigo { get; set; }
        public string PieFoto { get; set; }
        public decimal? PieCosto { get; set; }
        public int? PieCantidadInve { get; set; }
    }
}
