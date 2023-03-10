namespace mini_projeto
{
    partial class frm_cad_user
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbo_cod_pesq = new System.Windows.Forms.GroupBox();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.bto_pesquisar = new System.Windows.Forms.Button();
            this.lbl_cod = new System.Windows.Forms.Label();
            this.gbo_campos = new System.Windows.Forms.GroupBox();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.lbl_obs = new System.Windows.Forms.Label();
            this.cbo_status = new System.Windows.Forms.ComboBox();
            this.mtxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.gbo_botoes = new System.Windows.Forms.GroupBox();
            this.bto_add2 = new System.Windows.Forms.Button();
            this.bto_sair = new System.Windows.Forms.Button();
            this.bto_excluir = new System.Windows.Forms.Button();
            this.bto_limpar = new System.Windows.Forms.Button();
            this.bto_alterar = new System.Windows.Forms.Button();
            this.bto_cadastrar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.gbo_cod_pesq.SuspendLayout();
            this.gbo_campos.SuspendLayout();
            this.gbo_botoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbo_cod_pesq
            // 
            this.gbo_cod_pesq.Controls.Add(this.txt_cod);
            this.gbo_cod_pesq.Controls.Add(this.bto_pesquisar);
            this.gbo_cod_pesq.Controls.Add(this.lbl_cod);
            this.gbo_cod_pesq.Location = new System.Drawing.Point(12, 12);
            this.gbo_cod_pesq.Name = "gbo_cod_pesq";
            this.gbo_cod_pesq.Size = new System.Drawing.Size(655, 93);
            this.gbo_cod_pesq.TabIndex = 0;
            this.gbo_cod_pesq.TabStop = false;
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(68, 28);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(100, 23);
            this.txt_cod.TabIndex = 2;
            // 
            // bto_pesquisar
            // 
            this.bto_pesquisar.Location = new System.Drawing.Point(201, 28);
            this.bto_pesquisar.Name = "bto_pesquisar";
            this.bto_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.bto_pesquisar.TabIndex = 1;
            this.bto_pesquisar.Text = "...";
            this.bto_pesquisar.UseVisualStyleBackColor = true;
            this.bto_pesquisar.Click += new System.EventHandler(this.bto_pesquisar_Click);
            // 
            // lbl_cod
            // 
            this.lbl_cod.AutoSize = true;
            this.lbl_cod.Location = new System.Drawing.Point(6, 28);
            this.lbl_cod.Name = "lbl_cod";
            this.lbl_cod.Size = new System.Drawing.Size(46, 15);
            this.lbl_cod.TabIndex = 0;
            this.lbl_cod.Text = "Código";
            // 
            // gbo_campos
            // 
            this.gbo_campos.Controls.Add(this.txt_obs);
            this.gbo_campos.Controls.Add(this.lbl_obs);
            this.gbo_campos.Controls.Add(this.cbo_status);
            this.gbo_campos.Controls.Add(this.mtxt_cpf);
            this.gbo_campos.Controls.Add(this.txt_senha);
            this.gbo_campos.Controls.Add(this.txt_login);
            this.gbo_campos.Controls.Add(this.lbl_status);
            this.gbo_campos.Controls.Add(this.lbl_cpf);
            this.gbo_campos.Controls.Add(this.lbl_senha);
            this.gbo_campos.Controls.Add(this.lbl_login);
            this.gbo_campos.Controls.Add(this.txt_nome);
            this.gbo_campos.Controls.Add(this.lbl_nome);
            this.gbo_campos.Location = new System.Drawing.Point(18, 123);
            this.gbo_campos.Name = "gbo_campos";
            this.gbo_campos.Size = new System.Drawing.Size(649, 319);
            this.gbo_campos.TabIndex = 1;
            this.gbo_campos.TabStop = false;
            this.gbo_campos.Enter += new System.EventHandler(this.gbo_campos_Enter);
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(5, 197);
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(638, 122);
            this.txt_obs.TabIndex = 11;
            // 
            // lbl_obs
            // 
            this.lbl_obs.AutoSize = true;
            this.lbl_obs.Location = new System.Drawing.Point(9, 169);
            this.lbl_obs.Name = "lbl_obs";
            this.lbl_obs.Size = new System.Drawing.Size(69, 15);
            this.lbl_obs.TabIndex = 10;
            this.lbl_obs.Text = "Observação";
            // 
            // cbo_status
            // 
            this.cbo_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbo_status.Location = new System.Drawing.Point(492, 115);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(121, 23);
            this.cbo_status.TabIndex = 9;
            this.cbo_status.SelectedIndexChanged += new System.EventHandler(this.cbo_status_SelectedIndexChanged);
            // 
            // mtxt_cpf
            // 
            this.mtxt_cpf.Location = new System.Drawing.Point(299, 115);
            this.mtxt_cpf.Mask = "###.###.###-##";
            this.mtxt_cpf.Name = "mtxt_cpf";
            this.mtxt_cpf.Size = new System.Drawing.Size(100, 23);
            this.mtxt_cpf.TabIndex = 8;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(127, 115);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(100, 23);
            this.txt_senha.TabIndex = 7;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(0, 115);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(100, 23);
            this.txt_login.TabIndex = 6;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(492, 88);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(39, 15);
            this.lbl_status.TabIndex = 5;
            this.lbl_status.Text = "Status";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(317, 88);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(28, 15);
            this.lbl_cpf.TabIndex = 4;
            this.lbl_cpf.Text = "CPF";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(149, 88);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(39, 15);
            this.lbl_senha.TabIndex = 3;
            this.lbl_senha.Text = "Senha";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(10, 88);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(37, 15);
            this.lbl_login.TabIndex = 2;
            this.lbl_login.Text = "Login";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(0, 51);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(643, 23);
            this.txt_nome.TabIndex = 1;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(8, 33);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(40, 15);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // gbo_botoes
            // 
            this.gbo_botoes.Controls.Add(this.bto_add2);
            this.gbo_botoes.Controls.Add(this.bto_sair);
            this.gbo_botoes.Controls.Add(this.bto_excluir);
            this.gbo_botoes.Controls.Add(this.bto_limpar);
            this.gbo_botoes.Controls.Add(this.bto_alterar);
            this.gbo_botoes.Controls.Add(this.bto_cadastrar);
            this.gbo_botoes.Location = new System.Drawing.Point(12, 448);
            this.gbo_botoes.Name = "gbo_botoes";
            this.gbo_botoes.Size = new System.Drawing.Size(649, 100);
            this.gbo_botoes.TabIndex = 2;
            this.gbo_botoes.TabStop = false;
            // 
            // bto_add2
            // 
            this.bto_add2.Location = new System.Drawing.Point(6, 47);
            this.bto_add2.Name = "bto_add2";
            this.bto_add2.Size = new System.Drawing.Size(75, 23);
            this.bto_add2.TabIndex = 3;
            this.bto_add2.Text = "add2";
            this.bto_add2.UseVisualStyleBackColor = true;
            this.bto_add2.Click += new System.EventHandler(this.bto_add2_Click);
            // 
            // bto_sair
            // 
            this.bto_sair.Location = new System.Drawing.Point(568, 47);
            this.bto_sair.Name = "bto_sair";
            this.bto_sair.Size = new System.Drawing.Size(75, 23);
            this.bto_sair.TabIndex = 4;
            this.bto_sair.Text = "Sair";
            this.bto_sair.UseVisualStyleBackColor = true;
            this.bto_sair.Click += new System.EventHandler(this.bto_sair_Click);
            // 
            // bto_excluir
            // 
            this.bto_excluir.Location = new System.Drawing.Point(446, 47);
            this.bto_excluir.Name = "bto_excluir";
            this.bto_excluir.Size = new System.Drawing.Size(75, 23);
            this.bto_excluir.TabIndex = 3;
            this.bto_excluir.Text = "Excluir";
            this.bto_excluir.UseVisualStyleBackColor = true;
            this.bto_excluir.Click += new System.EventHandler(this.bto_excluir_Click);
            // 
            // bto_limpar
            // 
            this.bto_limpar.Location = new System.Drawing.Point(330, 47);
            this.bto_limpar.Name = "bto_limpar";
            this.bto_limpar.Size = new System.Drawing.Size(75, 23);
            this.bto_limpar.TabIndex = 2;
            this.bto_limpar.Text = "Limpar";
            this.bto_limpar.UseVisualStyleBackColor = true;
            this.bto_limpar.Click += new System.EventHandler(this.bto_limpar_Click);
            // 
            // bto_alterar
            // 
            this.bto_alterar.Location = new System.Drawing.Point(201, 47);
            this.bto_alterar.Name = "bto_alterar";
            this.bto_alterar.Size = new System.Drawing.Size(75, 23);
            this.bto_alterar.TabIndex = 1;
            this.bto_alterar.Text = "Alterar";
            this.bto_alterar.UseVisualStyleBackColor = true;
            this.bto_alterar.Click += new System.EventHandler(this.bto_alterar_Click);
            // 
            // bto_cadastrar
            // 
            this.bto_cadastrar.Location = new System.Drawing.Point(93, 47);
            this.bto_cadastrar.Name = "bto_cadastrar";
            this.bto_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bto_cadastrar.TabIndex = 0;
            this.bto_cadastrar.Text = "Cadastrar ";
            this.bto_cadastrar.UseVisualStyleBackColor = true;
            this.bto_cadastrar.Click += new System.EventHandler(this.bto_cadastrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txt_pesquisa);
            this.groupBox1.Location = new System.Drawing.Point(703, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 525);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(399, 364);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(26, 29);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(399, 23);
            this.txt_pesquisa.TabIndex = 0;
            this.txt_pesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frm_cad_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 560);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbo_botoes);
            this.Controls.Add(this.gbo_campos);
            this.Controls.Add(this.gbo_cod_pesq);
            this.Name = "frm_cad_user";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_cad_user_Load);
            this.gbo_cod_pesq.ResumeLayout(false);
            this.gbo_cod_pesq.PerformLayout();
            this.gbo_campos.ResumeLayout(false);
            this.gbo_campos.PerformLayout();
            this.gbo_botoes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbo_cod_pesq;
        private TextBox txt_cod;
        private Button bto_pesquisar;
        private Label lbl_cod;
        private GroupBox gbo_campos;
        private TextBox txt_obs;
        private Label lbl_obs;
        private ComboBox cbo_status;
        private MaskedTextBox mtxt_cpf;
        private TextBox txt_senha;
        private TextBox txt_login;
        private Label lbl_status;
        private Label lbl_cpf;
        private Label lbl_senha;
        private Label lbl_login;
        private TextBox txt_nome;
        private Label lbl_nome;
        private GroupBox gbo_botoes;
        private Button bto_sair;
        private Button bto_excluir;
        private Button bto_limpar;
        private Button bto_alterar;
        private Button bto_cadastrar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button bto_add2;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TextBox txt_pesquisa;
    }
}