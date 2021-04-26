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

namespace AMONIC_Airlines
{
    public partial class admin_form : Form
    {
        public admin_form(string id)
        {
            InitializeComponent();
            laber.Text = id;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoriz_form auto = new autoriz_form();
            this.Close();
            auto.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_form add = new add_form();
            this.Close();
            add.Show();
        }

        private void admin_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "session1_SergeevaDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.session1_SergeevaDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "session1_SergeevaDataSet.Offices". При необходимости она может быть перемещена или удалена.
            this.officesTableAdapter.Fill(this.session1_SergeevaDataSet.Offices);

        }
    }
}
