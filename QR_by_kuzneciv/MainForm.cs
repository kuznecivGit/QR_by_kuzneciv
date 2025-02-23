using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace QRScannerWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Обработчик для кнопки загрузки изображения
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            // Создаем диалог для выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp"
            };

            // Если файл выбран, загружаем его в PictureBox
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки изображения: " + ex.Message);
                }
            }
        }

        // Обработчик для кнопки сканирования QR-кода
        private void buttonQR_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                try
                {
                    // Приводим изображение к Bitmap и инициализируем BarcodeReader
                    Bitmap bitmap = new Bitmap(pictureBox1.Image);
                    BarcodeReader reader = new BarcodeReader();
                    var result = reader.Decode(bitmap);

                    // Если QR-код распознан, выводим текст, иначе – сообщение об ошибке
                    if (result != null)
                    {
                        MessageBox.Show("Распознанный текст:\n" + result.Text);
                    }
                    else
                    {
                        MessageBox.Show("QR-код не распознан. Попробуйте другое изображение.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сканировании: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Сначала загрузите изображение с QR-кодом.");
            }
        }
    }
}
