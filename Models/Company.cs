using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Company
    {
        [Key]
        [Display(Name = "Companhias")]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "O campo Nome é requerido!!")]
        [MaxLength(50, ErrorMessage = "O campo nome recebe no máximo 50 carateres")]
        [Display(Name = "Nome")]
        [Index("Departaments_Name_Index", IsUnique = true)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo Telefone é requerido!!")]
        [MaxLength(50, ErrorMessage = "O campo telefone recebe no máximo 50 carateres")]
        [Display(Name = "Telefone")]
        //[Index("Departaments_Name_Index", IsUnique = true)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "O campo Endereço é requerido!!")]
        [MaxLength(100, ErrorMessage = "O campo endereço recebe no máximo 50 carateres")]
        [Display(Name = "Endereço")]
        public string Address { get; set; }
        
        [Display(Name = "Imagem")]
        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }

        [NotMapped]
        public HttpPostedFileBase LogoFile { get; set; }

        [Required(ErrorMessage = "O campo Departamento é requerido!!")]
        [Display(Name = "Departamento")]
        public int DepartamentsId { get; set; }

        [Required(ErrorMessage = "O campo Cidade é requerido!!")]
        [Display(Name = "Cidade")]
        public int CityId { get; set; }

        //Relacionamentos com outras classes
        public virtual Departaments Departaments { get; set; }
        public virtual City Cities { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}