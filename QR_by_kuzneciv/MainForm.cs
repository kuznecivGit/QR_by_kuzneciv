using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using System.Media;
using System.Reflection;
using System.IO;
namespace QRScannerWinForm
{
    public partial class MainForm : Form
    {
        private bool a = false;
        private bool b = false;
        public MainForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void buttonLoad2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.png;*.jpeg;*.jpg;*.bmp|All Files|*.*";
            openFileDialog1.Title = "Выберите изображение с QR-кодом";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox2.Image = new Bitmap(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке изображения: " + ex.Message);
                }
            }
        }
        private void buttonQR2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Пожалуйста, загрузите изображение с QR-кодом.");
                return;
            }
            try
            {
                Bitmap bitmap = new Bitmap(pictureBox2.Image);
                var reader = new ZXing.BarcodeReader();
                var result = reader.Decode(bitmap);
                if (result != null)
                {
                    MessageBox.Show("Успех! Распознанный текст: " + result.Text);
                }
                else
                {
                    MessageBox.Show("Ой! К сожалению нам не удалось распознать QR-код =(");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Упс! Ошибка при сканировании: " + ex.Message);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void buttonLoad2_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.png;*.jpeg;*.jpg;*.bmp|All Files|*.*";
            openFileDialog1.Title = "Выберите изображение с QR-кодом";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox2.Image = new Bitmap(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке изображения: " + ex.Message);
                }
            }
        }
        private void buttonQR2_Click_1(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Пожалуйста, загрузите изображение с QR-кодом =)");
                return;
            }
            try
            {
                Bitmap bitmap = new Bitmap(pictureBox2.Image);
                var reader = new ZXing.BarcodeReader();
                var result = reader.Decode(bitmap);
                if (result != null)
                {
                    textBox1.Text = result.Text;
                    MessageBox.Show("Успех! Распознанный текст: " + result.Text);
                }
                else
                {
                    MessageBox.Show("Ой! К сожалению нам не удалось распознать QR-код =(");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Упс! Ошибка при сканировании: " + ex.Message);
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/kuznecivGit/QR_by_kuzneciv.git");
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            
            if (a)
            {
                a = false;
                this.BackColor = System.Drawing.Color.LightBlue;
                pictureBox3.BackColor = System.Drawing.Color.Aqua;
                pictureBox4.BackColor = System.Drawing.Color.Aqua;
                pictureBox5.BackColor = System.Drawing.Color.Aqua;
                pictureBox9.BackColor = System.Drawing.Color.PaleTurquoise;
                pictureBox10.BackColor = System.Drawing.Color.PaleTurquoise;
                textBox1.BackColor = System.Drawing.Color.Aqua;
                pictureBox2.BackColor = System.Drawing.Color.LightBlue;

                button1.BackColor = System.Drawing.Color.LightSkyBlue;
                button2.BackColor = System.Drawing.Color.LightSkyBlue;
                buttonQR2.BackColor = System.Drawing.Color.LightSkyBlue;
                buttonLoad2.BackColor = System.Drawing.Color.LightSkyBlue;

                linkLabel1.LinkColor = System.Drawing.Color.DarkCyan;
                linkLabel2.LinkColor = System.Drawing.Color.DarkCyan;
                linkLabel3.LinkColor = System.Drawing.Color.DarkCyan;
                linkLabel4.LinkColor = System.Drawing.Color.DarkCyan;
                linkLabel5.LinkColor = System.Drawing.Color.DarkCyan;
            }
            else
            {
                a = true;
                this.BackColor = System.Drawing.Color.White;
                pictureBox3.BackColor = System.Drawing.Color.LightGray;
                pictureBox4.BackColor = System.Drawing.Color.LightGray;
                pictureBox5.BackColor = System.Drawing.Color.LightGray;
                pictureBox9.BackColor = System.Drawing.Color.Gainsboro;
                pictureBox10.BackColor = System.Drawing.Color.Gainsboro;
                textBox1.BackColor = System.Drawing.Color.LightGray;
                pictureBox2.BackColor = System.Drawing.Color.Silver;

                button1.BackColor = System.Drawing.Color.Silver;
                button2.BackColor = System.Drawing.Color.Silver;
                buttonQR2.BackColor = System.Drawing.Color.Silver;
                buttonLoad2.BackColor = System.Drawing.Color.Silver;

                linkLabel1.LinkColor = System.Drawing.Color.DimGray;
                linkLabel2.LinkColor = System.Drawing.Color.DimGray;
                linkLabel3.LinkColor = System.Drawing.Color.DimGray;
                linkLabel4.LinkColor = System.Drawing.Color.DimGray;
                linkLabel5.LinkColor = System.Drawing.Color.DimGray;
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/QR-%D0%BA%D0%BE%D0%B4");
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/kuzneciv");
        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://steamcommunity.com/id/kuzneciv/");
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }
    }
}