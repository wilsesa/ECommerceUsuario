using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }


        [Required(ErrorMessage = "O campo E-mail é requerido!!")]
        [MaxLength(250, ErrorMessage = "O campo email recebe no máximo 250 carateres")]
        [Display(Name = "E-mail ")]
        //[DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="O email não é válido!")]
        [Index("User_UserName_Index", IsUnique = true)]
        public string UserName { get; set; }


        [Required(ErrorMessage = "O campo nome é requerido!!")]
        [MaxLength(50, ErrorMessage = "O campo nome recebe no máximo 50 carateres")]
        [Display(Name = "Nome")]
        public string FirtName { get; set; }

        [Required(ErrorMessage = "O campo sobrenome é requerido!!")]
        [MaxLength(50, ErrorMessage = "O campo sobrenome recebe no máximo 150 carateres")]
        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "O campo Telefone é requerido!!")]
        [MaxLength(50, ErrorMessage = "O campo telefone recebe no máximo 50 carateres")]
        [Display(Name = "Telefone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }


        [Required(ErrorMessage = "O campo Endereço é requerido!!")]
        [MaxLength(100, ErrorMessage = "O campo endereço recebe no máximo 50 carateres")]
        [Display(Name = "Endereço")]
        public string Address { get; set; }


        [Display(Name = "Imagem")]
        [DataType(DataType.ImageUrl)]
        public string Photo { get; set; }


        [NotMapped]
        public HttpPostedFileBase PhotoFile { get; set; }


        [Required(ErrorMessage = "O campo Departamento é requerido!!")]
        [Display(Name = "Departamento")]
        public int DepartamentsId { get; set; }


        [Required(ErrorMessage = "O campo Cidade é requerido!!")]
        [Display(Name = "Cidade")]
        public int CityId { get; set; }


        [Required(ErrorMessage = "O campo companhia é requerido!!")]
        [Display(Name = "Companhia")]
        public int CompanyId { get; set; }

        [Display(Name ="Usuário")]
        public string FullName { get { return string.Format("{0} {1}", FirtName, LastName); } }

        //Relacionamentos com outras classes
        public virtual Departaments Departaments { get; set; }
        public virtual City Cities { get; set; }

        public virtual Company Company { get; set; }
    }
}