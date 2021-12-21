using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Biblioteca.Models;



namespace Biblioteca.Controllers
{
    public class Autenticacao
    {
        public static void CheckLogin(Controller controller)
        {   
            if(string.IsNullOrEmpty(controller.HttpContext.Session.GetString("Login")))
            {
                controller.Request.HttpContext.Response.Redirect("/Home/Login");
            }
        }

        public static bool verificaLoginSenha(string login, string senha, Controller controller)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                verificaUsuarioAdminDefault(bc);
                senha = Criptografo.TextoCriptografado(senha);

                IQueryable<Usuario> UsuarioEcontrado = bc.Usuarios.Where(u => u.Login==login && u.Senha==senha);
                List<Usuario> ListaUsuarioEcontrado = UsuarioEcontrado.ToList();

                if (ListaUsuarioEcontrado.Count == 0)
                {
                    return false;
                }
                else
                {
                    controller.HttpContext.Session.SetString("Login", ListaUsuarioEcontrado[0].Login);
                    controller.HttpContext.Session.SetString("Senha", ListaUsuarioEcontrado[0].Senha);
                    controller.HttpContext.Session.SetInt32("Tipo", ListaUsuarioEcontrado[0].Tipo);
                    return true;
                }

            }
        }
        public static void verificaUsuarioAdminDefault(BibliotecaContext bc)
        {
            IQueryable<Usuario> userEncontrado = bc.Usuarios.Where(u => u.Login == "admin");

            if (userEncontrado.ToList().Count == 0)
            {
                Usuario admin = new Usuario();
                admin.Login = "admin";
                admin.Senha = Criptografo.TextoCriptografado("123");
                admin.Tipo = Usuario.admin;
                admin.Nome = "Administrador";

                bc.Usuarios.Add(admin);
                bc.SaveChanges();
            }
        }
        public static void verificaTipoDeUser(Controller controller)
        {
            if (!(controller.HttpContext.Session.GetInt32("Tipo") == Usuario.admin))
            {
                controller.Request.HttpContext.Response.Redirect("/Usuarios/NeedAdmin");
            }
        }
        
    }
}