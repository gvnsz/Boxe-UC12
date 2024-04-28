using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Biblioteca que conecta ao BD

namespace Boxe
{
    public partial class PagIni : Form //Pagina inicial do programa da academia
    {
        public PagIni()
        {
            InitializeComponent();
        }

        //Conectando ao banco
        SqlConnection sqlCon = null; 
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Boxe_UC12;Data Source=DESKTOP-5DV16DM\\SQLEXPRESS";
        private string strSql = string.Empty;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        
        //Botao que salva os dados inseridos no BD
        private void tsbSalvar_Click(object sender, EventArgs e) 
        {

            
            //Transforma a selecao do radiobutton em string
            string sexo = rbMasc.Checked ? "Masculino" : "Feminino"; 


                strSql = "insert into CadAlunos (Id, Nome, Idade, Peso, Altura, Celular, Email, Cidade, Estado, Lutas, Boxrec, Sexo) values (@Id, @Nome, @Idade, @Peso, @Altura, @Celular, @Email, @Cidade, @Estado, @Lutas, @Boxrec, @Sexo)";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                comando.Parameters.Add("Id", SqlDbType.Int).Value = int.Parse(txtId.Text);
                comando.Parameters.Add("Nome", SqlDbType.NVarChar).Value = txtNome.Text;
                comando.Parameters.Add("Idade", SqlDbType.Int).Value = int.Parse(nudIdade.Text);
                comando.Parameters.Add("Peso", SqlDbType.Int).Value = int.Parse(nudPeso.Text);    
                comando.Parameters.Add("Altura", SqlDbType.Int).Value = int.Parse(nudAltura.Text);
                comando.Parameters.Add("Celular", SqlDbType.NVarChar).Value = mtbCelular.Text;
                comando.Parameters.Add("Email", SqlDbType.NVarChar).Value = txtEmail.Text;
                comando.Parameters.Add("Cidade", SqlDbType.NVarChar).Value = txtCidade.Text;
                comando.Parameters.Add("Estado", SqlDbType.NVarChar).Value = cbEstado.Text;
                comando.Parameters.Add("Lutas", SqlDbType.Int).Value = int.Parse(nudLutas.Text);
                comando.Parameters.Add("Boxrec", SqlDbType.NVarChar).Value = txtBoxrec.Text;
                comando.Parameters.Add("Sexo", SqlDbType.NVarChar).Value = sexo;



            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados inseridos com sucesso.!");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }

 
        }

        private void rbMasc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
