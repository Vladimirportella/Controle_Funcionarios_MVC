using Microsoft.AspNetCore.Mvc.Rendering;
using Projeto.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Models.Funcionario
{
    public class FuncionarioCadastroModel
    {
        [MinLength(4, ErrorMessage = "Porfavor, informe no mínimo {1} caracteres.")]
        [MaxLength(20, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do funcionário.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe o salário do funcionário.")]
        public decimal Salario { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data de admissao.")]
        public DateTime DataAdmissao { get; set; }

        [Required(ErrorMessage = "Por favor, informe o cargo.")]
        public int IdCargo { get; set; }

        [Required(ErrorMessage = "Por favor, informe o departamento.")]
        public int IdDepartamento { get; set; }

        public List<SelectListItem> ListagemDeCargos
        { 
            get 
            {
                var repository = new CargoRepository();
                var cargos = repository.Consultar();

                var listagem = new List<SelectListItem>();

                foreach (var item in cargos)
                {
                    listagem.Add(new SelectListItem 
                    {
                        Value = item.IdCargo.ToString(),
                        Text = item.Nome
                    });
                }

                return listagem;
            }
        }

        public List<SelectListItem> ListagemDeDepartamentos
        {
            get
            {
                var repository = new DepartamentoRepository();
                var departamentos = repository.Consultar();

                var listagem = new List<SelectListItem>();

                foreach (var item in departamentos)
                {
                    listagem.Add(new SelectListItem
                    {
                        Value = item.IdDepartamento.ToString(),
                        Text = item.Nome
                    });
                }

                return listagem;
            }
        }
    }
}
