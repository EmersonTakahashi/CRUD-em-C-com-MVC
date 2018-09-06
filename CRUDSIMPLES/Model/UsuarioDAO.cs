using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDSIMPLES.Bean;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace CRUDSIMPLES.Model
{
    public class UsuarioDAO
    {
        UsuarioBean ub = null;
        MySqlConnection con = null;
        public UsuarioDAO(UsuarioBean ub, MySqlConnection con)
        {
            this.ub = ub;
            this.con = con;
        }

        public void inserirUsuario()
        {
            try
            {

                MySqlCommand objCommand = new MySqlCommand("insert into tbl_usuario (nomeUsuario, email, celular, senha) values (?, ?, ?, ?)", con);
                objCommand.Parameters.Add("@nomeUsuario", MySqlDbType.VarChar, 100).Value = ub.NomeUsuario;
                objCommand.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = ub.Email;
                objCommand.Parameters.Add("@celular", MySqlDbType.Int32, 11).Value = ub.Celular;
                objCommand.Parameters.Add("@senha", MySqlDbType.VarChar, 16).Value = ub.Senha;

                objCommand.ExecuteNonQuery();

                MessageBox.Show("Usuário cadastrado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }catch(MySqlException e)
            {
                Console.Write("Erro no banco: " + e);
            }catch(Exception e)
            {
                Console.Write("Erro simples: " + e);
            }
        }

        public DataTable verDados()
        {
            DataTable dt = null;
            try
            {
                dt = new DataTable();

                MySqlDataAdapter da = new MySqlDataAdapter();   

                MySqlCommand objCommand = new MySqlCommand("select * from tbl_usuario", con);
                
                da.SelectCommand = objCommand;

                da.Fill(dt);
            }
            catch (MySqlException e)
            {
                Console.Write("Erro no banco: " + e);
            }
            catch (Exception e)
            {
                Console.Write("Erro simples: " + e);
            }

            return dt;

        }

        public DataTable filtrar()
        {
            DataTable dt = null;
            try
            {
                dt = new DataTable();

                MySqlDataAdapter da = new MySqlDataAdapter();

                MySqlCommand objCommand = new MySqlCommand("select * from tbl_usuario where nomeUsuario like ?", con);
                objCommand.Parameters.Add("@nomeUsuario", MySqlDbType.VarChar, 100).Value = ub.NomeUsuario + "%";

                da.SelectCommand = objCommand;

                da.Fill(dt);
            }
            catch (MySqlException e)
            {
                Console.Write("Erro no banco: " + e);
            }
            catch (Exception e)
            {
                Console.Write("Erro simples: " + e);
            }

            return dt;
        }

        public void alterarUsuario()
        {
            try
            {

                MySqlCommand objcommand = new MySqlCommand("update tbl_usuario set nomeUsuario = ?, email = ?, celular = ?, senha = ? where cod_usuario = ?", con);
                objcommand.Parameters.Add("@nomeUsuario", MySqlDbType.VarChar, 100).Value = ub.NomeUsuario;
                objcommand.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = ub.Email;
                objcommand.Parameters.Add("@celular", MySqlDbType.Int32, 11).Value = ub.Celular;
                objcommand.Parameters.Add("@senha", MySqlDbType.VarChar, 16).Value = ub.Senha;
                objcommand.Parameters.Add("@cod_usuario", MySqlDbType.Int32).Value = ub.Cod;

                objcommand.ExecuteNonQuery();
                                
                MessageBox.Show("Usuário foi alterado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException e)
            {
                Console.Write("Erro no banco: " + e);

            }
            catch (Exception e)
            {
                Console.Write("Erro simples: " + e);

            }

        }

        public void excluirUsuario()
        {
            try
            {
                MySqlCommand objcommand = new MySqlCommand("delete from tbl_usuario where cod_usuario = ?", con);
                objcommand.Parameters.Add("@cod_usuario", MySqlDbType.Int32).Value = ub.Cod;

                objcommand.ExecuteNonQuery();

                MessageBox.Show("Usuário foi removido com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
            {
                Console.Write("Erro no banco: " + e);

            }
            catch (Exception e)
            {
                Console.Write("Erro simples: " + e);

            }

        }
    }
}
