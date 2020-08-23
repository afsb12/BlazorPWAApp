using System;
using System.Collections.Generic;
using System.Text;
using WebAssembly.Core;

namespace Interface
{
    public interface IUsuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
