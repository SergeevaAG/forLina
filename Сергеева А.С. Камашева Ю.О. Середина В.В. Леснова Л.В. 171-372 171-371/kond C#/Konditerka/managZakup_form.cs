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

namespace Konditerka
{
    public partial class managZakup_form : Form
    {
        public managZakup_form()
        {
            InitializeComponent();
        }

        private void btnVyhod_Click(object sender, EventArgs e)
        {
            autoriz_form auto = new autoriz_form();
            this.Close();
            auto.Show();
        }

        private void managZakup_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projekt2DataSet.order". При необходимости она может быть перемещена или удалена.
            //this.orderTableAdapter.Fill(this.projekt2DataSet.order);
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string query = "SELECT * FROM [order] WHERE phase='Закупка'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[10]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
            }
            reader.Close();
            conn.Close();
            foreach (string[] s in data) 
                dataGridView3.Rows.Add(s);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "projekt2DataSet.cake_decorating". При необходимости она может быть перемещена или удалена.
            this.cake_decoratingTableAdapter.Fill(this.projekt2DataSet.cake_decorating);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projekt2DataSet.ingredient". При необходимости она может быть перемещена или удалена.
            this.ingredientTableAdapter.Fill(this.projekt2DataSet.ingredient);

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            this.ingredientTableAdapter.Update(this.projekt2DataSet.ingredient);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.cake_decoratingTableAdapter.Update(this.projekt2DataSet.cake_decorating);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.RemoveAt(item.Index);
            }
        }

        private void butUp_Click(object sender, EventArgs e)
        {
            this.orderTableAdapter.Update(this.projekt2DataSet.order);
        }
    }
}
