using System;
using System.ComponentModel.DataAnnotations;

namespace Examen1SI.Models.Citasmedicas
{
    public class Cita_Medica
    {
        [Key]
        public int CitaID { get; set; }

        [Required(ErrorMessage ="El nombre del paciente es obligatorio")]
        [Display(Name = "Nombre")]
        public string CitaNombre { get; set; }

        [Required(ErrorMessage = "El segundo nombre del paciente es obligatorio")]
        [Display(Name = "Segundo Nombre")]
        [StringLength(70, ErrorMessage = "Debe tener 40 caracteres o menos")]
        [MinLength(2, ErrorMessage = "Debe tener al menos 2 caracteres")]
        public string CitaSNombre { get; set; }

        [StringLength(70, ErrorMessage = "Debe tener 40 caracteres o menos")]
        [MinLength(2, ErrorMessage = "Debe tener al menos 2 caracteres")]
        [Required(ErrorMessage = "El apellido del paciente es obligatorio")]
        [Display(Name = "Apellido")]
        public string CitaApellido { get; set; }

        [StringLength(70, ErrorMessage = "Debe tener 40 caracteres o menos")]
        [MinLength(2, ErrorMessage = "Debe tener al menos 2 caracteres")]
        [Required(ErrorMessage = "El correo electrónico del paciente es obligatorio")]
        [Display(Name = "Correo Electrónico")]
        public string CitaCorreo { get; set; }

        [Display(Name = "Nombre del acompañante")]
        public string CitaNombreAcom { get; set; }

        [Display(Name = "Apellido del acompañante")]
        public string CitaApellidoAcom { get; set; }

        [Required(ErrorMessage = "La dirección del paciente debe estar completa")]
        [Display(Name = "Dirección de la calle")]
        public string Direccion1 { get; set; }

        [Required(ErrorMessage = "La dirección del paciente debe estar completa")]
        [Display(Name = "Dirección de la calle Linea 2")]
        public string Direccion2 { get; set; }

        [Required(ErrorMessage = "La dirección del paciente debe estar completa")]
        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; }

        [Required(ErrorMessage = "La dirección del paciente debe estar completa")]
        [Display(Name = "Estado/Provincia")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "La dirección del paciente debe estar completa")]
        [Display(Name = "Código postal")]
        public string CodPost { get; set; }

        [Required(ErrorMessage = "El código de área es obligatorio")]
        [StringLength(3, ErrorMessage = "Debe tener 3 digitos")]
        [MinLength(3, ErrorMessage = "Debe tener 3 digitos")]
        [Display(Name = "Código de area")]
        public string CodAreaTel { get; set; }

        [StringLength(70, ErrorMessage = "Debe tener 12 digitos o menos")]
        [MinLength(2, ErrorMessage = "Debe tener al menos 7 digitos")]
        [Required(ErrorMessage = "El número de teléfono del paciente debe estar completo")]
        [Display(Name = "Número de teléfono")]
        public string NumTel { get; set; }

        [StringLength(3, ErrorMessage = "Debe tener 3 digitos")]
        [Display(Name = "Código de area")]
        [MinLength(3, ErrorMessage = "Debe tener 3 digitos")]
        public string CodAreaWa { get; set; }

        [StringLength(70, ErrorMessage = "Debe tener 12 digitos o menos")]
        [MinLength(2, ErrorMessage = "Debe tener al menos 7 digitos")]
        [Display(Name = "Número de teléfono")]
        public string NumWa { get; set; }
    }
}
