﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konditerka
{
    public partial class reg_form : Form
    {
        public bool isTrue(string pass)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasSpecialSymbols = new Regex(@"[!@#$%^]");
            var hasMinimum6Chars = new Regex(@".{6,}");


            var isValidated =
            hasNumber.IsMatch(pass) &&
            hasUpperChar.IsMatch(pass) &&
            hasSpecialSymbols.IsMatch(pass) &&
            hasMinimum6Chars.IsMatch(pass);

            if (!isValidated)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public reg_form()
        {
            InitializeComponent();
        }

        private void btnVyhod_Click(object sender, EventArgs e)
        {
            //Закрытие окна регистрации и переход к окну авторизации
            autoriz_form auto = new autoriz_form();
            this.Close();
            auto.Show();
        }

        //Запись данных нового пользователя в базу данных
        private void btnRegistr_Click(object sender, EventArgs e)
        { 
            //Создание соединения
            SqlConnection conn = DBUtils.GetDBConnection();
            //Regex myReg = new Regex(@"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{5,20})$");
          
            string filePath = textKostil.Text;

            //if (textParol.Text == textReParol.Text && isTrue(textParol.Text) == true)
            //Проверка совпадения введенных паролей
            if (textParol.Text == textReParol.Text)
                {
                //Проверка пустых полей
                if(textFio.Text==null || textLogin.Text==null || textParol.Text==null || textReParol.Text==null || filePath == null)
                    {
                        labMessage.Text = "Есть незаполненное поле.";            
                    }
                else { 
                
                        conn.Open();
               
                    //Создание команды для записи в бд
                        string sInsSql = "INSERT INTO [user](login, password, role, FIO, photo) SELECT \'"+ textLogin.Text +"\' AS login, \'"+ textParol.Text + "\' AS password, 'Заказчик' AS role, \'" + textFio.Text+"\' AS FIO, * FROM OPENROWSET(BULK \'"+ filePath +"\' , SINGLE_BLOB) AS photo";              
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = sInsSql;
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                        //Очистка данных в полях на форме
                            MessageBox.Show("Регистрация прошла успешно!");
                            textLogin.Text = "";
                            textParol.Text = "";
                            textReParol.Text = "";
                            textFio.Text = "";
                            picPhoto.Image = null;
                        }
                        conn.Close();                
                    }
            }
            else
                {
                //labMessage.Text = "Некорректно введен пароль второй раз или он не соответствует правилу.";
                    labMessage.Text = "Некорректно введен пароль второй раз";
                    textReParol.Text = "";
                }
        }

        private void picPhoto_Click(object sender, EventArgs e)
        {
            //Загрузка картинки для профиля пользователя
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            textKostil.Text = openFileDialog1.FileName.ToString();
            Bitmap img = new Bitmap(textKostil.Text);
            picPhoto.Image = img;
        }

        private void reg_form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
