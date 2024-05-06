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
using System.Threading; //para abrir mais forms

namespace Boxe
{
    public partial class PagIni : Form //Pagina inicial do programa da academia
    {
        Thread t1;
        Thread t2;

        public PagIni()
        {
            InitializeComponent();
        }

        //Conectando ao banco
        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AcadBoxe;Data Source=DESKTOP-5DV16DM\SQLEXPRESS";
        private string strSql = string.Empty;

        //comportamento quando o form é aberto
        private void Form1_Load(object sender, EventArgs e)
        {
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbAlterar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbDelete.Enabled = false;
            tstIdBuscar.Enabled = true;
            tsbBuscar.Enabled = true;
            txtId.Enabled = false;
            txtNome.Enabled = false;
            nudIdade.Enabled = false;
            nudPeso.Enabled = false;
            nudAltura.Enabled = false;
            mtbCelular.Enabled = false;
            txtEmail.Enabled = false;
            txtCidade.Enabled = false;
            cbEstado.Enabled = false;
            nudLutas.Enabled = false;
            txtBoxrec.Enabled = false;
            rbMasc.Enabled = false;
            rbFem.Enabled = false;
            rbInfantil.Enabled = false;
            rbIdosos.Enabled = false;
            rbNecEsp.Enabled = false;
        }

        //botao novo
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tsbNovo.Enabled = false;
            tsbSalvar.Enabled = true;
            tsbAlterar.Enabled = false;
            tsbCancelar.Enabled = true;
            tsbDelete.Enabled = false;
            tstIdBuscar.Enabled = false;
            tsbBuscar.Enabled = false;
            txtId.Enabled = true;
            txtNome.Enabled = true;
            nudIdade.Enabled = true;
            nudPeso.Enabled = true;
            nudAltura.Enabled = true;
            mtbCelular.Enabled = true;
            txtEmail.Enabled = true;
            txtCidade.Enabled = true;
            cbEstado.Enabled = true;
            nudLutas.Enabled = true;
            txtBoxrec.Enabled = true;
            rbMasc.Enabled = true;
            rbFem.Enabled = true;
            rbInfantil.Enabled = true;
            rbIdosos.Enabled = true;
            rbNecEsp.Enabled = true;

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

            //Radio button de turmas especiais
            string respRadio = "";

            if (rbInfantil.Checked)
            {
                respRadio = "Infantil";
            }
            else if (rbIdosos.Checked)
            {
                respRadio = "Idosos";
            }
            else if (rbNecEsp.Checked)
            {
                respRadio = "PcD";
            }

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
            comando.Parameters.Add("@TurmaEspecial", SqlDbType.NVarChar).Value = respRadio;

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

            //esse bloco limpa as caixas apos a adicao de um cadastro
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbAlterar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbDelete.Enabled = false;
            tstIdBuscar.Enabled = true;
            tsbBuscar.Enabled = true;
            txtId.Enabled = false;
            txtNome.Enabled = false;
            nudIdade.Enabled = false;
            nudPeso.Enabled = false;
            nudAltura.Enabled = false;
            mtbCelular.Enabled = false;
            txtEmail.Enabled = false;
            txtCidade.Enabled = false;
            cbEstado.Enabled = false;
            nudLutas.Enabled = false;
            txtBoxrec.Enabled = false;
            rbMasc.Enabled = false;
            rbFem.Enabled = false;
            rbInfantil.Enabled = false;
            rbIdosos.Enabled = false;
            rbNecEsp.Enabled = false;
            txtId.Text = "";
            txtNome.Text = "";
            nudIdade.Value = 0;
            nudPeso.Value = 0;
            nudAltura.Value = 0;
            mtbCelular.Text = "";
            txtEmail.Text = "";
            txtCidade.Text = "";
            cbEstado.Text = "";
            nudLutas.Value = 0;
            txtBoxrec.Text = string.Empty;
            rbMasc.Checked = false;
            rbFem.Checked = false;
            rbInfantil.Checked = false;
            rbIdosos.Checked = false;
            rbNecEsp.Checked = false;



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

        //botao de busca
        //deu um trabalho da p!@#$ pra acertar, pior botao
        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int idBuscar;
                if (!int.TryParse(tstIdBuscar.Text, out idBuscar))
                {
                    MessageBox.Show("Digite um ID válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection sqlCon = new SqlConnection(strCon))
                { 
                    strSql = "select * from CadAlunos where Id=@Id";
                    SqlCommand comando = new SqlCommand(strSql, sqlCon);
                    comando.Parameters.Add("@Id", SqlDbType.Int).Value = idBuscar;

                    sqlCon.Open();
                    SqlDataReader dr = comando.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            txtId.Text = dr["Id"].ToString();
                            txtNome.Text = dr["Nome"].ToString();
                            nudIdade.Value = (int)dr["Idade"];
                            nudPeso.Value = (int)dr["Peso"];
                            nudAltura.Value = (int)dr["Altura"];
                            mtbCelular.Text = dr["Celular"].ToString();
                            txtEmail.Text = dr["Email"].ToString();
                            txtCidade.Text = dr["Cidade"].ToString();
                            cbEstado.Text = dr["Estado"].ToString();
                            nudLutas.Value = (int)dr["Lutas"];
                            txtBoxrec.Text = dr["Boxrec"].ToString();
                            if (dr["Sexo"].ToString() == "Masculino")
                                rbMasc.Checked = true;
                            else if (dr["Sexo"].ToString() == "Feminino")
                                rbFem.Checked = true;
                            if (dr["TurmaEspecial"].ToString() == "Infantil")
                                rbInfantil.Checked = true;
                            else if (dr["TurmaEspecial"].ToString() == "Idosos")
                                rbIdosos.Checked = true;
                            else if (dr["TurmaEspecial"].ToString() == "PcD")
                                rbNecEsp.Checked = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum aluno encontrado com o ID especificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao buscar o aluno: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }

                tsbNovo.Enabled = false;
                tsbSalvar.Enabled = false;
                tsbAlterar.Enabled = true;
                tsbCancelar.Enabled = true;
                tsbDelete.Enabled = true;
                tstIdBuscar.Enabled = true;
                tsbBuscar.Enabled = true;
                txtNome.Enabled = true;
                nudIdade.Enabled = true;
                nudPeso.Enabled = true;
                nudAltura.Enabled = true;
                mtbCelular.Enabled = true;
                txtEmail.Enabled = true;
                txtCidade.Enabled = true;
                cbEstado.Enabled = true;
                nudLutas.Enabled = true;
                txtBoxrec.Enabled = true;
                rbMasc.Enabled = true;
                rbFem.Enabled = true;
                rbInfantil.Enabled = true;
                rbIdosos.Enabled = true;
                rbNecEsp.Enabled = true;
                tsbBuscar.Text = "";
                txtNome.Focus();

            }

        }

        //Botao de alterar
        private void tsbAlterar_Click(object sender, EventArgs e)
        {
            strSql = "update CadAlunos set Id=@Id, Nome=@Nome, Idade=@Idade, Peso=@Peso, Altura=@Altura, Celular=@Celular, Email=@Email, Cidade=@Cidade, Estado=@Estado, Lutas=@Lutas, Boxrec=@Boxrec, Sexo=@Sexo, TurmaEspecial=@TurmaEspecial where Id=@Id";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@IdBuscar", SqlDbType.Int).Value = tstIdBuscar.Text;

            string sexo = rbMasc.Checked ? "Masculino" : "Feminino";

            string respRadio = "";

            if (rbInfantil.Checked)
            {
                respRadio = "Infantil";
            }
            else if (rbIdosos.Checked)
            {
                respRadio = "Idosos";
            }
            else if (rbNecEsp.Checked)
            {
                respRadio = "PcD";
            }

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
            comando.Parameters.Add("@TurmaEspecial", SqlDbType.NVarChar).Value = respRadio;


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

            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbAlterar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbDelete.Enabled = false;
            tstIdBuscar.Enabled = true;
            tsbBuscar.Enabled = true;
            txtId.Enabled = false;
            txtNome.Enabled = false;
            nudIdade.Enabled = false;
            nudPeso.Enabled = false;
            nudAltura.Enabled = false;
            mtbCelular.Enabled = false;
            txtEmail.Enabled = false;
            txtCidade.Enabled = false;
            cbEstado.Enabled = false;
            nudLutas.Enabled = false;
            txtBoxrec.Enabled = false;
            rbMasc.Enabled = false;
            rbFem.Enabled = false;
            rbInfantil.Enabled = false;
            rbIdosos.Enabled = false;
            rbNecEsp.Enabled = false;
            txtId.Text = "";
            txtNome.Text = "";
            nudIdade.Value = 0;
            nudPeso.Value = 0;
            nudAltura.Value = 0;
            mtbCelular.Text = "";
            txtEmail.Text = "";
            txtCidade.Text = "";
            cbEstado.Text = "";
            nudLutas.Value = 0;
            txtBoxrec.Text = string.Empty;
            rbMasc.Checked = false;
            rbFem.Checked = false;
            rbInfantil.Checked = false;
            rbIdosos.Checked = false;
            rbNecEsp.Checked = false;

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        //Botao de excluir
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir este aluno?", "ATENCAO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)

            {
                MessageBox.Show("Nenhum dado foi excluido.");
            }

            else

            {
                strSql = "delete from CadAlunos where Id=@Id";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                comando.Parameters.Add("@Id", SqlDbType.Int).Value = tstIdBuscar.Text;

                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro excluido.");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    sqlCon.Close();
                }

                tsbNovo.Enabled = true;
                tsbSalvar.Enabled = false;
                tsbAlterar.Enabled = false;
                tsbCancelar.Enabled = false;
                tsbDelete.Enabled = false;
                tstIdBuscar.Enabled = true;
                tsbBuscar.Enabled = true;
                txtId.Enabled = false;
                txtNome.Enabled = false;
                nudIdade.Enabled = false;
                nudPeso.Enabled = false;
                nudAltura.Enabled = false;
                mtbCelular.Enabled = false;
                txtEmail.Enabled = false;
                txtCidade.Enabled = false;
                cbEstado.Enabled = false;
                nudLutas.Enabled = false;
                txtBoxrec.Enabled = false;
                rbMasc.Enabled = false;
                rbFem.Enabled = false;
                rbInfantil.Enabled = false;
                rbIdosos.Enabled = false;
                rbNecEsp.Enabled = false;
                txtId.Text = "";
                txtNome.Text = "";
                nudIdade.Value = 0;
                nudPeso.Value = 0;
                nudAltura.Value = 0;
                mtbCelular.Text = "";
                txtEmail.Text = "";
                txtCidade.Text = "";
                cbEstado.Text = "";
                nudLutas.Value = 0;
                txtBoxrec.Text = string.Empty;
                rbMasc.Checked = false;
                rbFem.Checked = false;
                rbInfantil.Checked = false;
                rbIdosos.Checked = false;
                rbNecEsp.Checked = false;

            }
        }

        //botao cancelar
        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbAlterar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbDelete.Enabled = false;
            tstIdBuscar.Enabled = true;
            tsbBuscar.Enabled = true;
            txtId.Enabled = false;
            txtNome.Enabled = false;
            nudIdade.Enabled = false;
            nudPeso.Enabled = false;
            nudAltura.Enabled = false;
            mtbCelular.Enabled = false;
            txtEmail.Enabled = false;
            txtCidade.Enabled = false;
            cbEstado.Enabled = false;
            nudLutas.Enabled = false;
            txtBoxrec.Enabled = false;
            rbMasc.Enabled = false;
            rbFem.Enabled = false;
            rbInfantil.Enabled = false;
            rbIdosos.Enabled = false;
            rbNecEsp.Enabled = false;
            txtId.Text = "";
            txtNome.Text = "";
            nudIdade.Value = 0;
            nudPeso.Value = 0;
            nudAltura.Value = 0;
            mtbCelular.Text = "";
            txtEmail.Text = "";
            txtCidade.Text = "";
            cbEstado.Text = "";
            nudLutas.Value = 0;
            txtBoxrec.Text = string.Empty;
            rbMasc.Checked = false;
            rbFem.Checked = false;
            rbInfantil.Checked = false;
            rbIdosos.Checked = false;
            rbNecEsp.Checked = false;

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void rbInfantil_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbIdosos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbNecEsp_CheckedChanged(object sender, EventArgs e)
        {

        }

        //botao para abrir a janela com todos os alunos cadastrados
        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            t1 = new Thread(abrirJanela);
            t1.SetApartmentState(ApartmentState.STA); 
            t1.Start();
        }

        //metodo que abre a janela
        private void abrirJanela(object obj)
        {
            Application.Run(new TodosAlunos());
        }

        //botao turmas especiais
        private void btnTurmasEspeciais_Click(object sender, EventArgs e)
        {
            t2 = new Thread(abrirTurmas);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        private void abrirTurmas(object obj)
        {
            Application.Run(new TurmasEspeciais());
        }



    }
}
