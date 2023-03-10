using System.Data;
using System.Data.SqlClient;

namespace mini_projeto
{
    public partial class frm_categoria : Form
    {

        // private void testeconexao();
        //SqlConnection conn = new SqlConnection();





        //Variável publica para conexão fica aqui
        string stringconexao = "" +
          "Data Source=localhost;" +
          "initial catalog = n8_miniprojeto;" +
          "User ID= sa;" +
          "Password =123456";
        //------------------------------------------------------
        private void testeconexao()

        {
            SqlConnection conn = new SqlConnection(stringconexao);
            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex )
            {
                MessageBox.Show("Erro "+ ex.ToString());
                Application.Exit();
                
            }
        }
        




        public frm_categoria()
        {
            InitializeComponent();
        }

        private void frm_categoria_Load(object sender, EventArgs e)
        {
            testeconexao();
        }
        //Botão cadastrar ta funcionando.
        private void bto_cadastrar_Click(object sender, EventArgs e)
        {
            string sql = "insert into categoria " + "(" +
                "nome_categoria, " +
                "descricao_categoria, " +
                "obs_categoria, " +
                "status_categoria " +
                ") values (" +
                "'" + txt_nome_cat.Text + "'," +
                "'" + txt_desc.Text + "'," +
                "'" + txt_obs.Text + "'," + 
                "'" + cbo_status.Text + "'" + ")";
             SqlConnection conn = new SqlConnection(stringconexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            //----------------------------------------------------------------

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
                MessageBox.Show("Erro " + ex.Message);
            }

            finally
            {
                conn.Close();
            }






        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Botão limpar funcionando
        private void bto_limpar_Click(object sender, EventArgs e)
        {
            txt_nome_cat.Text = "";
            txt_desc.Text = "";
            cbo_status.SelectedIndex = -1;
        }


        //Botão excluir ta funcionando
        private void bto_excluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from categoria where id_categoria = " + txt_cod.Text;


            SqlConnection conn = new SqlConnection(stringconexao);
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Dados excluidos com sucesso!");
                    bto_limpar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " +ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void bto_pesquisar_Click(object sender, EventArgs e)
        {
            string sql = "select * from categoria where id_categoria =" + txt_cod.Text;
            
            SqlConnection conn = new SqlConnection(stringconexao);
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conn.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txt_cod.Text = reader [0].ToString();
                    txt_nome_cat.Text = reader[1].ToString();
                    txt_desc.Text = reader[2].ToString();
                    txt_obs.Text = reader[3].ToString();
                    cbo_status.Text = reader[4].ToString().Trim();
                }
                else
                {
                    MessageBox.Show("Código inexistente!");
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
             //Botão pesquisar está funcionando.
        }

        private void bto_alterar_Click(object sender, EventArgs e)
        {

            //problema drop down list resolver 
            string sql = "update categoria set " +
               "nome_categoria= '" + txt_nome_cat.Text + "'," +
               "descricao_categoria= '" + txt_desc.Text + "'," +
               "obs_categoria= '" + txt_obs.Text + "'," +
                 "status_categoria = '" + cbo_status.Text + "' " +
               //  "status_categoria= ' " + cbo_status.Text + "'" +
               //"status_categoria= '" + cbo_status.SelectedIndex + "'" +
               "where id_categoria=" + txt_cod.Text;

            SqlConnection conn = new SqlConnection(stringconexao);
            SqlCommand cmd = new SqlCommand (sql,conn);
            cmd.CommandType = CommandType.Text;

            try
            {
                conn.Open();

                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Dados alterados com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void cbo_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
