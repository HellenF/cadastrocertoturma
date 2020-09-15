using System.ComponentModel.DataAnnotations;

namespace escola.Models

{

    public class Turma
    {
        [Key]
        [Required(ErrorMessage = "Este campo é obrigatorio")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre e 3 60 caracteres")]
        public string tituloDaTurma { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio")]


        public int qtdDeAlunos { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio")]


        public int idadeMedia { get; set; }
    }
}