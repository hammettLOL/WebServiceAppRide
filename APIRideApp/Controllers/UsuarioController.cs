using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using APIRideApp.Models;

namespace APIRideApp.Controllers
{
    public class UsuarioController : ApiController
    {
        [HttpPost]
        [Route("api/SignUp")]
        [ResponseType(typeof(bool))]

        public IHttpActionResult Get(UsuarioViewModel user)
        {

            try
            {
                using (var context = new DB_A2A6FC_maverick2Entities())
                {

                    Usuario usuario = new Usuario();
                    usuario.login = user.login;
                    usuario.password = user.password;
                    context.Usuario.Add(usuario);
                    context.SaveChanges();

                }

                return Ok(true);
            }
            catch (Exception e)
            {

                return NotFound();
            }


        }

        [HttpPost]
        [Route("api/SignIn")]
        [ResponseType(typeof(bool))]

        public IHttpActionResult Login(UsuarioViewModel user)
        {

            try
            {
                using (var context = new DB_A2A6FC_maverick2Entities())
                {


                  List<Usuario> list =  context.Usuario.ToList();

                    foreach (var item in list)
                    {
                        if(item.login == user.login && item.password == user.password)
                        {
                            return Ok(true);
                        }
                    }

                    return NotFound();


                }

                


            }
            catch (Exception e)
            {

                return NotFound();
            }


        }











    }

}








