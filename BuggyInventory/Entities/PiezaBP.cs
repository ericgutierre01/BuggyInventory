using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuggyInventory.Entities
{
    public class PiezaBP
    {
        public int PieId { get; set; }
        public string PieNombre { get; set; }
        public int? PieCantidadInve { get; set; }

        public int? PieCantidadActual { get; set; }
    }
}
