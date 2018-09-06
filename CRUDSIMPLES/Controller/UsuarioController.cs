using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDSIMPLES.Bean;
using CRUDSIMPLES.Model;
using CRUDSIMPLES.Utilitarios;
using MySql.Data.MySqlClient;
using System.Data;

namespace CRUDSIMPLES.Controller
{
    public class UsuarioController
    {
        UsuarioBean ub = null;
        UsuarioDAO ud = null;

        public UsuarioController(UsuarioBean ub)
        {
            this.ub = ub;
            this.ud = new UsuarioDAO(ub, Conexao.abrirConexao());
        }

        public void inserirUsuario()
        {
            ud.inserirUsuario();

        }

        public DataTable verDados()
        {
            return ud.verDados(); 
        }
        
        public void alterarUsuario()
        {
            ud.alterarUsuario();
        }

        public void excluirUsuario()
        {
            ud.excluirUsuario();
        }

        public DataTable filtrar()
        {
            return ud.filtrar();
        }
    }
}
