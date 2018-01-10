using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemeDeepFrier
{
	public partial class Form1 : Form
	{

		public static Bitmap meme;
		public static Bitmap friedMeme;

		public Form1()
		{
			InitializeComponent();
		}

		private void button_import_Click(object sender, EventArgs e)
		{
			ImportMeme();
		}

		private void button_export_Click(object sender, EventArgs e)
		{
			ExportMeme();
		}

		private void button_fry_Click(object sender, EventArgs e)
		{
			friedMeme = Fry ( meme );
		}


		#region Dynamic Functions

		/// <summary>
		/// Fries the parameter
		/// </summary>
		/// <param name="fryMeme">The result.</param>
		/// <returns></returns>
		public Bitmap Fry (Bitmap fryMeme)
		{
			// Fry the meme

			return fryMeme;
		}
		
		/// <summary>
		/// Exports the meme
		/// </summary>
		public void ExportMeme()
		{
			saveFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png | All files(*.*) | *.* ";
			friedMeme = meme;

			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				friedMeme.Save(saveFileDialog1.FileName);
			}
		}

		/// <summary>
		/// Imports the meme
		/// </summary>
		public void ImportMeme()
		{
			openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png | All files (*.*) | *.*";

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{

				meme = new Bitmap(openFileDialog1.FileName);
				pictureBox_import.Image = meme;
			}
		}

		#endregion

	}
}
