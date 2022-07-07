﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATA.Models
{
    public class Empresas
    {
        public Empresas()
        {
            Choferes = new HashSet<Choferes>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmpresa { get; set; }
        [MaxLength(100)]
        public string Descripcion { get; set; }
        public string Obs { get; set; }
        public virtual ICollection<Choferes> Choferes { get; set; }
    }
}
