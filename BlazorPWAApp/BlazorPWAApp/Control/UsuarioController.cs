using DAL;
using DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private UsuarioContext _usuarioContext;
        public UsuarioController(UsuarioContext usuarioContext)
        {
            _usuarioContext = usuarioContext;
        }

        // Get api/usuario
        [HttpGet("")]
        public ActionResult<List<Usuario>> GetUsuario()
        {
            return _usuarioContext.Usuarios.ToList();
        }

        // Get api/usuario/id
        [HttpGet("{Id}")]
        public ActionResult<Usuario> GetUsuarioById(int pId)
        {
            return _usuarioContext.Usuarios.FirstOrDefault(Usuario => Usuario.Id == pId);
        }

        // Get api/usuario
        [HttpPost("")]
        public Usuario PostUsuario(Usuario pUsuario)
        {
            _usuarioContext.Usuarios.Add(pUsuario);
            _usuarioContext.SaveChanges();
            return pUsuario;
        }

        [HttpPut("{Id")]
        public Usuario PutUsuario(int pId,Usuario pUsuario)
        {
            Usuario NovoUsuario = _usuarioContext.Usuarios.FirstOrDefault(Usuario => Usuario.Id == pId);
            NovoUsuario.Nome = pUsuario.Nome;
            NovoUsuario.Senha = pUsuario.Senha;
            NovoUsuario.Email = pUsuario.Email;
            _usuarioContext.SaveChanges();
            return NovoUsuario;
        }

        [HttpDelete("{Id")]
        public void DeleteUsuario(int pId)
        {
            Usuario UsuarioAntigo = _usuarioContext.Usuarios.FirstOrDefault(Usuario => Usuario.Id == pId);
            _usuarioContext.Usuarios.Remove(UsuarioAntigo);
        }

    }
}
