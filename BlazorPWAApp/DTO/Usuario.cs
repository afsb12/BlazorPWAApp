using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Usuario : Interface.IUsuario
    {

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _senha;

        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

    }
}
