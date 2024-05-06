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
    public partial class TodosAlunos : Form
    {
        public TodosAlunos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //carregando os dados do banco
        private void TodosAlunos_Load(object sender, EventArgs e)
        {
            string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AcadBoxe;Data Source=DESKTOP-5DV16DM\SQLEXPRESS";
            string query = "SELECT * FROM CadAlunos"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvListaAlunos.DataSource = table;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
