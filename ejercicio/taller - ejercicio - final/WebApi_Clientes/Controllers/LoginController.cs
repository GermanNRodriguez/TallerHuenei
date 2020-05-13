using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Taller.BussinesLogic;
using Taller.Domain;

namespace WebAPIClientes
{
    public class LoginController : ApiController
    {
        // POST api/<controller>
        public string Post([FromBody]Usuario usuario)
        {
            string result = "No implementado";

            Usuario user = new Usuario();

            List<Usuario> lista = UsuariosManager.Get();

            try
            {
                //Verifico si el usuario existe
                user = UsuariosManager.GetUno(usuario);
                if (user.NLogins >= 3)
                {
                    //Verifico que no tenga más de 3 intentos erroneos
                    result = "Usuario bloqueado";
                }
                else
                {
                    try
                    {
                        //Si llego a este punto significa que existe y no tiene más
                        // de 3 intentos erroneos
                        //Necesito el valor de logins para actualizar. Si es correcto, simplemente el valor 
                        //NO cambia
                        usuario.NLogins = user.NLogins;
                        UsuariosManager.Actualizar(usuario);
                        result = "Usuario autenticado";
                    }
                    catch { 
                        //Contraseña incorrecta
                        result = "Usuario o clave incorrecta"; 
                    }
                }

            } catch {
                //Es correcto el usuario pero incorrecta la contraseña
                result = "Usuario o clave incorrecta";
                user.NLogins = user.NLogins + 1;
                UsuariosManager.Actualizar(user);
            }
            return result;          
        }
    }
}