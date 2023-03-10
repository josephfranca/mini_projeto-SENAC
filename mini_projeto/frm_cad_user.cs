using System.Data;
using System.Data.SqlClient;





namespace mini_projeto
{
    public partial class frm_cad_user : Form
    {

        //aqui vai ficar a v�riavel para a conex�o com o banco de dados
        string stringconexao = "" +
            "Data Source=localhost;" +
            "initial catalog = n8_miniprojeto;" +
            "User ID= sa;" +
            "Password =123456";
        //em initial catalog � sempre o nome do banco, lembre-se disso.

        public frm_cad_user()
        {
            InitializeComponent();
        }

        private void frm_cad_user_Load(object sender, EventArgs e)
        {
            testeconexao();
            carregar_grid_usuario();
        }

        private void testeconexao()
        {
            SqlConnection conn = new SqlConnection(stringconexao); //n�o esta funcionando, provavelmente(certeza 80%) porque esse private void est� sem refer�ncia.(o problema era que eu n�o estava com  a biblioteca atualizada)

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
                Application.Exit();

            }
        }

        private void bto_cadastrar_Click(object sender, EventArgs e)
        {

            //valida��es para caso tabelas importantes n�o seja preenchidadas
            //valida��o login
            if (txt_login.Text.Trim() == "")
            {
                MessageBox.Show("Erro, preencha o campo login");
                txt_login.Text = "";
                Focus();
                return;

            }
            //valida��o nome
            if (txt_nome.Text.Trim() == "")
            {
                MessageBox.Show("Erro, preencha o campo Nome");
                txt_nome.Text = "";
                Focus();
                return;
            }
            //valida��o senha
            if (txt_senha.Text.Trim() == "")
            {
                MessageBox.Show("Erro, preencha o campo senha");
                txt_senha.Text = "";
                Focus();
                return;
            }
            //valida��o CPF
            if (mtxt_cpf.Text.Trim() == "")
            {
                MessageBox.Show("Erro, preencha o campo CPF");
                mtxt_cpf.Text = "";
                Focus();
                return;
            }
            //valida��o status
            if (cbo_status.SelectedIndex == -1)
            {
                MessageBox.Show("Erro, escolha uma alternativa");
                cbo_status.SelectedIndex = -1;
                Focus();
                return;
            }


            string sql = "insert into usuario " + "(" +

              "nome_usuario, " +
            "login_usuario, " +
            "senha_usuario, " +
            "cpf_usuario, " +
            "obs_usuario, " +
            "status_usuario " +
            ") values (" +
            "'" + txt_nome.Text + "'," +                    //aspas simples no meio de aspas duplas +
            "'" + txt_login.Text + "'," +
            "'" + txt_senha.Text + "'," +
            "'" + mtxt_cpf.Text + "'," +
            "'" + txt_obs.Text + "'," +
            "'" + cbo_status.Text + "'" + ")";

            SqlConnection conn = new SqlConnection(stringconexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            //at� aqui ta tudo certo

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cadastro realizado com sucesso");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                //caso algo de errado essa mensagem aparece
            }
            finally
            {
                conn.Close();
            }
        }
        //Sistema para excluir dados da tabela, est� funcionando como deveria.
        private void bto_excluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from usuario where id_usuario = " + txt_cod.Text;
            //para excluir um usu�rio especifico basta colococar o id

            SqlConnection conexao = new SqlConnection(stringconexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;


            try
            {
                conexao.Open();
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Dados excluidos com sucesso.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            finally
            {
                conexao.Close();
            }


        }
        // O objetivo do bot�o add 2 � ser uma melhoria para o bot�o cadastrar, visto que essa nova vers�o agora vai mostrar a ID do usuario e limpar a tela.
        private void bto_add2_Click(object sender, EventArgs e)
        {
            //Valida��es


            if (txt_login.Text.Trim() == "")
            {
                MessageBox.Show("Erro, preencha o campo login");
                txt_login.Text = "";
                Focus();
                return;

            }
            //valida��o nome
            if (txt_nome.Text.Trim() == "")
            {
                MessageBox.Show("Erro, preencha o campo Nome");
                txt_nome.Text = "";
                Focus();
                return;
            }
            //valida��o senha
            if (txt_senha.Text.Trim() == "")
            {
                MessageBox.Show("Erro, preencha o campo senha");
                txt_senha.Text = "";
                Focus();
                return;
            }
            //valida��o CPF
            if (mtxt_cpf.Text.Trim() == "")
            {
                MessageBox.Show("Erro, preencha o campo CPF");
                mtxt_cpf.Text = "";
                Focus();
                return;
            }
            //valida��o status
            if (cbo_status.SelectedIndex == -1)
            {
                MessageBox.Show("Erro, escolha uma alternativa");
                cbo_status.SelectedIndex = -1;
                Focus();
                return;
            }

            string sql = "insert into usuario " + "(" +
                "nome_usuario, " +
                "login_usuario, " +
                "senha_usuario, " +
                "cpf_usuario," +
                "obs_usuario, " +
                "status_usuario" +
                  ") values (" +
                    "'" + txt_nome.Text + "'," +                    //aspas simples no meio de aspas duplas +
            "'" + txt_login.Text + "'," +
            "'" + txt_senha.Text + "'," +
            "'" + mtxt_cpf.Text + "'," +
            "'" + txt_obs.Text + "'," +
            "'" + cbo_status.Text + "'" +
            ") select scope_identity()";

            SqlConnection conn = new SqlConnection(stringconexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conn.Open();

            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {
                    MessageBox.Show("Cadastro realizado com sucesso", "C�digo gerado:  " + leitura[0].ToString());


                    bto_limpar.PerformClick();
                    MessageBox.Show("Id gerado - " + leitura[0].ToString());
                    txt_cod.Text = leitura[0].ToString();
                    bto_pesquisar.PerformClick();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }

            finally
            {
                conn.Close();
            }

            //O bot�o ADD2 ta funcionando como deveria.



        }
        //Bot�o Limpar funcionando.
        private void bto_limpar_Click(object sender, EventArgs e)
        {
            txt_cod.Text = "";
            txt_nome.Text = "";
            txt_login.Text = "";
            txt_senha.Text = "";
            mtxt_cpf.Text = "";
            cbo_status.SelectedIndex = -1;
            txt_obs.Text = "";
        }


        //bot�o pesquisar ta funcionando.
        private void bto_pesquisar_Click(object sender, EventArgs e)
        {

            //Bot�o pesquisar esta funcionando perfeitamente.
            string sql = "select * from usuario where id_usuario = " + txt_cod.Text;

            SqlConnection conn = new SqlConnection(stringconexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conn.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txt_cod.Text = reader[0].ToString();
                    txt_nome.Text = reader[1].ToString();
                    txt_login.Text = reader[2].ToString();
                    txt_senha.Text = reader[3].ToString();
                    mtxt_cpf.Text = reader[4].ToString();
                    txt_obs.Text = reader[5].ToString();
                    cbo_status.Text = reader[6].ToString();
                }
                else
                {
                    MessageBox.Show("C�digo inexistente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void bto_alterar_Click(object sender, EventArgs e)
        {
            if (txt_login.Text.Trim() == "")
            {
                MessageBox.Show("Erro, preencha o campo login");
                txt_login.Text = "";
                Focus();
                return;

            }
            //valida��o nome
            if (txt_nome.Text.Trim() == "")
            {
                MessageBox.Show("Erro, preencha o campo Nome");
                txt_nome.Text = "";
                Focus();
                return;
            }
            //valida��o senha
            if (txt_senha.Text.Trim() == "")
            {
                MessageBox.Show("Erro, preencha o campo senha");
                txt_senha.Text = "";
                Focus();
                return;
            }
            //valida��o CPF
            if (mtxt_cpf.Text.Trim() == "")
            {
                MessageBox.Show("Erro, preencha o campo CPF");
                mtxt_cpf.Text = "";
                Focus();
                return;
            }
            //valida��o status
            if (cbo_status.SelectedIndex == -1)
            {
                MessageBox.Show("Erro, escolha uma alternativa");
                cbo_status.SelectedIndex = -1;
                Focus();
                return;
            }


            string sql = "update usuario set " +
                "nome_usuario = '" + txt_nome.Text + "'," +
                "login_usuario = '" + txt_login.Text + "'," +
                "senha_usuario = '" + txt_senha.Text + "'," +
                "cpf_usuario = '" + mtxt_cpf.Text + "'," +
                "obs_usuario = '" + txt_obs.Text + "'," +
                "status_usuario = '" + cbo_status.Text + "' " +
                 "where id_usuario =" + txt_cod.Text;
            //-----------------------------------------------------------------------------------------
            // A tabela cpf est� dando erro de valor truncado, que significa que o valor est� acima ou abaixo visto que no sql ta char e n�o varchar.
            // a solu��o desse problema foi remover os espa�os das aspas, eles s�o caracteres que estavam ocupando espa�os que n�o deveriam
            SqlConnection conn = new SqlConnection(stringconexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Dados Alterados com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);

            }

            finally
            {
                conn.Close();
            }

        }
        //Bot�o sair funcionando
        private void bto_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gbo_campos_Enter(object sender, EventArgs e)
        {

        }

        private void carregar_grid_usuario()
        {
            string sql = "select " +
            "id_usuario as 'id'," +
            "nome_usuario as 'nome', " +
            "login_usuario as 'login', " +
            "cpf_usuario as 'cpf', " +
            "status_usuario as 'status'" +
            "from usuario where nome_usuario like '%" + txt_pesquisa.Text + "%'";


            SqlConnection conn = new SqlConnection(stringconexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();

            try
            {
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView1.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);

            }

            finally
            {
                conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           carregar_grid_usuario();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_cod.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            bto_pesquisar.PerformClick();
        }

        private void cbo_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}