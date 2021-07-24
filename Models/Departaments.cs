using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Departaments
    {
        [Key]
        [Display(Name ="Departamentos")]
        public int DepartamentsId { get; set; }

        [Required(ErrorMessage = "O campo Nome é requerido!!")]
        [MaxLength(50, ErrorMessage ="O campo nome recebe no máximo 50 carateres")]
        [Display(Name ="Nome")]
        [Index("Departaments_Name_Index", IsUnique = true)]
        public string Name { get; set; }

        //Relacionamentos com outras classes
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Company> Companies { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}