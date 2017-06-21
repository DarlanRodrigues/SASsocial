using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SASsocial.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="É necessario um nome válido.",AllowEmptyStrings = false)]
        public String Nome { get; set; }

        [Required(ErrorMessage = "É necessario uma data de nascimento válida.",AllowEmptyStrings = false)]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "É necessario um login válido.", AllowEmptyStrings = false)]
        [MinLength(3, ErrorMessage = "É necessario no minimo 3 caracteres.")]
        public String Login  { get; set; }

        [Required(ErrorMessage = "É necessario uma senha válida.", AllowEmptyStrings = false)]
        [MinLength(6, ErrorMessage = "É necessario no minimo 6 caracteres."),MaxLength(20, ErrorMessage = "É possivel no maximo 20 caracteres.")]
        [DataType(DataType.Password)]
        public String Senha { get; set; }
    }
}