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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }
        public static string stringconexao = "" +
            "Data Source=localhost;" +
            "initial catalog = n8_miniprojeto;" +
            "User ID=sa;" +
            "Password=123456";

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

        private void Form1_Load(object sender, EventArgs e)
        {
            testeconexao();
        }

        private void bto_ok_Click(object sender, EventArgs e)
        {
            string sql = "select * from usuario where " +
                "login_usuario = '" + txt_usuario.Text + "' and " +
                "senha_usuario = '" + txt_senha.Text + "'";




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
                    MessageBox.Show("Seja bem vindo");
                    MDIprincipal frm = new MDIprincipal();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erro, usuário ou senha inválido");
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

        private void bto_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
