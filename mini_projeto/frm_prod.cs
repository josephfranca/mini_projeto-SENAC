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
    public partial class frm_prod : Form
    {
        public frm_prod()
        {
            InitializeComponent();
        }

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
        //volte aqui e coloque o void para carregar o datagrid




        private void frm_prod_Load(object sender, EventArgs e)
        {
            testeconexao();
            carregarcombocategoria();
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


                cbo_nome_categoria.DisplayMember = "nome_categoria";
                cbo_nome_categoria.DataSource = dt;

                cbo_cod_categoria.DisplayMember = "id_categoria";
                cbo_cod_categoria.DataSource = dt;
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





        private void bto_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bto_limpar_Click(object sender, EventArgs e)
        {
            txt_cod.Text = "";
            lbl_cadastro.Text = "";
            cbo_cod_categoria.SelectedIndex = -1;
            cbo_nome_categoria.SelectedIndex = -1;
            txt_nome_prod.Text = "";
            txt_qtde.Text = "";
            txt_peso.Text = "";
            cbo_unidade.SelectedIndex = -1;
            txt_valor_custo.Text = "";
            txt_valor_venda.Text = "";
            cbo_status.SelectedIndex = -1;
            txt_obs.Text = "";
            
        }

        private void bto_cadastrar_Click(object sender, EventArgs e)
        {
            //validações
            if (txt_nome_prod.Text.Trim() == "")
            {
                MessageBox.Show("O nome não pode ficar em branco");
                txt_nome_prod.Text = "";
                Focus();
                return;
            }

            if (txt_qtde.Text.Trim() == "")
            {
                MessageBox.Show("O campo quantidade não pode ficar em branco");
                txt_qtde.Text = "";
                Focus();
                return;
            }


            if (txt_peso.Text.Trim() == "")
            {
                MessageBox.Show("O campo peso não pode ficar em branco");
                txt_peso.Text = "";
                Focus();
                return;
            }

            if (cbo_unidade.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha uma unidade de medida ou de peso!");
                cbo_unidade.SelectedIndex = -1;
                Focus();
                return;
            }

            if (txt_valor_custo.Text.Trim() == "")
            {
                MessageBox.Show("Erro, insira o valor de custo");
                txt_valor_custo.Text = "";
                Focus();
                return;
            }

            if (txt_valor_venda.Text.Trim() == "")
            {
                MessageBox.Show("Erro, insira o valor de venda");
                txt_valor_venda.Text = "";
                Focus();
                return;
            }

            if (cbo_status.SelectedIndex == -1)
            {
                MessageBox.Show("Erro, informe o status do produto");
                cbo_status.SelectedIndex = -1;
                Focus();
                return;
            }

            if (cbo_cod_categoria.SelectedIndex == -1)
            {
                MessageBox.Show("Erro, no Código da categoria!");
                cbo_cod_categoria.SelectedIndex = -1;
                Focus();
                return;
            }

            //-----------------------------------------------------------------------------

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
                   "" + cbo_cod_categoria.Text + "," +
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
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    txt_cod.Text =leitura[0].ToString();
                    bto_pesquisa.PerformClick();
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
            //validações
            if (txt_nome_prod.Text.Trim() == "")
            {
                MessageBox.Show("O nome não pode ficar em branco");
                txt_nome_prod.Text = "";
                Focus();
                return;
            }

            if (txt_qtde.Text.Trim() == "")
            {
                MessageBox.Show("O campo quantidade não pode ficar em branco");
                txt_qtde.Text = "";
                Focus();
                return;
            }


            if (txt_peso.Text.Trim() == "")
            {
                MessageBox.Show("O campo peso não pode ficar em branco");
                txt_peso.Text = "";
                Focus();
                return;
            }

            if (cbo_unidade.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha uma unidade de medida ou de peso!");
                cbo_unidade.SelectedIndex = -1;
                Focus();
                return;
            }

            if (txt_valor_custo.Text.Trim() == "")
            {
                MessageBox.Show("Erro, insira o valor de custo");
                txt_valor_custo.Text = "";
                Focus();
                return;
            }

            if (txt_valor_venda.Text.Trim() == "")
            {
                MessageBox.Show("Erro, insira o valor de venda");
                txt_valor_venda.Text = "";
                Focus();
                return;
            }

            if (cbo_status.SelectedIndex == -1)
            {
                MessageBox.Show("Erro, informe o status do produto");
                cbo_status.SelectedIndex = -1;
                Focus();
                return;
            }

            if (cbo_cod_categoria.SelectedIndex == -1)
            {
                MessageBox.Show("Erro, no Código da categoria!");
                cbo_cod_categoria.SelectedIndex = -1;
                Focus();
                return;
            }

            //----------------------------------------------


            //-------------- aqui ta no lugar errado essa string de update deve ficar em alterar, problema resolvido.
            string sql = "update produto set " +
                 "id_categoria_produto = " + cbo_cod_categoria.Text + "," +
                 "nome_produto = '" + txt_nome_prod.Text + "," +
                 "qtde_produto = " + txt_qtde.Text + "," +
                 "peso_produto = " + txt_peso.Text.Replace(",", ".") + "," +
                 "unidade_produto = '" + cbo_unidade.Text + "'," +
                 "valorcusto_produto =" + txt_valor_venda.Text.Replace(",", ".") + "," +
                 "valorvenda_produto =" + txt_valor_venda.Text.Replace(",", ".") + "," +
                       "obs_produto = '" + txt_obs.Text + "'," +
                     "status_produto = '" + cbo_status.Text + "'" +
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
                    bto_pesquisa.PerformClick();
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

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
                    MessageBox.Show("Não foi possível excluir esse código");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }


        }

        private void txt_peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }

            //O código acima é de extrema importância, visto que ele bloqueia teclas indesejadas a partir de um evento.
        }

        private void txt_qtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_valor_custo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_cod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_valor_venda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_cod_TextChanged(object sender, EventArgs e)
        {

        }

        private void bto_pesquisa_Click(object sender, EventArgs e)
        {
            string sql = "select * from produto where id_produto =" + txt_cod.Text;

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
                    txt_cod.Text = leitura[0].ToString();
                    cbo_cod_categoria.Text = leitura[1].ToString();
                    txt_nome_prod.Text = leitura[2].ToString();
                    txt_qtde.Text = leitura[3].ToString();
                    txt_peso.Text = leitura[4].ToString();
                    cbo_unidade.Text = leitura[5].ToString();
                    lbl_cadastro.Text = leitura[6].ToString();
                    txt_valor_custo.Text = leitura[7].ToString();
                    txt_valor_venda.Text = leitura[8].ToString();
                    txt_obs.Text = leitura[9].ToString();
                    cbo_status.Text = leitura[10].ToString();
                }
                else
                {
                    MessageBox.Show("Não foi encontrado esse código");
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
