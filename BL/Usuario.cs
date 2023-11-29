using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Usuario
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.MSandovalExamenConsolaEntities1 context=new DL.MSandovalExamenConsolaEntities1())
                {
                    var query = context.UsuarioGetAll().ToList();
                    result.Objects = new List<object>();
                    foreach (var row in query)
                    {
                        ML.Usuario usuario = new ML.Usuario();
                        usuario.IdUsuario =row.IdUsuario;
                        usuario.Nombre = row.Nombre;
                        usuario.Altura = float.Parse(row.Altura.ToString());
                        //usuario.Genero = row.Genero;
                        result.Objects.Add(usuario);
                        
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex=ex;
            }
            return result;
        }
        public static ML.Result GetById(int IdUsuario)
        {
            ML.Result result=new ML.Result();
            try
            {
                using (DL.MSandovalExamenConsolaEntities1 context=new DL.MSandovalExamenConsolaEntities1())
                {
                    var query = context.UsuarioGetById(IdUsuario).First();
                    
                    ML.Usuario usuario=new ML.Usuario();
                    usuario.IdUsuario=query.IdUsuario;
                    usuario.Nombre = query.Nombre;
                    usuario.Altura = float.Parse(query.Altura.ToString());
                    //usuario.Genero=char.Parse(query.Genero.ToString());
                    result.Object=usuario;
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage=ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result Add(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.MSandovalExamenConsolaEntities1 context=new DL.MSandovalExamenConsolaEntities1())
                {
                    var query = context.UsuarioAdd(usuario.Nombre,usuario.Altura,usuario.Genero.ToString());
                    if (query>0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct=false;
                        result.ErrorMessage = "No se pudo registrar el usuario";
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct=false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result ;
        }
        public static ML.Result Update(ML.Usuario usuario)
        {
            ML.Result result=new ML.Result();
            try
            {
                using (DL.MSandovalExamenConsolaEntities1 context=new DL.MSandovalExamenConsolaEntities1())
                {
                    var query = context.UsuarioUpdate(usuario.IdUsuario,usuario.Nombre, usuario.Altura, usuario.Genero.ToString());
                    if (query>0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct=false ;
                        result.ErrorMessage = "No se pudo actualizar el usuario";
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;                
            }
            return result;
        }
        public static ML.Result Delete(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.MSandovalExamenConsolaEntities1 context=new DL.MSandovalExamenConsolaEntities1())
                {
                    var query = context.UsuarioDelete(IdUsuario);
                    if (query>1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct=false ;
                        result.ErrorMessage = "No se pudo eliminar el usuario";
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {

                result.Correct = false;
                result.ErrorMessage=ex.Message;
                result.Ex = ex;
            }
            return result;
        }
    }
}
