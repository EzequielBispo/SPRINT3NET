using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SPRINT3NET.Domain.Entities
{
    [Table("TB_SITES_THREAT")]
    public class SitesEntity
    {
        [Key]
        public int Id { get; set; }
        public string Dominio { get; set; } = string.Empty;
        public string Titulo { get; set; } = string.Empty;
    }
}
