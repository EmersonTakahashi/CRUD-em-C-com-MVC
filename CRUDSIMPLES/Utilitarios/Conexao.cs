using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CRUDSIMPLES.Utilitarios
{
    public class Conexao
    {
        public static MySqlConnection abrirConexao()
        {

            MySqlConnection con = null;

            try
            {
                con = new MySqlConnection("server=localhost; port=3306; userID=root; database=bd_crud; password=794886588");
                con.Open();
            }
            catch(MySqlException e)
            {
                Console.Write("Erro no banco: " + e);
            }
            catch(Exception e)
            {
                Console.Write("Erro: " + e);
            }
            return con;
        }

    }
}
