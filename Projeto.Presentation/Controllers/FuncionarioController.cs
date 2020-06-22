using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto.Data.Entities;
using Projeto.Data.Repositories;
using Projeto.Presentation.Models.Funcionario;

namespace Projeto.Presentation.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult Cadastro()
        {
            return View(new FuncionarioCadastroModel());
        }

        [HttpPost]
        public IActionResult Cadastro(FuncionarioCadastroModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var funcionario = new Funcionario();
                    funcionario.Nome = model.Nome;
                    funcionario.Salario = model.Salario;
                    funcionario.DataAdmissao = model.DataAdmissao;
                    funcionario.IdCargo = model.IdCargo;
                    funcionario.IdDepartamento = model.IdDepartamento;

                    var repository = new FuncionarioRepository();
                    repository.Inserir(funcionario);

                    TempData["Mensagem"] = "Funcionário cadastrado com sucesso.";
                    ModelState.Clear();
                }
                catch (Exception e)
                {
                    TempData["Mensagem"] = e.Message;
                }
            }
            return View(new FuncionarioCadastroModel());
        }


        public IActionResult Consulta()
        {
            var lista = new List<Funcionario>();

            try
            {
                var funcionarioRepository = new FuncionarioRepository();
                var cargoRepository = new CargoRepository();
                var departamentoRepository = new DepartamentoRepository();

                lista = funcionarioRepository.Consultar();

                foreach (var item in lista)
                {
                    item.Cargo = cargoRepository.ObterPorId(item.IdCargo);
                    item.Departamento = departamentoRepository.ObterPorId(item.IdDepartamento);
                }
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = e.Message;
            }

            return View(lista);
        }

        [HttpPost]
        public IActionResult Consulta(string filtro)
        {
            var lista = new List<Funcionario>();

            try
            {
                var funcionarioRepository = new FuncionarioRepository();
                var cargoRepository = new CargoRepository();
                var departamentoRepository = new DepartamentoRepository();

                lista = funcionarioRepository.ConsultarPorNome(filtro);

                foreach (var item in lista)
                {
                    item.Cargo = cargoRepository.ObterPorId(item.IdCargo);
                    item.Departamento = departamentoRepository.ObterPorId(item.IdDepartamento);
                }
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = e.Message;
            }

            return View(lista);
        }


        public IActionResult Exclusao(int id) 
        {
            try
            {
                var repository = new FuncionarioRepository();
                var funcionario = repository.ObterPorId(id);

                if (funcionario != null)
                {
                    repository.Excluir(funcionario);
                    TempData["Mensagem"] = "Funcionário excluído com sucesso.";
                }
                else
                {
                    TempData["Mensagem"] = "Funcionário não foi encontrado.";
                }
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = e.Message;
            }

            return RedirectToAction("Consulta");
        }

        public IActionResult Edicao(int id) 
        {
            var model = new FuncionarioEdicaoModel();

            try
            {
                var repository = new FuncionarioRepository();
                var funcionario = repository.ObterPorId(id);

                model.IdFuncionario = funcionario.IdFuncionario;
                model.Nome = funcionario.Nome;
                model.Salario = funcionario.Salario;
                model.DataAdmissao = funcionario.DataAdmissao;
                model.IdCargo = funcionario.IdCargo;
                model.IdDepartamento = funcionario.IdDepartamento;

            }
            catch (Exception)
            {

                throw;
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Edicao(FuncionarioEdicaoModel model) 
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var funcionario = new Funcionario();
                    funcionario.IdFuncionario = model.IdFuncionario;
                    funcionario.Nome = model.Nome;
                    funcionario.Salario = model.Salario;
                    funcionario.DataAdmissao = model.DataAdmissao;
                    funcionario.IdCargo = model.IdCargo;
                    funcionario.IdDepartamento = model.IdDepartamento;

                    var repository = new FuncionarioRepository();
                    repository.Alterar(funcionario);

                    TempData["Mensagem"] = "Funcionário atualizado com sucesso.";
                    return RedirectToAction("Consulta");
                }
                catch (Exception e)
                {
                    TempData["Mensagem"] = e.Message;
                }
            }

            return View(new FuncionarioEdicaoModel());
        }
    }
}