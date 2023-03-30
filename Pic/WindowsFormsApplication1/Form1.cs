using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
	public partial class Form1 : Form {

		public Form1() {
			InitializeComponent();
		}
		// кнопка, которая отвечает за преобразование картинки в мозаику.
		private void btnConvert_Click(object sender, EventArgs e) {
			try
			{
				int H_CELL = int.Parse(textBox1.Text);
				int W_CELL = int.Parse(textBox1.Text);
				Image result = picTo.Image;
				Bitmap bitmap = new Bitmap(picFrom.Image);
				using (Graphics g = Graphics.FromImage(result))
				{
					for (int y = 0; y < bitmap.Height; y += H_CELL)
					{
						for (int x = 0; x < bitmap.Width; x += W_CELL)
						{
							Brush brush = new SolidBrush(bitmap.GetPixel(x, y));
							g.FillRectangle(brush, x, y, W_CELL, H_CELL);
						}
					}
				}
				picTo.SizeMode = PictureBoxSizeMode.StretchImage; // ПРОВЕРИТЬ ПРАВИЛЬНОСТЬ РАБОТЫ КОДА
				picTo.Image = result;
			}
			catch
			{
				MessageBox.Show("Ошибка");
			}
		}
		private void button3_Click(object sender, EventArgs e) 
		{
			Image result = picTo.Image;
			picTo.Image = result;
			if (picTo.Image != null) //если в pictureBox есть изображение
			{
				//создание диалогового окна "Сохранить как..", для сохранения изображения
				SaveFileDialog savedialog = new SaveFileDialog();
				savedialog.Title = "Сохранить картинку как...";
				//отображать ли предупреждение, если пользователь указывает имя уже существующего файла
				savedialog.OverwritePrompt = true;
				//отображать ли предупреждение, если пользователь указывает несуществующий путь
				savedialog.CheckPathExists = true;
				//список форматов файла, отображаемый в поле "Тип файла"
				savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
				//отображается ли кнопка "Справка" в диалоговом окне
				savedialog.ShowHelp = true;
				if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
				{
					try
					{
						result.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
					}
					catch
					{
						MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}
		//кнопка после нажатия которой мы открываем картинку
        private void button1_Click(object sender, EventArgs e)
        {
			OpenFileDialog openFile = new OpenFileDialog();// создаем диалоговое окно
			openFile.ShowDialog();// открываем окно
			string FileName = openFile.FileName;// берем полный адрес картинки  
			picFrom.SizeMode = PictureBoxSizeMode.StretchImage; //сжимаем или растягиваем картинку под размеры picterbox
			picFrom.ImageLocation = FileName;// грузим картинку в pictureBox
		}
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}
		private void picFrom_Click(object sender, EventArgs e)
		{
		}
		private void picTo_Click(object sender, EventArgs e)
		{
		}
	}
}
