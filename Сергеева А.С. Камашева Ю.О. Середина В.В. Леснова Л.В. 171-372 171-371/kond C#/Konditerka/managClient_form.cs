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
    public partial class managClient_form : Form
    {
        public managClient_form(string id)
        {
            InitializeComponent();
            label1.Text = id;

            var column1 = new DataGridViewColumn();
            column1.HeaderText = "№";
            column1.Width = 100;
            column1.ReadOnly = true;
            column1.Name = "id";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Дата заказа";
            column2.Name = "name";
            column2.CellTemplate = new DataGridViewTextBoxCell();
            column2.ReadOnly = false;

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Название заказа";
            column3.Name = "count";
            column3.CellTemplate = new DataGridViewTextBoxCell();
            column3.ReadOnly = false;

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Продукт";
            column4.Name = "price";
            column4.CellTemplate = new DataGridViewTextBoxCell();
            column4.ReadOnly = false;

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Заказчик";
            column5.Name = "sum";
            column5.CellTemplate = new DataGridViewTextBoxCell();
            column5.ReadOnly = false;

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "Менеджер";
            column6.Name = "meneger";
            column6.CellTemplate = new DataGridViewTextBoxCell();
            column6.ReadOnly = false;
            var column7 = new DataGridViewColumn();
            column7.HeaderText = "Цена";
            column7.Name = "count";
            column7.CellTemplate = new DataGridViewTextBoxCell();
            column7.ReadOnly = false;

            var column8 = new DataGridViewColumn();
            column8.HeaderText = "Дата завершения";
            column8.Name = "price";
            column8.CellTemplate = new DataGridViewTextBoxCell();
            column8.ReadOnly = false;

            var column9 = new DataGridViewColumn();
            column9.HeaderText = "Примеры работ";
            column9.Name = "sum";
            column9.CellTemplate = new DataGridViewTextBoxCell();
            column9.ReadOnly = false;

            var column10 = new DataGridViewColumn();
            column10.HeaderText = "Статус";
            column10.Name = "status";
            column10.CellTemplate = new DataGridViewTextBoxCell();
            column10.ReadOnly = true;

            dataGridView3.Columns.Add(column1);
            dataGridView3.Columns.Add(column2);
            dataGridView3.Columns.Add(column3);
            dataGridView3.Columns.Add(column4);
            dataGridView3.Columns.Add(column5);
            dataGridView3.Columns.Add(column6);
            dataGridView3.Columns.Add(column7);
            dataGridView3.Columns.Add(column8);
            dataGridView3.Columns.Add(column9);
            dataGridView3.Columns.Add(column10);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projekt2DataSet.order". При необходимости она может быть перемещена или удалена.
            //this.orderTableAdapter.Fill(this.projekt2DataSet.order);
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string query = "SELECT * FROM [order] WHERE phase='Новый' OR responsible_manager=\'" + label1.Text + "\'";
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
            {
                dataGridView3.Rows.Add(s[0], s[1], s[2], s[3], s[4], s[5], s[6], s[7], s[8], s[9]);
            }
            for (int i = 0; i < dataGridView3.Rows.Count; ++i)
            {
                for (int j = 0; j < dataGridView3.Columns.Count; ++j)
                {

                    object o = dataGridView3[j, i].Value;
                }
            }

            // TODO: данная строка кода позволяет загрузить данные в таблицу "projekt2DataSet.cake_decorating". При необходимости она может быть перемещена или удалена.
            this.cake_decoratingTableAdapter.Fill(this.projekt2DataSet.cake_decorating);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projekt2DataSet.ingredient". При необходимости она может быть перемещена или удалена.
            this.ingredientTableAdapter.Fill(this.projekt2DataSet.ingredient);
            dataGridView3.Enabled = true;
        }

        private void btnVyhod_Click(object sender, EventArgs e)
        {
            autoriz_form auto = new autoriz_form();
            this.Close();
            auto.Show();
        }

        private void managClient_form_Load(object sender, EventArgs e)
        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
                  


                

         
                   


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView3.SelectedRows)
            {
                dataGridView3.Rows.RemoveAt(item.Index);
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            var cmd = new SqlCommand("UPDATE [order] SET phase = @status WHERE number_order = @id ", conn);
            conn.Open();
            int n = 0;
            n = Convert.ToInt32(dataGridView3[0, dataGridView3.CurrentCell.RowIndex].Value);
            if (dataGridView3.CurrentCell.ColumnIndex == 9)
            {
                switch (dataGridView3.CurrentCell.Value)
                {
                    case "Новый":
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", n);
                        cmd.Parameters.AddWithValue("@status", "Ожидает");
                        cmd.ExecuteNonQuery();
                        dataGridView3["status", dataGridView3.CurrentCell.RowIndex].Value = "Ожидает";
                        break;
                    case "Ожидает":
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", n);
                        cmd.Parameters.AddWithValue("@status", "Обработка");
                        cmd.ExecuteNonQuery();
                        dataGridView3["status", dataGridView3.CurrentCell.RowIndex].Value = "Обработка";
                        break;
                    case "Обработка":
                        DialogResult result = MessageBox.Show("Принять заказ?", "Статус заказа", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@id", n);
                            cmd.Parameters.AddWithValue("@status", "К оплате");
                            cmd.ExecuteNonQuery();
                            dataGridView3["status", dataGridView3.CurrentCell.RowIndex].Value = "К оплате";
                        }
                        else if (result == DialogResult.No)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@id", n);
                            cmd.Parameters.AddWithValue("@status", "Отклонен");
                            cmd.ExecuteNonQuery();
                            dataGridView3["status", dataGridView3.CurrentCell.RowIndex].Value = "Отклонен";
                        }



                        break;


                    case "К оплате":
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", n);
                        cmd.Parameters.AddWithValue("@status", "Оплачен");
                        cmd.ExecuteNonQuery();
                        dataGridView3["status", dataGridView3.CurrentCell.RowIndex].Value = "Оплачен";
                        break;

                    case "Оплачен":
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", n);
                        cmd.Parameters.AddWithValue("@status", "Изготовление");
                        cmd.ExecuteNonQuery();
                        dataGridView3["status", dataGridView3.CurrentCell.RowIndex].Value = "Изготовление";
                        break;

                    case "Изготовление":
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", n);
                        cmd.Parameters.AddWithValue("@status", "Готов");
                        cmd.ExecuteNonQuery();
                        dataGridView3["status", dataGridView3.CurrentCell.RowIndex].Value = "Готов";

                        break;

                }
                conn.Close();
            }
        }
    }
}
