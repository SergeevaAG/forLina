using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konditerka
{
    public partial class autoriz_form : Form
    {
        int schet = 0;
        Timer timer = new Timer();

        public autoriz_form()
        {
            InitializeComponent();  
            //Создание ивента таймера для блокировки формы
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 5000;            
        }

        //Ивент снятия блокировки формы
        private void timer_Tick(object sender, EventArgs e)
        {
            this.Enabled = true;
            schet = 0;
            timer.Stop();
            labMess.Text = "";
        }

      
        private void btnVhod_Click(object sender, EventArgs e)
        { 
            //Экземпляры форм
            managZakup_form manZak = new managZakup_form();
            master_form master = new master_form();
            director_form director = new director_form();
            //Создание соединения
            SqlConnection conn = DBUtils.GetDBConnection();
            try 
            {               
                string str = "";
                string str1 = "";
                conn.Open();
                //Создание команды запроса к бд
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT role, id_user FROM [user] WHERE password =\'" + textParol.Text + "\' AND login=\'" + textLogin.Text + "\'";
                SqlDataReader reader = cmd.ExecuteReader();
                foreach(DbDataRecord r in reader)
                {
                    //Запись Роли и Id из бд
                    str = r[0].ToString();
                    str1 = r[1].ToString();
                }
                
                if (str == "")
                {
                    if (schet >= 2)
                    {
                        //Блокировка формы при превышение кол-ва попыток
                        labMess.Text = "Превышен лимит попыток.\n Форма заблокирована на 5 сек.";
                        this.Enabled = false;
                        timer.Start();
                    }
                    else { 
                    labMess.Text = "Неправильный логин или пароль.";
                    textParol.Text = "";
                    schet += 1;
                    }
                }
                else
                {
                    conn.Close();
                    //Открытие формы в зависимости от роли пользователя
                    switch (str)
                    {
                        case "Заказчик":
                            customer_form custom = new customer_form(str1);
                            this.Hide();
                            custom.Show();
                            break;
                        case "Менеджер по продажам":
                            managClient_form manCl = new managClient_form(str1);
                            this.Hide();
                            manCl.Show();
                            break;
                        case "Менеджер по закупкам":
                            this.Hide();
                            manZak.Show();
                            break;
                        case "Мастер":
                            this.Hide();
                            master.Show();
                            break;
                        case "Директор":
                            this.Hide();
                            director.Show();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Обработчик для перехода на форму регистрации
        private void btnReg_Click(object sender, EventArgs e)
        {
            reg_form reg = new reg_form();
            this.Hide();
            reg.Show();
        }

        //Закрытие программы
        private void btnVyhod_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void autoriz_form_Load(object sender, EventArgs e)
        {

        }

        private void textParol_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            string s = Environment.Is64BitOperatingSystem ? "64" : "32";
            MessageBox.Show("Операционная система:\n\r" + Environment.OSVersion.ToString() + "\n\rРазрядность: " + s
                + "\n\rЧисло процессоров: " + Environment.ProcessorCount.ToString() + "\n\rИмя машины: " + Environment.MachineName.ToString()
                + "\n\rИмя пользователя: " + Environment.UserName.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 otchet = new Form1();
            this.Hide();
            otchet.Show();
        }
    }
}
