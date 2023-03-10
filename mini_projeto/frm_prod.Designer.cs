namespace mini_projeto
{
    partial class frm_prod
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_cadastro = new System.Windows.Forms.Label();
            this.lbl_data_cadastro = new System.Windows.Forms.Label();
            this.bto_pesquisa = new System.Windows.Forms.Button();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.lbl_cod = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbo_unidade = new System.Windows.Forms.ComboBox();
            this.lbl_unidade = new System.Windows.Forms.Label();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.txt_qtde = new System.Windows.Forms.TextBox();
            this.lbl_qtde = new System.Windows.Forms.Label();
            this.txt_nome_prod = new System.Windows.Forms.TextBox();
            this.lbl_nome_prod = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bto_sair = new System.Windows.Forms.Button();
            this.bto_excluir = new System.Windows.Forms.Button();
            this.bto_limpar = new System.Windows.Forms.Button();
            this.bto_alterar = new System.Windows.Forms.Button();
            this.bto_cadastrar = new System.Windows.Forms.Button();
            this.lbl_obs = new System.Windows.Forms.Label();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.cbo_cod_categoria = new System.Windows.Forms.ComboBox();
            this.cbo_nome_categoria = new System.Windows.Forms.ComboBox();
            this.cbo_status = new System.Windows.Forms.ComboBox();
            this.txt_valor_venda = new System.Windows.Forms.TextBox();
            this.txt_valor_custo = new System.Windows.Forms.TextBox();
            this.lbl_cod_categoria = new System.Windows.Forms.Label();
            this.lbl_nome_categoria = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_valor_venda = new System.Windows.Forms.Label();
            this.lbl_valor_custo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_cadastro);
            this.groupBox1.Controls.Add(this.lbl_data_cadastro);
            this.groupBox1.Controls.Add(this.bto_pesquisa);
            this.groupBox1.Controls.Add(this.txt_cod);
            this.groupBox1.Controls.Add(this.lbl_cod);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lbl_cadastro
            // 
            this.lbl_cadastro.BackColor = System.Drawing.Color.SkyBlue;
            this.lbl_cadastro.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lbl_cadastro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_cadastro.Location = new System.Drawing.Point(545, 51);
            this.lbl_cadastro.Name = "lbl_cadastro";
            this.lbl_cadastro.Size = new System.Drawing.Size(100, 23);
            this.lbl_cadastro.TabIndex = 4;
            // 
            // lbl_data_cadastro
            // 
            this.lbl_data_cadastro.AutoSize = true;
            this.lbl_data_cadastro.Location = new System.Drawing.Point(545, 18);
            this.lbl_data_cadastro.Name = "lbl_data_cadastro";
            this.lbl_data_cadastro.Size = new System.Drawing.Size(95, 15);
            this.lbl_data_cadastro.TabIndex = 3;
            this.lbl_data_cadastro.Text = "Data de cadastro";
            // 
            // bto_pesquisa
            // 
            this.bto_pesquisa.Location = new System.Drawing.Point(125, 47);
            this.bto_pesquisa.Name = "bto_pesquisa";
            this.bto_pesquisa.Size = new System.Drawing.Size(43, 23);
            this.bto_pesquisa.TabIndex = 2;
            this.bto_pesquisa.Text = "...";
            this.bto_pesquisa.UseVisualStyleBackColor = true;
            this.bto_pesquisa.Click += new System.EventHandler(this.bto_pesquisa_Click);
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(9, 48);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(100, 23);
            this.txt_cod.TabIndex = 1;
            this.txt_cod.TextChanged += new System.EventHandler(this.txt_cod_TextChanged);
            this.txt_cod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cod_KeyPress);
            // 
            // lbl_cod
            // 
            this.lbl_cod.AutoSize = true;
            this.lbl_cod.Location = new System.Drawing.Point(9, 19);
            this.lbl_cod.Name = "lbl_cod";
            this.lbl_cod.Size = new System.Drawing.Size(46, 15);
            this.lbl_cod.TabIndex = 0;
            this.lbl_cod.Text = "Código";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbo_unidade);
            this.groupBox2.Controls.Add(this.lbl_unidade);
            this.groupBox2.Controls.Add(this.txt_peso);
            this.groupBox2.Controls.Add(this.lbl_peso);
            this.groupBox2.Controls.Add(this.txt_qtde);
            this.groupBox2.Controls.Add(this.lbl_qtde);
            this.groupBox2.Controls.Add(this.txt_nome_prod);
            this.groupBox2.Controls.Add(this.lbl_nome_prod);
            this.groupBox2.Location = new System.Drawing.Point(3, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1056, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbo_unidade
            // 
            this.cbo_unidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_unidade.FormattingEnabled = true;
            this.cbo_unidade.Items.AddRange(new object[] {
            "Grama(g)",
            "Kilograma(Kg)",
            "Mililitros(ml)",
            "Litros(L)"});
            this.cbo_unidade.Location = new System.Drawing.Point(638, 47);
            this.cbo_unidade.Name = "cbo_unidade";
            this.cbo_unidade.Size = new System.Drawing.Size(121, 23);
            this.cbo_unidade.TabIndex = 7;
            // 
            // lbl_unidade
            // 
            this.lbl_unidade.AutoSize = true;
            this.lbl_unidade.Location = new System.Drawing.Point(708, 19);
            this.lbl_unidade.Name = "lbl_unidade";
            this.lbl_unidade.Size = new System.Drawing.Size(51, 15);
            this.lbl_unidade.TabIndex = 6;
            this.lbl_unidade.Text = "Unidade";
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(502, 47);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(52, 23);
            this.txt_peso.TabIndex = 5;
            this.txt_peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_peso_KeyPress);
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(522, 18);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(32, 15);
            this.lbl_peso.TabIndex = 4;
            this.lbl_peso.Text = "Peso";
            // 
            // txt_qtde
            // 
            this.txt_qtde.Location = new System.Drawing.Point(387, 47);
            this.txt_qtde.Name = "txt_qtde";
            this.txt_qtde.Size = new System.Drawing.Size(72, 23);
            this.txt_qtde.TabIndex = 3;
            this.txt_qtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qtde_KeyPress);
            // 
            // lbl_qtde
            // 
            this.lbl_qtde.AutoSize = true;
            this.lbl_qtde.Location = new System.Drawing.Point(390, 19);
            this.lbl_qtde.Name = "lbl_qtde";
            this.lbl_qtde.Size = new System.Drawing.Size(69, 15);
            this.lbl_qtde.TabIndex = 2;
            this.lbl_qtde.Text = "Quantidade";
            // 
            // txt_nome_prod
            // 
            this.txt_nome_prod.Location = new System.Drawing.Point(20, 47);
            this.txt_nome_prod.Name = "txt_nome_prod";
            this.txt_nome_prod.Size = new System.Drawing.Size(345, 23);
            this.txt_nome_prod.TabIndex = 1;
            // 
            // lbl_nome_prod
            // 
            this.lbl_nome_prod.AutoSize = true;
            this.lbl_nome_prod.Location = new System.Drawing.Point(20, 18);
            this.lbl_nome_prod.Name = "lbl_nome_prod";
            this.lbl_nome_prod.Size = new System.Drawing.Size(103, 15);
            this.lbl_nome_prod.TabIndex = 0;
            this.lbl_nome_prod.Text = "Nome do produto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bto_sair);
            this.groupBox3.Controls.Add(this.bto_excluir);
            this.groupBox3.Controls.Add(this.bto_limpar);
            this.groupBox3.Controls.Add(this.bto_alterar);
            this.groupBox3.Controls.Add(this.bto_cadastrar);
            this.groupBox3.Controls.Add(this.lbl_obs);
            this.groupBox3.Controls.Add(this.txt_obs);
            this.groupBox3.Controls.Add(this.cbo_cod_categoria);
            this.groupBox3.Controls.Add(this.cbo_nome_categoria);
            this.groupBox3.Controls.Add(this.cbo_status);
            this.groupBox3.Controls.Add(this.txt_valor_venda);
            this.groupBox3.Controls.Add(this.txt_valor_custo);
            this.groupBox3.Controls.Add(this.lbl_cod_categoria);
            this.groupBox3.Controls.Add(this.lbl_nome_categoria);
            this.groupBox3.Controls.Add(this.lbl_status);
            this.groupBox3.Controls.Add(this.lbl_valor_venda);
            this.groupBox3.Controls.Add(this.lbl_valor_custo);
            this.groupBox3.Location = new System.Drawing.Point(3, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1056, 298);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // bto_sair
            // 
            this.bto_sair.Location = new System.Drawing.Point(522, 238);
            this.bto_sair.Name = "bto_sair";
            this.bto_sair.Size = new System.Drawing.Size(75, 23);
            this.bto_sair.TabIndex = 16;
            this.bto_sair.Text = "Sair";
            this.bto_sair.UseVisualStyleBackColor = true;
            this.bto_sair.Click += new System.EventHandler(this.bto_sair_Click);
            // 
            // bto_excluir
            // 
            this.bto_excluir.Location = new System.Drawing.Point(390, 238);
            this.bto_excluir.Name = "bto_excluir";
            this.bto_excluir.Size = new System.Drawing.Size(75, 23);
            this.bto_excluir.TabIndex = 15;
            this.bto_excluir.Text = "Excluir";
            this.bto_excluir.UseVisualStyleBackColor = true;
            this.bto_excluir.Click += new System.EventHandler(this.bto_excluir_Click);
            // 
            // bto_limpar
            // 
            this.bto_limpar.Location = new System.Drawing.Point(273, 238);
            this.bto_limpar.Name = "bto_limpar";
            this.bto_limpar.Size = new System.Drawing.Size(75, 23);
            this.bto_limpar.TabIndex = 14;
            this.bto_limpar.Text = "Limpar";
            this.bto_limpar.UseVisualStyleBackColor = true;
            this.bto_limpar.Click += new System.EventHandler(this.bto_limpar_Click);
            // 
            // bto_alterar
            // 
            this.bto_alterar.Location = new System.Drawing.Point(158, 238);
            this.bto_alterar.Name = "bto_alterar";
            this.bto_alterar.Size = new System.Drawing.Size(75, 23);
            this.bto_alterar.TabIndex = 13;
            this.bto_alterar.Text = "Alterar";
            this.bto_alterar.UseVisualStyleBackColor = true;
            this.bto_alterar.Click += new System.EventHandler(this.bto_alterar_Click);
            // 
            // bto_cadastrar
            // 
            this.bto_cadastrar.Location = new System.Drawing.Point(45, 238);
            this.bto_cadastrar.Name = "bto_cadastrar";
            this.bto_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bto_cadastrar.TabIndex = 12;
            this.bto_cadastrar.Text = "Cadastrar";
            this.bto_cadastrar.UseVisualStyleBackColor = true;
            this.bto_cadastrar.Click += new System.EventHandler(this.bto_cadastrar_Click);
            // 
            // lbl_obs
            // 
            this.lbl_obs.AutoSize = true;
            this.lbl_obs.Location = new System.Drawing.Point(15, 113);
            this.lbl_obs.Name = "lbl_obs";
            this.lbl_obs.Size = new System.Drawing.Size(28, 15);
            this.lbl_obs.TabIndex = 11;
            this.lbl_obs.Text = "Obs";
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(6, 131);
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(655, 76);
            this.txt_obs.TabIndex = 10;
            // 
            // cbo_cod_categoria
            // 
            this.cbo_cod_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cod_categoria.FormattingEnabled = true;
            this.cbo_cod_categoria.Location = new System.Drawing.Point(616, 39);
            this.cbo_cod_categoria.Name = "cbo_cod_categoria";
            this.cbo_cod_categoria.Size = new System.Drawing.Size(121, 23);
            this.cbo_cod_categoria.TabIndex = 9;
            // 
            // cbo_nome_categoria
            // 
            this.cbo_nome_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_nome_categoria.FormattingEnabled = true;
            this.cbo_nome_categoria.Location = new System.Drawing.Point(479, 39);
            this.cbo_nome_categoria.Name = "cbo_nome_categoria";
            this.cbo_nome_categoria.Size = new System.Drawing.Size(121, 23);
            this.cbo_nome_categoria.TabIndex = 8;
            // 
            // cbo_status
            // 
            this.cbo_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Items.AddRange(new object[] {
            "ativo",
            "inativo"});
            this.cbo_status.Location = new System.Drawing.Point(306, 39);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(121, 23);
            this.cbo_status.TabIndex = 7;
            // 
            // txt_valor_venda
            // 
            this.txt_valor_venda.Location = new System.Drawing.Point(171, 39);
            this.txt_valor_venda.Name = "txt_valor_venda";
            this.txt_valor_venda.Size = new System.Drawing.Size(100, 23);
            this.txt_valor_venda.TabIndex = 6;
            this.txt_valor_venda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_venda_KeyPress);
            // 
            // txt_valor_custo
            // 
            this.txt_valor_custo.Location = new System.Drawing.Point(22, 39);
            this.txt_valor_custo.Name = "txt_valor_custo";
            this.txt_valor_custo.Size = new System.Drawing.Size(100, 23);
            this.txt_valor_custo.TabIndex = 5;
            this.txt_valor_custo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_custo_KeyPress);
            // 
            // lbl_cod_categoria
            // 
            this.lbl_cod_categoria.AutoSize = true;
            this.lbl_cod_categoria.Location = new System.Drawing.Point(616, 15);
            this.lbl_cod_categoria.Name = "lbl_cod_categoria";
            this.lbl_cod_categoria.Size = new System.Drawing.Size(116, 15);
            this.lbl_cod_categoria.TabIndex = 4;
            this.lbl_cod_categoria.Text = "Código da Categoria";
            // 
            // lbl_nome_categoria
            // 
            this.lbl_nome_categoria.AutoSize = true;
            this.lbl_nome_categoria.Location = new System.Drawing.Point(479, 15);
            this.lbl_nome_categoria.Name = "lbl_nome_categoria";
            this.lbl_nome_categoria.Size = new System.Drawing.Size(94, 15);
            this.lbl_nome_categoria.TabIndex = 3;
            this.lbl_nome_categoria.Text = "Nome Categoria";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(327, 18);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(39, 15);
            this.lbl_status.TabIndex = 2;
            this.lbl_status.Text = "Status";
            // 
            // lbl_valor_venda
            // 
            this.lbl_valor_venda.AutoSize = true;
            this.lbl_valor_venda.Location = new System.Drawing.Point(171, 15);
            this.lbl_valor_venda.Name = "lbl_valor_venda";
            this.lbl_valor_venda.Size = new System.Drawing.Size(84, 15);
            this.lbl_valor_venda.TabIndex = 1;
            this.lbl_valor_venda.Text = "Valor de venda";
            // 
            // lbl_valor_custo
            // 
            this.lbl_valor_custo.AutoSize = true;
            this.lbl_valor_custo.Location = new System.Drawing.Point(13, 18);
            this.lbl_valor_custo.Name = "lbl_valor_custo";
            this.lbl_valor_custo.Size = new System.Drawing.Size(81, 15);
            this.lbl_valor_custo.TabIndex = 0;
            this.lbl_valor_custo.Text = "Valor de custo";
            // 
            // frm_prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 625);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_prod";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_prod_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label lbl_cadastro;
        private Label lbl_data_cadastro;
        private Button bto_pesquisa;
        private TextBox txt_cod;
        private Label lbl_cod;
        private GroupBox groupBox2;
        private ComboBox cbo_unidade;
        private Label lbl_unidade;
        private TextBox txt_peso;
        private Label lbl_peso;
        private TextBox txt_qtde;
        private Label lbl_qtde;
        private TextBox txt_nome_prod;
        private Label lbl_nome_prod;
        private GroupBox groupBox3;
        private Label lbl_obs;
        private TextBox txt_obs;
        private ComboBox cbo_cod_categoria;
        private ComboBox cbo_nome_categoria;
        private ComboBox cbo_status;
        private TextBox txt_valor_venda;
        private TextBox txt_valor_custo;
        private Label lbl_cod_categoria;
        private Label lbl_nome_categoria;
        private Label lbl_status;
        private Label lbl_valor_venda;
        private Label lbl_valor_custo;
        private Button bto_sair;
        private Button bto_excluir;
        private Button bto_limpar;
        private Button bto_alterar;
        private Button bto_cadastrar;
    }
}