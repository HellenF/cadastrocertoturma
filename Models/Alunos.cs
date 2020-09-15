using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace escola.Models
{
    public class Aluno
    {

        [Key]
        [Required(ErrorMessage = "Este campo é obrigatorio")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre e 3 60 caracteres")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio")]

        public int matricula { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio")]

        public DateTime dataDeNascimento { get; set; }

        public Int64 idade
        {
            get
            {

                return DateAndTime.DateDiff(DateInterval.Year, dataDeNascimento, DateTime.Now);
            }
        }

        [Required(ErrorMessage = "Este campo é obrigatorio")]
        public string turma { get; set; }

        

    }
}