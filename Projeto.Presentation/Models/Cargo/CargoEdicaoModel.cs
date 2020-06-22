using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Models.Cargo
{
    public class CargoEdicaoModel
    {
        public int IdCargo { get; set; }

        [MinLength(4, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(20, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o cargo.")]
        public string Nome { get; set; }

        [MinLength(8, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a descrição do cargo.")]
        public string Descricao { get; set; }
    }
}
