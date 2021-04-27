using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TemplateNetCore.Models
{
    [Table("TB_M_University")]
    public class University
    {
        [Key]
        public int UniversityId { get; set; }
        [Required]
        public string UniversityName { get; set; }
        [JsonIgnore]
        public virtual ICollection<Education> Educations { get; set; }
    }
}
