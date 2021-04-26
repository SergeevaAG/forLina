using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMONIC_Airlines
{
    public partial class user_form : Form
    {
        public user_form(string id)
        {
            InitializeComponent();
            label1.Text = id;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoriz_form auto = new autoriz_form();
            this.Close();
            auto.Show();
        }

        private void user_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "session1_SergeevaDataSet.Tracking". При необходимости она может быть перемещена или удалена.
            this.trackingTableAdapter.Fill(this.session1_SergeevaDataSet.Tracking);

        }
    }
}
