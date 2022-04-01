
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

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// endpoint que ira encaminhar para view de Form onde sera feitos novos registros
        /// </summary>
        /// <returns>View</returns>
        public IActionResult Create()
        {

            UserViewModel user = new UserViewModel();
            UserDAO userDao = new UserDAO();
            user.Id = userDao.ProximoId();
            return View("Form", user);
        }

        /// <summary>
        /// Endpoint que salva o registro no banco de dados
        /// </summary>
        /// <param name="user"></param>
        /// <returns>View</returns>
        public IActionResult Save(UserViewModel user)
        {
            try
            {
                UserDAO dao = new UserDAO();
                // se na consulta nao constar a id requisitada ira inserir um novo registro no banco
                if (dao.Consulta(user.Id) == null) { dao.Inserir(user); }

                else
                {
                    // caso tenha ira alterar de acordo com as novas informações
                    dao.Alterar(user);
                }

                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }

        }

        /// <summary>
        /// Endpoint que encaminha para a tela de Form onde sera editado caso exista
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public IActionResult Edit(int Id)
        {
            try
            {


                UserDAO dao = new UserDAO();
                UserViewModel user = dao.Consulta(Id);
                if (user == null)
                    return RedirectToAction("Index");
                else
                {
                    return View("Form", user);
                }


            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        /// <summary>
        /// EndPoint que deleta um
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Delete(int id)
        {
            try
            {
                UserDAO dao = new UserDAO();
                dao.Excluir(id);
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        /// <summary>
        /// Endpoint que exibe o registro por completo na view FormComplete
        /// </summary>
        /// <param name="id"></param>
        /// <returns>View</returns>
        public IActionResult Exibir(int id)
        {
            try
            {
                UserDAO dao = new UserDAO();
                UserViewModel user = dao.Exibir(id);
                return View("FormComplete", user);

            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }


    }
}
