using DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
    }
}
