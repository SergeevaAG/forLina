using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konditerka
{
    public partial class customer_form : Form
    {
        public customer_form( string id)
        {
            InitializeComponent();
            label1.Text = id;
            string raz = Environment.Is64BitOperatingSystem ? "64" : "32";

            lbOS.Text = "Операционная система:\n\r" + Environment.OSVersion.ToString() + "\n\rРазрядность: " + raz +
                "\n\rЧисло процессоров: " + Environment.ProcessorCount.ToString() + "\n\rИмя машины: " + Environment.MachineName.ToString() + "\n\rИмя пользователя: " + Environment.UserName.ToString();

        }

        //Закрытие этой формы и переход на форму авторизации
        private void btnVyhod_Click(object sender, EventArgs e)
        {
            autoriz_form auto = new autoriz_form();
            this.Close();
            auto.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        //Заполнение таблицы Заказы
        private void customer_form_Load(object sender, EventArgs e)
        {
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
            column2.ReadOnly = true;

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Название заказа";
            column3.Name = "count";
            column3.CellTemplate = new DataGridViewTextBoxCell();
            column3.ReadOnly = true;

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Продукт";
            column4.Name = "price";
            column4.CellTemplate = new DataGridViewTextBoxCell();
            column4.ReadOnly = true;

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Заказчик";
            column5.Name = "sum";
            column5.CellTemplate = new DataGridViewTextBoxCell();
            column5.ReadOnly = true;

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "Менеджер";
            column6.Name = "status";
            column6.CellTemplate = new DataGridViewTextBoxCell();
            column6.ReadOnly = true;
            var column7 = new DataGridViewColumn();
            column7.HeaderText = "Цена";
            column7.Name = "count";
            column7.CellTemplate = new DataGridViewTextBoxCell();
            column7.ReadOnly = true;

            var column8 = new DataGridViewColumn();
            column8.HeaderText = "Дата завершения";
            column8.Name = "price";
            column8.CellTemplate = new DataGridViewTextBoxCell();
            column8.ReadOnly = true;

            var column9 = new DataGridViewColumn();
            column9.HeaderText = "Примеры работ";
            column9.Name = "sum";
            column9.CellTemplate = new DataGridViewTextBoxCell();
            column9.ReadOnly = true;

            var column10 = new DataGridViewColumn();
            column10.HeaderText = "Статус";
            column10.Name = "status";
            column10.CellTemplate = new DataGridViewTextBoxCell();
            column10.ReadOnly = true;
            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);
            dataGridView1.Columns.Add(column4);
            dataGridView1.Columns.Add(column5);
            dataGridView1.Columns.Add(column6);
            dataGridView1.Columns.Add(column7);
            dataGridView1.Columns.Add(column8);
            dataGridView1.Columns.Add(column9);
            dataGridView1.Columns.Add(column10);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projekt2DataSet.order". При необходимости она может быть перемещена или удалена.
            //this.orderTableAdapter.Fill(this.projekt2DataSet.order);
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string query = "SELECT * FROM [order] WHERE customer=\'" + label1.Text + "\'";
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
 dataGridView1.Rows.Add(s[0], s[1], s[2], s[3], s[4], s[5], s[6], s[7], s[8], s[9]);
            }
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; ++j)
                {

                    object o = dataGridView1[j, i].Value;
                }
            }
        }

        //Обработчик обновления данных бд
        private void btUpdate_Click(object sender, EventArgs e)
        {
            this.orderTableAdapter.Update(this.projekt2DataSet.order);
        }

        //Обработчик удаления заказа
        private void btDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        //Обработчик загрузки картинки на форму
        private void picExample_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            textKostil.Text = openFileDialog1.FileName.ToString();
            Bitmap img = new Bitmap(textKostil.Text);
            picExample.Image = img;
        }


        private void btnRas_Click(object sender, EventArgs e)
        {
            string str = "";
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            //Создание команды запроса на стоимость заказа
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT price FROM [product] WHERE product_name=\'" + textIzd.Text + "\'";
            SqlDataReader reader = cmd.ExecuteReader();
            foreach (DbDataRecord r in reader)
            {
                str = r[0].ToString();
            }
            if (str == "")
            {
                lbSumm.Text = "Цена будет рассчитана менеджером позже.";
            }
            else
            {
                lbSumm.Text = str;
            }
        }

        private void btnZak_Click(object sender, EventArgs e)
        {
            //Создание соединения
            SqlConnection conn = DBUtils.GetDBConnection();
            string filePath = textKostil.Text;
            //Создание даты заказа
            string date = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            //Генерирование номера заказа
            string numOrd = DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString();
            //Проверка расчета стоимости заказа
            if (lbSumm.Text == "")
            {
                MessageBox.Show("Вы забыли рассчитать стоимость заказа.");
            }
            else
            {
                if(textIzd.Text == null || textDescrip.Text == null)
                {
                    lbError.Text = "Не заполнены обязательные поля.";
                }
                else
                { 
                    conn.Open();
                    //Текст команды для записи заказа в бд
                    string sInsSql = "INSERT INTO [order](number_order, data, order_name, product, customer, cost, phase, work_examples) SELECT \'" + numOrd 
                        + "\' AS number_order, \'" + date + "\' AS data, \'" + textIzd.Text + "\' AS order_name, \'" + textDescrip.Text + "\' AS product, \'" + label1.Text + "\' AS customer, \'" + lbSumm.Text + 
                        "\' AS cost, 'Новый' AS phase, * FROM OPENROWSET(BULK \'" + filePath + "\' , SINGLE_BLOB) AS work_examples";
                    //Создание команды
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sInsSql;
                    //Выполнение команды
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        lbError.Text = "Заказ принят.";
                        textIzd.Text = "";
                        textDescrip.Text = "";
                        lbSumm.Text = "";
                        picExample.Image = null;
                    }
                    conn.Close();
                }
            }
        }
    }
}
