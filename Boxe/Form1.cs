﻿using System;
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
         
                strSql = "insert into CadAlunos (Id, Nome, Idade, Peso, Altura, Celular, Email, Cidade, Estado, Lutas, Boxrec, Sexo, TurmaEspecial) values (@Id, @Nome, @Idade, @Peso, @Altura, @Celular, @Email, @Cidade, @Estado, @Lutas, @Boxrec, @Sexo, @TurmaEspecial)";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);

            //Transforma a selecao do radiobutton em string
            string sexo = rbMasc.Checked ? "Masculino" : "Feminino"; 

            comando.Parameters.Add("@Id", SqlDbType.Int).Value = int.Parse(txtId.Text);
            comando.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Idade", SqlDbType.Int).Value = int.Parse(nudIdade.Text);
            comando.Parameters.Add("@Peso", SqlDbType.Int).Value = int.Parse(nudPeso.Text);    
            comando.Parameters.Add("@Altura", SqlDbType.Int).Value = int.Parse(nudAltura.Text);
            comando.Parameters.Add("@Celular", SqlDbType.NVarChar).Value = mtbCelular.Text;
            comando.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtEmail.Text;
            comando.Parameters.Add("@Cidade", SqlDbType.NVarChar).Value = txtCidade.Text;
            comando.Parameters.Add("@Estado", SqlDbType.NVarChar).Value = cbEstado.Text;
            comando.Parameters.Add("@Lutas", SqlDbType.Int).Value = int.Parse(nudLutas.Text);
            comando.Parameters.Add("@Boxrec", SqlDbType.NVarChar).Value = txtBoxrec.Text;
            comando.Parameters.Add("@Sexo", SqlDbType.NVarChar).Value = sexo;


            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados inseridos com sucesso!");

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

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
           
        }

        //Botao de alterar
        private void tsbAlterar_Click(object sender, EventArgs e)
        {
            strSql = "update CadAlunos set Id=@Id, Nome=@Nome, Idade=@Idade, Peso=@Peso, Altura=@Altura, Celular=@Celular, Email=@Email, Cidade=@Cidade, Estado=@Estado, Lutas=@Lutas, Boxrec=@Boxrec, Sexo=@Sexo where Id=@tstBusca";
            sqlCon= new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@IdBuscar",SqlDbType.Int).Value = tstBusca.Text;

            //Transforma a selecao do radiobutton em string
            string sexo = rbMasc.Checked ? "Masculino" : "Feminino";

            comando.Parameters.Add("@Id", SqlDbType.Int).Value = int.Parse(txtId.Text);
            comando.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Idade", SqlDbType.Int).Value = int.Parse(nudIdade.Text);
            comando.Parameters.Add("@Peso", SqlDbType.Int).Value = int.Parse(nudPeso.Text);
            comando.Parameters.Add("@Altura", SqlDbType.Int).Value = int.Parse(nudAltura.Text);
            comando.Parameters.Add("@Celular", SqlDbType.NVarChar).Value = mtbCelular.Text;
            comando.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtEmail.Text;
            comando.Parameters.Add("@Cidade", SqlDbType.NVarChar).Value = txtCidade.Text;
            comando.Parameters.Add("@Estado", SqlDbType.NVarChar).Value = cbEstado.Text;
            comando.Parameters.Add("@Lutas", SqlDbType.Int).Value = int.Parse(nudLutas.Text);
            comando.Parameters.Add("@Boxrec", SqlDbType.NVarChar).Value = txtBoxrec.Text;
            comando.Parameters.Add("@Sexo", SqlDbType.NVarChar).Value = sexo;


            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro atualizado.");
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

        //Botao de busca
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

            strSql = "select * from CadAlunos where Id=@Id";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Id",SqlDbType.Int).Value = tstBusca.Text;

            try
            {

                if(tstBusca.Text == string.Empty)
                {
                    throw new Exception("Voce precisa digitar um ID.");
                }
                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if(dr.HasRows == false)
                {
                    throw new Exception("Id nao cadastrado!");
                }


                txtId.Text = Convert.ToString(dr["Id"]);
                txtNome.Text = Convert.ToString(dr["Nome"]);
                nudIdade.Text = Convert.ToString(dr["Idade"]);
                nudPeso.Text = Convert.ToString(dr["Peso"]);
                nudAltura.Text = Convert.ToString(dr["Altura"]);
                mtbCelular.Text = Convert.ToString(dr["Celular"]);
                txtEmail.Text = Convert.ToString(dr["Email"]);
                txtCidade.Text = Convert.ToString(dr["Cidade"]);
                cbEstado.Text = Convert.ToString(dr["Estado"]);
                nudLutas.Text = Convert.ToString(dr["Lutas"]);
                txtBoxrec.Text = Convert.ToString(dr["Boxrec"]);
              

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }
        }

        //Botao de excluir
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja excluir este aluno?", "ATENCAO", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)== DialogResult.No) 
            
            {
                MessageBox.Show("Nenhum dado foi excluido.");
            }

            else

            {
                strSql = "delete from CadAlunos where Id=@Id";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                comando.Parameters.Add("@Id", SqlDbType.Int).Value = tstBusca.Text;

                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro excluido.");
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    sqlCon.Close();
                }

            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
