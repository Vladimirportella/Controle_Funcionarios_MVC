using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto.Data.Entities;
using Projeto.Data.Repositories;
using Projeto.Presentation.Models.Departamento;

namespace Projeto.Presentation.Controllers
{
    public class DepartamentoController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(DepartamentoCadastroModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var departamento = new Departamento();
                    departamento.Nome = model.Nome;
                    departamento.Descricao = model.Descricao;

                    var repository = new DepartamentoRepository();
                    repository.Inserir(departamento);

                    TempData["Mensagem"] = "Departamento cadastrado com sucesso.";
                    ModelState.Clear();
                }
                catch (Exception e)
                {
                    TempData["Mensagem"] = e.Message;
                }
            }
            return View();
        }

        public IActionResult Consulta()
        {
            var lista = new List<Departamento>();

            try
            {
                var departamentoRepository = new DepartamentoRepository();
                var funcionarioRepository = new FuncionarioRepository();

                lista = departamentoRepository.Consultar();

                foreach (var item in lista)
                {
                    item.Funcionarios = funcionarioRepository.ObterPorIdDepartamento(item.IdDepartamento);
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
                var repository = new DepartamentoRepository();
                var departamento = repository.ObterPorId(id);

                if (departamento != null) 
                {
                    repository.Excluir(departamento);
                    TempData["Mensagem"] = "Departamento excluído com sucesso.";
                }
                else
                {
                    TempData["Mensagem"] = "Departamento não foi encontrado.";
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
            var model = new DepartamentoEdicaoModel();

            try
            {
                var repository = new DepartamentoRepository();
                var departamento = repository.ObterPorId(id);

                model.IdDepartamento = departamento.IdDepartamento;
                model.Nome = departamento.Nome;
                model.Descricao = departamento.Descricao;
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = e.Message;
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Edicao(DepartamentoEdicaoModel model) 
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var departamento = new Departamento();
                    departamento.IdDepartamento = model.IdDepartamento;
                    departamento.Nome = model.Nome;
                    departamento.Descricao = model.Descricao;

                    var repository = new DepartamentoRepository();
                    repository.Alterar(departamento);

                    TempData["Mensagem"] = "Departamento atualizado com sucesso.";
                    return RedirectToAction("Consulta");
                }
                catch (Exception e)
                {
                    TempData["Mensagem"] = e.Message;
                }
            }

            return View();
        }
    }
}