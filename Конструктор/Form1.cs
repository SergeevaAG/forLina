using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Конструктор
{
    public partial class Form1 : Form
    {
        private object curObj = null;
        public Form1()
        {
            InitializeComponent();
            //pictureBox2.AllowDrop = true;
            numHeight.Value = pictureBox1.Height;
            numWidth.Value = pictureBox1.Width;
            this.MouseMove += new MouseEventHandler(mouseEvent);
            this.MouseClick += new MouseEventHandler(mouseLeave);
        }

        private void mouseLeave(object sender, MouseEventArgs e)
        {
            if(e.Button.ToString()== "Right")
            {
                curObj = null;
            }
        }

        private void mouseEvent(object sender, MouseEventArgs e)
        {
            if (curObj != null) { 
            curObj.GetType().GetProperty("Location").SetValue(curObj, new Point(Cursor.Position.X, Cursor.Position.Y));
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            textCloth.Text = openFileDialog1.FileName.ToString();
            Bitmap img = new Bitmap(textCloth.Text);
            pictureBox1.Image = img;
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            curObj = sender;
            pictureBox1.GetType().GetProperty("Enabled").SetValue(pictureBox1,false);
        }
        
        /*private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null) return;
            pictureBox1.DoDragDrop(pictureBox1.Image, DragDropEffects.Move);
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) e.Effect = DragDropEffects.Move;
        }*/

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel) return;
            textFurn.Text = openFileDialog2.FileName.ToString();
            Bitmap img = new Bitmap(textFurn.Text);
            pictureBox2.Image = img;
        }

        private void ButSize_Click(object sender, EventArgs e)
        {
            pictureBox1.Width = (int)(numWidth.Value)*10;
            pictureBox1.Height = (int)(numHeight.Value)*10;
        }
    }
}
