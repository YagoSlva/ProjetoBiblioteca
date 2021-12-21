using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models;
using System.Collections.Generic;
namespace Biblioteca.Controllers
{
    public class UsuariosController : Controller
    {
        
        // Lista
        public IActionResult Listagem()
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaTipoDeUser(this);
            UsuarioService usuarioService = new UsuarioService();
            List<Usuario> listaUsers = new List<Usuario>();
            listaUsers = (List<Usuario>)usuarioService.ListarTodos();
            return View(listaUsers);
        }
        // Inserção
        public IActionResult RegistrarUsuario()
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaTipoDeUser(this);
            return View();
        }
        
        [HttpPost]
        public IActionResult RegistrarUsuario(Usuario novoUsuario)
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaTipoDeUser(this);
            novoUsuario.Senha = Criptografo.TextoCriptografado(novoUsuario.Senha);
            new UsuarioService().incluirUsuario(novoUsuario);

            return View("CadastroRealizado", novoUsuario);
        }
        public IActionResult CadastroRealizado()
        {
            return View();
        }
        // Edição
        public IActionResult EditarUsuario(int id)
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaTipoDeUser(this);
            Usuario u = new UsuarioService().Listar(id);
            return View(u);
        }
        [HttpPost]
        public IActionResult EditarUsuario(Usuario userEditado)
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaTipoDeUser(this);
            userEditado.Senha = Criptografo.TextoCriptografado(userEditado.Senha);
            new UsuarioService().editarUsuario(userEditado);
            return RedirectToAction("Listagem", "Usuarios");
        }
        // Exclusão
        public IActionResult ConfirmaExcluirUsuario(int id)
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaTipoDeUser(this);
            return View(new UsuarioService().Listar(id));
        }
        public IActionResult ExcluirUsuario(string decisao, int id)
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaTipoDeUser(this);
            if (decisao == "EXCLUIR")
            {
                ViewData["Mensagem"] = "Exclusão do usuário " + new UsuarioService().Listar(id).Nome + " realizada com sucesso!";
                new UsuarioService().excluirUsuario(id);
                return View("Listagem", new UsuarioService().ListarTodos());
            }else
            {
                ViewData["Mensagem"] = "Exclusão Cancelada";
                return View("Listagem", new UsuarioService().ListarTodos());
            }

        }
        // Extra

        public IActionResult Sair()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult NeedAdmin()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }
    }
}