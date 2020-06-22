using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto.Data.Entities;
using Projeto.Data.Repositories;
using Projeto.Presentation.Models.Cargo;

namespace Projeto.Presentation.Controllers
{
    public class CargoController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(CargoCadastroModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var cargo = new Cargo();
                    cargo.Nome = model.Nome;
                    cargo.Descricao = model.Descricao;

                    var repository = new CargoRepository();
                    repository.Inserir(cargo);

                    TempData["Mensagem"] = "Cargo cadastrado com sucesso.";
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
            var lista = new List<Cargo>();

            try
            {
                var cargoRepository = new CargoRepository();
                var funcionarioRepository = new FuncionarioRepository();

                lista = cargoRepository.Consultar();

                var listaFuncionarios = new List<Funcionario>();

                foreach (var item in lista)
                {
                    item.Funcionarios = funcionarioRepository.ObterPorIdCargo(item.IdCargo);
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
                var repository = new CargoRepository();
                var cargo = repository.ObterPorId(id);

                if (cargo != null) 
                {
                    repository.Excluir(cargo);
                    TempData["Mensagem"] = "Cargo excluído com sucesso.";
                }
                else
                {
                    TempData["Mensagem"] = "Cargo não foi encontrado.";
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
            var model = new CargoEdicaoModel();

            try
            {
                var repository = new CargoRepository();
                var cargo = repository.ObterPorId(id);

                model.IdCargo = cargo.IdCargo;
                model.Nome = cargo.Nome;
                model.Descricao = cargo.Descricao;
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = e.Message;
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Edicao(CargoEdicaoModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var cargo = new Cargo();
                    cargo.IdCargo = model.IdCargo;
                    cargo.Nome = model.Nome;
                    cargo.Descricao = model.Descricao;

                    var repository = new CargoRepository();
                    repository.Alterar(cargo);

                    TempData["Mensagem"] = "Cargo atualizado com sucesso.";
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