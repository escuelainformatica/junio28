using junio28.base2;
using junio28.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace junio28.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Listar()
        {
            List<Usuario> usuarios=UsuarioDAL.ListarTodo();
            ViewBag.usuarios=usuarios;
            ViewData["usuarios"]=usuarios;


            return View();
        }
        public ActionResult Insertar()
        {
            return View();
        }
    }
}