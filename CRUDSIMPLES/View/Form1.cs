using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDSIMPLES.Bean;
using CRUDSIMPLES.Controller;

using MySql.Data.MySqlClient;
namespace CRUDSIMPLES
{
    public partial class Form1 : Form
    {
        UsuarioBean ub = null;
        UsuarioController uc = null;
        public Form1()
        {
            InitializeComponent();
            ub = new UsuarioBean();
            uc = new UsuarioController(ub);

            this.carregarTabela();

        }

        public void carregarTabela()
        {
            tbl_usuarios.DataSource = uc.verDados();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_nome.Text) && !String.IsNullOrEmpty(txt_email.Text) && !String.IsNullOrEmpty(txt_celular.Text)  && !String.IsNullOrEmpty(txt_senha.Text))
            {
                ub.NomeUsuario = txt_nome.Text;
                ub.Email = txt_email.Text;
                ub.Celular = int.Parse(txt_celular.Text);
                ub.Senha = txt_senha.Text;

                uc.inserirUsuario();
                this.limpar();
                this.carregarTabela();
            }else
            {
                MessageBox.Show("É necessário inserir todos os dados solicitados, por favor preencha corretamente!", "Atenção" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void tbl_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_cod.Text = tbl_usuarios.CurrentRow.Cells[0].Value.ToString();
            txt_nome.Text = tbl_usuarios.CurrentRow.Cells[1].Value.ToString();
            txt_email.Text = tbl_usuarios.CurrentRow.Cells[2].Value.ToString();
            txt_celular.Text = tbl_usuarios.CurrentRow.Cells[3].Value.ToString();
            txt_senha.Text = tbl_usuarios.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja alterar os dados selecionados?", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ub.Cod = int.Parse(txt_cod.Text);
                ub.NomeUsuario = txt_nome.Text;
                ub.Email = txt_email.Text;
                ub.Celular = int.Parse(txt_celular.Text);
                ub.Senha = txt_senha.Text;

                uc.alterarUsuario();
                this.carregarTabela();
            }
            else
            {
                MessageBox.Show("Os dados não foram alterados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o usuário permanentemente?", "Excluir usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                ub.Cod = int.Parse(txt_cod.Text);

                uc.excluirUsuario();
                this.limpar();
                this.carregarTabela();
            }
            else
            {
                MessageBox.Show("O usuário selecionado não foi removido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void limpar()
        {
            txt_cod.Text = "";
            txt_nome.Text = "";
            txt_email.Text = "";
            txt_celular.Text = "";
            txt_senha.Text = "";
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            this.limpar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_celular.MaxLength = 9;
        }

        private void txt_celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

        }

        public void filtrar()
        {
            ub.NomeUsuario = txt_filtro.Text;
            tbl_usuarios.DataSource = uc.filtrar();
        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            this.filtrar();
        }

        private void txt_filtro_Leave(object sender, EventArgs e)
        {
            txt_filtro.Text = "";
        }
    }
}
