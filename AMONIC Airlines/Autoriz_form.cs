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

namespace AMONIC_Airlines
{
    public partial class autoriz_form : Form
    {
        int schet = 0;
        Timer timer = new Timer();
        public autoriz_form()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 10000;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            this.Enabled = true;
            schet = 0;
            label_mess.Text = "";
            timer.Stop();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                string str = "";
                string str1 = "";
                string str2 = "";
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT roleId, id, active FROM [users] WHERE password =\'" + text_parol.Text + "\' AND email=\'" + text_login.Text + "\'";
                SqlDataReader reader = cmd.ExecuteReader();
                foreach (DbDataRecord r in reader)
                {
                    str = r[0].ToString();
                    str1 = r[1].ToString();
                    str2 = r[2].ToString();
                }

                if (str == "")
                {
                    if (schet >= 3)
                    {
                        label_mess.Text = "Превышен лимит попыток.\n Форма заблокирована на 10 сек.";
                        this.Enabled = false;
                        timer.Start();
                    }
                    else
                    {
                        label_mess.Text = "Неправильный логин или пароль.";
                        text_parol.Text = "";
                        schet += 1;
                    }
                }
                else
                {
                    conn.Close();
                    if (str2 == "False")
                    {
                        label_mess.Text = "Вы заблокированы руководством.";
                        text_login.Text = "";
                        text_parol.Text = "";
                    }
                    else
                    {
                        switch (str)
                        {
                            case "2":
                                user_form usForm = new user_form(str1);
                                this.Hide();
                                usForm.Show();
                                break;
                            case "1":
                                admin_form adForm = new admin_form(str1);
                                this.Hide();
                                adForm.Show();
                                break;
                            case "3":
                                manag_form manForm = new manag_form();
                                this.Hide();
                                manForm.Show();
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
