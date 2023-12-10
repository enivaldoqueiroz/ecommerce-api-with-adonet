using eCommerceApiWithAdoNet.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceApiWithAdoNet.Controllers
{
    /*
    CRUD

    GET - OBTER A LISTA DE USUARIOS.
    GET - OBTER O USUARIO PASSANDO O ID.
    POST - CADASTRAR UM USUARIO.
    PUT - ATUALIZAR UM USUARIO.
    DELETE - REMOVER UM USUARIO.

    METHOD HTTP: www.minhaapi.com.br/api/Usuarios
    www.minhaapi.com.br/api/Usuarios/2
    */

    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuariosController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult GetUsuarios()
        {
            return Ok(_usuarioRepository.GetUsuarios());
        }

        [HttpGet("{id}")]
        public IActionResult GetUsuairoById(int id)
        {
            var usuario = _usuarioRepository.GetUsuarioById(id);

            if (usuario == null)
                return NotFound();

            return Ok(usuario);
        }

        [HttpPost]


        [HttpPut]
        [HttpDelete]
    }
}

