using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using apiweb.Models;



namespace apiweb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {

        private readonly Usuario usuario = new Usuario("ites", "1234");

        public UsuarioController()
        {


        }



        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> Get()
        {
            return Ok(usuario);
        }
        [HttpPost]
        public ActionResult<bool> Verificar(string Username, string Pass)
        {
            if (Username == usuario.Username && Pass == usuario.Pass)
            {
                return Ok(true);
            }
            else
            {
                return Ok(false);
            }


        }
    }
}