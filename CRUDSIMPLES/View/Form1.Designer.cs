namespace CRUDSIMPLES
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_celular = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.tbl_usuarios = new System.Windows.Forms.DataGridView();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.txt_filtro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciamento de usuários";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome de usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Senha:";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(187, 117);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(260, 26);
            this.txt_nome.TabIndex = 5;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(187, 156);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(260, 26);
            this.txt_email.TabIndex = 6;
            // 
            // txt_celular
            // 
            this.txt_celular.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_celular.Location = new System.Drawing.Point(187, 191);
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(260, 26);
            this.txt_celular.TabIndex = 7;
            this.txt_celular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_celular_KeyPress);
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(187, 225);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(260, 26);
            this.txt_senha.TabIndex = 8;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Location = new System.Drawing.Point(432, 277);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(121, 50);
            this.btn_cadastrar.TabIndex = 9;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.Location = new System.Drawing.Point(292, 277);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(111, 50);
            this.btn_remover.TabIndex = 10;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.Location = new System.Drawing.Point(151, 277);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(107, 50);
            this.btn_alterar.TabIndex = 11;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // tbl_usuarios
            // 
            this.tbl_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_usuarios.Location = new System.Drawing.Point(12, 384);
            this.tbl_usuarios.Name = "tbl_usuarios";
            this.tbl_usuarios.ReadOnly = true;
            this.tbl_usuarios.Size = new System.Drawing.Size(545, 177);
            this.tbl_usuarios.TabIndex = 12;
            this.tbl_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_usuarios_CellContentClick);
            // 
            // txt_cod
            // 
            this.txt_cod.AllowDrop = true;
            this.txt_cod.Enabled = false;
            this.txt_cod.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod.Location = new System.Drawing.Point(187, 78);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(260, 26);
            this.txt_cod.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "código usuário:";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(12, 277);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(105, 50);
            this.btn_limpar.TabIndex = 15;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // txt_filtro
            // 
            this.txt_filtro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtro.Location = new System.Drawing.Point(187, 345);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(370, 26);
            this.txt_filtro.TabIndex = 16;
            this.txt_filtro.TextChanged += new System.EventHandler(this.txt_filtro_TextChanged);
            this.txt_filtro.Leave += new System.EventHandler(this.txt_filtro_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Pesquisar por nome:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 573);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbl_usuarios);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_celular);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gerenciamento de usuários";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_celular;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.DataGridView tbl_usuarios;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.TextBox txt_filtro;
        private System.Windows.Forms.Label label7;
    }
}

