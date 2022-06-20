﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Knowledgebase.Models
{
    [Table("Plataformas")]
    public class Plataforma
    {
        public Plataforma()
        {
            Frameworks = new HashSet<Framework>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(6)]
        public string Apelido { get; set; } = null!;

        [StringLength(64)]
        public string Descricao { get; set; } = null!;

        [StringLength(16)]
        public string? Versao { get; set; } = null;

        private string showItem;

        public string ShowItem
        {
            get { return Descricao + " vs. " + Versao; }
        }

        public virtual ICollection<Framework> Frameworks { get; set; }
    }
}
