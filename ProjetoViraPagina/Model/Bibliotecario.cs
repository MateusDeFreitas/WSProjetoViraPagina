using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ViraPagina.Model
{
    class Bibliotecario
    {
        private int id;
        private string email;
        private string senha;
        private bool bloqueado;
        private DateTime dataBloqueio;
        private int tentativasLogin;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public bool Bloqueado
        {
            get { return bloqueado; }
            set { bloqueado = value; }
        }

        public DateTime DataBloqueio
        {
            get { return dataBloqueio; }
            set { dataBloqueio = value; }
        }

        public int TentativasLogin
        {
            get { return tentativasLogin; }
            set { tentativasLogin = value; }
        }
    }
}
