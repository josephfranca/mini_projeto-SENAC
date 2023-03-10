using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_projeto
{
    public partial class frm_cat_prod : Form
    {

        string stringconexao = frm_login.stringconexao;


        private void testeconexao()
        {

            try
            {
                SqlConnection conn = new SqlConnection(stringconexao);
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();                
            }
        }

        private void carregarcombocategoria()
        {
            string sql = "select id_categoria, nome_categoria from categoria";

            SqlConnection conn = new SqlConnection(stringconexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            DataTable dt = new DataTable();
            conn.Open();
            try
            {
                leitura = cmd.ExecuteReader();
                dt.Load(leitura);


                cbo_nome_cat.DisplayMember = "nome_categoria";
                cbo_nome_cat.DataSource = dt;                
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


        


        public frm_cat_prod()
        {
            InitializeComponent();
        }

        private void frm_cat_prod_Load(object sender, EventArgs e)
        {
            testeconexao();
            carregarcombocategoria();
        }

        private void bto_limpar_Click(object sender, EventArgs e)
        {
            txt_nome_prod.Text = "";
            cbo_nome_cat.SelectedIndex = -1;
            txt_cat_prod.Text = "";
            cbo_id_prod.SelectedIndex = -1;
            cbo_id_cat.SelectedIndex = -1;
            txt_obs.Text = "";
            txt_qtde.Text = "";
            cbo_unidade.SelectedIndex = -1;
            txt_valor_custo.Text = "";
            txt_valor_venda.Text = "";
            cbo_status.SelectedIndex = -1;
            txt_peso.Text = "";
        }

        private void bto_cadastrar_Click(object sender, EventArgs e)
        {
            if (txt_nome_prod.Text.Trim() == "")
            {
                MessageBox.Show("Erro, verfique que todos os campos estejam preenchidos 1");
                txt_nome_prod.Text = "";
                Focus();
                return;
            }
            if (cbo_nome_cat.SelectedIndex == -1) 
            {
                MessageBox.Show("Erro, verfique que todos os campos estejam preenchidos 2");
                cbo_nome_cat.SelectedIndex = -1;
                Focus();
                return;
            }
            if (txt_cat_prod.Text.Trim() == "")
            {
                MessageBox.Show("Erro, verfique que todos os campos estejam preenchidos 3");
                txt_cat_prod.Text = "";
                Focus();
                return;
            }

       //     if (cbo_id_prod.SelectedIndex == -1) 
            {
                //essageBox.Show("Erro, verfique que todos os campos estejam preenchidos 4");
                //cbo_id_prod.SelectedIndex = -1;
               //   Focus();
           //     return;
             }

            if (txt_qtde.Text.Trim() == "")
            {
                MessageBox.Show("Erro, verfique que todos os campos estejam preenchidos 5");
                txt_qtde.Text = "";
                Focus();
                return;
            }

            if (cbo_unidade.SelectedIndex == -1) 
            {
                MessageBox.Show("Erro, verfique que todos os campos estejam preenchidos 6");
                cbo_unidade.SelectedIndex = -1;
                Focus();
                return;
            }

            if (txt_valor_custo.Text.Trim() == "")
            {
                MessageBox.Show("Erro, verfique que todos os campos estejam preenchidos 7");
                txt_valor_custo.Text = "";
                Focus();
                return;
            }

            if (txt_valor_venda.Text.Trim() == "")
            {
                MessageBox.Show("Erro, verfique que todos os campos estejam preenchidos 8");
                txt_valor_venda.Text = "";
                Focus();
                return;
            }

            if (cbo_status.SelectedIndex == -1)
            {
                MessageBox.Show("Erro, verfique que todos os campos estejam preenchidos 9");
                cbo_status.SelectedIndex = -1;
                Focus();
                return;
            }

            string sql = "insert into produto " +
                "(" +
                    "id_categoria_produto," +
                    "nome_produto," +
                    "qtde_produto," +
                    "peso_produto," +
                    "unidade_produto," +
                    "valorcusto_produto," +
                    "valorvenda_produto," +
                    "obs_produto," +
                    "status_produto" +
                ")values(" +
                    "" + cbo_id_cat.Text + "," +
                    "'" + txt_nome_prod.Text + "'," +
                    "" + txt_qtde.Text + "," +
                    "" + txt_peso.Text.Replace(",", ".") + "," +
                    "'" + cbo_unidade.Text + "'," +
                    "" + txt_valor_custo.Text.Replace(",", ".") + "," +
                    "" + txt_valor_venda.Text.Replace(",", ".") + "," +
                    "'" + txt_obs.Text + "'," +
                    "'" + cbo_status.Text + "'" +
                ")Select SCOPE_IDENTITY()";

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
                    bto_limpar.PerformClick();
                    MessageBox.Show("Cadastro Realizado com sucesso");
                    txt_cod.Text =leitura[0].ToString();
                    bto_pesquisar.PerformClick();
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

            private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from produto where id_produto =" + txt_cod.Text;

            SqlConnection conn = new SqlConnection(stringconexao);
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conn.Open();

            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {
                    txt_cod.Text = leitura[0].ToString();
                    cbo_id_cat.Text =leitura[1].ToString();
                    txt_nome_prod.Text =leitura[2].ToString();
                    txt_qtde.Text = leitura[3].ToString();
                    txt_peso.Text =leitura[4].ToString();
                    cbo_unidade.Text =leitura[5].ToString();
                    mtxt_cadastro.Text =leitura[6].ToString();
                    txt_valor_custo.Text =leitura[7].ToString();
                    txt_valor_venda.Text =leitura[8].ToString();
                    txt_obs.Text =leitura[9].ToString();
                    cbo_status.Text = leitura[10].ToString();
                }
                else
                {
                    MessageBox.Show("Nenhum produto com esse código foi encontrado!");
                    bto_limpar.PerformClick();
                    txt_cod.Focus();
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

        private void bto_excluir_Click(object sender, EventArgs e)
        {
            string sql = "delete produto where id_produto =" + txt_cod.Text;

            SqlConnection conn = new SqlConnection(stringconexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
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
                else
                {
                    MessageBox.Show("Erro, não foi possivel excluir esse código");
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

        private void bto_alterar_Click(object sender, EventArgs e)
        {
            string sql = "update produto set" +
                  "id_categoria_produto = " + cbo_id_cat.Text + "," +
                "nome_produto = '" + txt_nome_prod.Text + "'," +
                "qtde_produto = " + txt_qtde.Text + "," +
                "peso_produto = " + txt_peso.Text.Replace(",", ".") + "," +
                "unidade_produto = '" + cbo_unidade.Text + "'," +
                "valorcusto_produto = " + txt_valor_custo.Text.Replace(",", ".") + "," +
                "valorvenda_produto = " + txt_valor_venda.Text.Replace(",", ".") + "," +
                "obs_produto = '" + txt_obs.Text + "'," +
                "status_produto = '" + cbo_status.Text + "' " +
                "where id_produto = " + txt_cod.Text;

            SqlConnection conn = new SqlConnection(stringconexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Dados alterados com sucesso!");
                    bto_pesquisar.PerformClick();
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
    }
}
