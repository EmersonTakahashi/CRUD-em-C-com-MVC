using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDSIMPLES.Bean
{
    public class UsuarioBean
    {
        int cod;
        String nomeUsuario;
        String email;
        int celular;
        String senha;

        public string NomeUsuario
        {
            get
            {
                return nomeUsuario;
            }

            set
            {
                nomeUsuario = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public int Celular
        {
            get
            {
                return celular;
            }

            set
            {
                celular = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public int Cod
        {
            get
            {
                return cod;
            }

            set
            {
                cod = value;
            }
        }
    }
}
