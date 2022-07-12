using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DATA.Models
{
    public class HistoricoPartesNeumaticos
    {
        public long IdHistoricoParteNeumatico { get; set; }
        public long IdNeumatico { get; set; }
        public DateTime? Fecha { get; set; }
        public int? KmAgregados { get; set; }
        public long? IdUnidad { get; set; }
        public long? IdParte { get; set; }
        [ForeignKey("IdTraza")]
        public long? IdTraza { get; set; }
        public virtual Trazas idTraza { get; set; }
    }
}
