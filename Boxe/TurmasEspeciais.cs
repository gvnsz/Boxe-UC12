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

namespace Boxe
{
    public partial class TurmasEspeciais : Form
    {
        private string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AcadBoxe;Data Source=DESKTOP-5DV16DM\SQLEXPRESS";

        public TurmasEspeciais()
        {
            InitializeComponent();
        }

        private void TurmasEspeciais_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string turmaSelecionada = cbTurmasEspeciais.SelectedItem.ToString();
            string query = $"SELECT Id, Nome, Idade, Peso, Altura, Celular, Email, Cidade, Estado, Sexo " +
                           $"FROM CadAlunos " +
                           $"WHERE TurmaEspecial = @TurmaSelecionada";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TurmaSelecionada", turmaSelecionada);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvTurmasEspeciais.DataSource = table;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
