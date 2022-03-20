
using Cadastro_Curriculos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Cadastro_Curriculos.DAO;

namespace Cadastro_Curriculos.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                UserDAO dao = new UserDAO();
                var lista = dao.Listagem();
                return View(lista);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.Message));
            }
        }


        public IActionResult Create()
        {
            UserViewModel user = new UserViewModel();
            return View("Form", user);
        }

        public IActionResult Save(UserViewModel user)
        {
            try
            {
                UserDAO dao = new UserDAO();

                if (dao.Consulta(user.Id) == null) { dao.Inserir(user); }

                else { dao.Inserir(user); }

                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }

        }

        public IActionResult Edit(int Id)
        {
            try
            {
                UserDAO dao = new UserDAO();
                UserViewModel user = dao.Consulta(Id);
                if (user == null)
                    return RedirectToAction("Index");
                else
                    return View("Form", user);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }
    }
}
