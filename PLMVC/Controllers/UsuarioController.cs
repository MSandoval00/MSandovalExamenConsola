using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PLMVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Usuario usuario = new ML.Usuario();
            usuario.Usuarios = new List<object>();
            ML.Result result = BL.Usuario.GetAll();
            if (result!=null)
            {
                usuario.Usuarios = result.Objects;
            }
            else
            {
                ViewBag.Message = "Error no hay registros";
            }
            return View(usuario);
        }
        [HttpGet]
        public ActionResult Form(int? IdUsuario)
        {
            ML.Usuario usuario = new ML.Usuario();
            usuario.Usuarios=new List<object>();
            if (IdUsuario!=null)
            {
                ML.Result result = BL.Usuario.GetById(IdUsuario.Value);
                if (result.Correct)
                {
                    usuario=(ML.Usuario)result.Object;
                }
            }
            else//Add
            {

            }
            return View(usuario);
        }
        [HttpPost]
        public ActionResult Form(ML.Usuario usuario)
        {
            if (usuario.IdUsuario==0)//Add
            {
                ML.Result result = BL.Usuario.Add(usuario);
                if (result.Correct)
                {
                    ViewBag.Mensaje = "Se registro correctamente el usuario";
                }
                else
                {
                    ViewBag.Mensaje = "No se pudo registrar el usuario";
                }
            }
            else//Update
            {
                ML.Result result = BL.Usuario.Update(usuario);
                if (result.Correct)
                {
                    ViewBag.Mensaje = "Se actualizo el usuario";
                }
                else
                {
                    ViewBag.Mensaje = "No se pudo actualizar el usuario";
                }

            }
            return PartialView("Modal");
        }
        [HttpGet]
        public ActionResult Delete(int IdUsuario)
        {
            ML.Result result=BL.Usuario.Delete(IdUsuario);
            if (result.Correct)
            {
                ViewBag.Mensaje = "Se borro correctamente el usuario";
            }
            else
            {
                ViewBag.Mensaje = "No se pudo borrar el usuario";
            }
            return PartialView("Modal");
        }
    }
}