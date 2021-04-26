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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projekt2DataSet.order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.projekt2DataSet.order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projekt2DataSet.user". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.projekt2DataSet.user);

        }
    }
}
