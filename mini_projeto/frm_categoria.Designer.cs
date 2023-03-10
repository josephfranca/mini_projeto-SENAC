namespace mini_projeto
{
    partial class frm_categoria
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome_cat = new System.Windows.Forms.TextBox();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.lbl_obs = new System.Windows.Forms.Label();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.bto_cadastrar = new System.Windows.Forms.Button();
            this.bto_alterar = new System.Windows.Forms.Button();
            this.bto_limpar = new System.Windows.Forms.Button();
            this.bto_excluir = new System.Windows.Forms.Button();
            this.bto_sair = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.cbo_status = new System.Windows.Forms.ComboBox();
            this.lbl_cod = new System.Windows.Forms.Label();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.bto_pesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(12, 44);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(92, 15);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome categoria";
            // 
            // txt_nome_cat
            // 
            this.txt_nome_cat.Location = new System.Drawing.Point(12, 62);
            this.txt_nome_cat.Name = "txt_nome_cat";
            this.txt_nome_cat.Size = new System.Drawing.Size(367, 23);
            this.txt_nome_cat.TabIndex = 1;
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Location = new System.Drawing.Point(12, 129);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(58, 15);
            this.lbl_desc.TabIndex = 2;
            this.lbl_desc.Text = "Descrição";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(12, 168);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(451, 107);
            this.txt_desc.TabIndex = 3;
            // 
            // lbl_obs
            // 
            this.lbl_obs.AutoSize = true;
            this.lbl_obs.Location = new System.Drawing.Point(12, 302);
            this.lbl_obs.Name = "lbl_obs";
            this.lbl_obs.Size = new System.Drawing.Size(69, 15);
            this.lbl_obs.TabIndex = 4;
            this.lbl_obs.Text = "Observação";
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(12, 333);
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(608, 83);
            this.txt_obs.TabIndex = 5;
            // 
            // bto_cadastrar
            // 
            this.bto_cadastrar.Location = new System.Drawing.Point(58, 481);
            this.bto_cadastrar.Name = "bto_cadastrar";
            this.bto_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bto_cadastrar.TabIndex = 6;
            this.bto_cadastrar.Text = "Cadastrar";
            this.bto_cadastrar.UseVisualStyleBackColor = true;
            this.bto_cadastrar.Click += new System.EventHandler(this.bto_cadastrar_Click);
            // 
            // bto_alterar
            // 
            this.bto_alterar.Location = new System.Drawing.Point(189, 481);
            this.bto_alterar.Name = "bto_alterar";
            this.bto_alterar.Size = new System.Drawing.Size(75, 23);
            this.bto_alterar.TabIndex = 7;
            this.bto_alterar.Text = "Alterar";
            this.bto_alterar.UseVisualStyleBackColor = true;
            this.bto_alterar.Click += new System.EventHandler(this.bto_alterar_Click);
            // 
            // bto_limpar
            // 
            this.bto_limpar.Location = new System.Drawing.Point(304, 481);
            this.bto_limpar.Name = "bto_limpar";
            this.bto_limpar.Size = new System.Drawing.Size(75, 23);
            this.bto_limpar.TabIndex = 8;
            this.bto_limpar.Text = "Limpar";
            this.bto_limpar.UseVisualStyleBackColor = true;
            this.bto_limpar.Click += new System.EventHandler(this.bto_limpar_Click);
            // 
            // bto_excluir
            // 
            this.bto_excluir.Location = new System.Drawing.Point(450, 481);
            this.bto_excluir.Name = "bto_excluir";
            this.bto_excluir.Size = new System.Drawing.Size(75, 23);
            this.bto_excluir.TabIndex = 9;
            this.bto_excluir.Text = "Excluir";
            this.bto_excluir.UseVisualStyleBackColor = true;
            this.bto_excluir.Click += new System.EventHandler(this.bto_excluir_Click);
            // 
            // bto_sair
            // 
            this.bto_sair.Location = new System.Drawing.Point(591, 481);
            this.bto_sair.Name = "bto_sair";
            this.bto_sair.Size = new System.Drawing.Size(75, 23);
            this.bto_sair.TabIndex = 10;
            this.bto_sair.Text = "Sair";
            this.bto_sair.UseVisualStyleBackColor = true;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(524, 195);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(39, 15);
            this.lbl_status.TabIndex = 11;
            this.lbl_status.Text = "Status";
            this.lbl_status.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbo_status
            // 
            this.cbo_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbo_status.Location = new System.Drawing.Point(524, 231);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(121, 23);
            this.cbo_status.TabIndex = 12;
            this.cbo_status.SelectedIndexChanged += new System.EventHandler(this.cbo_status_SelectedIndexChanged);
            // 
            // lbl_cod
            // 
            this.lbl_cod.AutoSize = true;
            this.lbl_cod.Location = new System.Drawing.Point(524, 42);
            this.lbl_cod.Name = "lbl_cod";
            this.lbl_cod.Size = new System.Drawing.Size(46, 15);
            this.lbl_cod.TabIndex = 13;
            this.lbl_cod.Text = "Código";
            this.lbl_cod.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(520, 62);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(100, 23);
            this.txt_cod.TabIndex = 14;
            // 
            // bto_pesquisar
            // 
            this.bto_pesquisar.Location = new System.Drawing.Point(639, 62);
            this.bto_pesquisar.Name = "bto_pesquisar";
            this.bto_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.bto_pesquisar.TabIndex = 15;
            this.bto_pesquisar.Text = "...";
            this.bto_pesquisar.UseVisualStyleBackColor = true;
            this.bto_pesquisar.Click += new System.EventHandler(this.bto_pesquisar_Click);
            // 
            // frm_categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.bto_pesquisar);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.lbl_cod);
            this.Controls.Add(this.cbo_status);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.bto_sair);
            this.Controls.Add(this.bto_excluir);
            this.Controls.Add(this.bto_limpar);
            this.Controls.Add(this.bto_alterar);
            this.Controls.Add(this.bto_cadastrar);
            this.Controls.Add(this.txt_obs);
            this.Controls.Add(this.lbl_obs);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.txt_nome_cat);
            this.Controls.Add(this.lbl_nome);
            this.Name = "frm_categoria";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_categoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_nome;
        private TextBox txt_nome_cat;
        private Label lbl_desc;
        private TextBox txt_desc;
        private Label lbl_obs;
        private TextBox txt_obs;
        private Button bto_cadastrar;
        private Button bto_alterar;
        private Button bto_limpar;
        private Button bto_excluir;
        private Button bto_sair;
        private Label lbl_status;
        private ComboBox cbo_status;
        private Label lbl_cod;
        private TextBox txt_cod;
        private Button bto_pesquisar;
    }
}