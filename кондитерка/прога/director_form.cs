using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konditerka
{
    public partial class director_form : Form
    {
        public director_form()
        {
            InitializeComponent();
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

        private void btUkrashen_Click(object sender, EventArgs e)
        {

        }

        //Заполнение таблиц на форме
        private void director_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projekt2DataSet3.order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.projekt2DataSet.order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projekt2DataSet3.equipment". При необходимости она может быть перемещена или удалена.
            this.equipmentTableAdapter.Fill(this.projekt2DataSet.equipment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projekt2DataSet3.cake_decorating". При необходимости она может быть перемещена или удалена.
            this.cake_decoratingTableAdapter.Fill(this.projekt2DataSet.cake_decorating);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projekt2DataSet3.ingredient". При необходимости она может быть перемещена или удалена.
            this.ingredientTableAdapter.Fill(this.projekt2DataSet.ingredient);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            //Обновление данных в таблице Ингредиенты
            this.ingredientTableAdapter.Update(this.projekt2DataSet.ingredient);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            //Удаление выделенных строк из таблицы Ингредиенты
            foreach(DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Обновление данных из таблицы Украшения для торта
            this.cake_decoratingTableAdapter.Update(this.projekt2DataSet.cake_decorating);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Удаление записей из таблицы Украшения для тортов
            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.RemoveAt(item.Index);
            }
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            //Обновление данных в таблице Инструменты
            this.equipmentTableAdapter.Update(this.projekt2DataSet.equipment);
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            //Удаление записей из таблицы Инструменты
            foreach (DataGridViewRow item in this.dataGridView3.SelectedRows)
            {
                dataGridView3.Rows.RemoveAt(item.Index);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btIng_Click(object sender, EventArgs e)
        {
            Word.wordConnection();
        }
    }
}
