using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Lesson1AdoNet
{
    public partial class Form1 : Form
    {
        SqlConnection? sqlConnection = null;
        SqlDataReader? reader = null;
        DataTable? table = null;
        public Form1()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            //table = new DataTable();
            //table.Columns.Add("Id");
            //table.Columns.Add("Name");
            //table.Columns.Add("Surname");

            //DataRow row = table.NewRow();
            //row[0] = 1;
            //row[1] = "Hakuna";
            //row[2] = "Matata";
            //table.Rows.Add(row);    
            //dataGridView1.DataSource = table;

            try
            {
                sqlConnection?.Open();
                var cmd = new SqlCommand("Select * From Authors", sqlConnection);
                dataGridView1.DataSource = null;

                table = new DataTable();
                reader = cmd.ExecuteReader();
                int line = 0;
                while (reader.Read())
                {
                    if (line == 0)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            table.Columns.Add(reader.GetName(i));
                        }
                        line++;
                    }

                    DataRow row = table.NewRow();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[i] = reader[i];
                    }
                    table.Rows.Add(row);
                }
            }
            finally
            {
                sqlConnection?.Close();
                reader?.Close();
            }
            dataGridView1.DataSource = table;
        }
    }
}
