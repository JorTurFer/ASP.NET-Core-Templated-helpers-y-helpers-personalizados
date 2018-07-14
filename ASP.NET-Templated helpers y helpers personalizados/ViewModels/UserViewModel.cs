using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Formularios_de_datos.ViewModels
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(50,ErrorMessage = "La longitud máxima es de {1} caracteres")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(20, MinimumLength = 3,ErrorMessage = "La longitud debe estar entre {2} y {1} caracteres")]
        [Remote("AvailableNickname","User",ErrorMessage = "El nombre ya esta ocupado")]
        [Display(Name = "Nick")]
        public string Nickname { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Range(1, 3,ErrorMessage = "El valor debe estar entre {1} y {2}")]
        [Display(Name = "Tipo de usuario")]
        public int Type { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "La longitud máxima es de {1} caracteres")]
        [EmailAddress(ErrorMessage = "El campo {0} debe ser una direccion de email valida")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "La longitud debe estar entre {2} y {1} caracteres")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña" )]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Las contraseñas deben coincidir")]
        [Display(Name = "Repeticion de contraseña")]
        public string RePassword { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime? Birthdate { get; set; }

        [HiddenInput(DisplayValue = false)]
        [Display(Name = "Activo")]
        public bool Enabled { get; set; }
    }
}
