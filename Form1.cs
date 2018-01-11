using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

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
			PreviewMeme();
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

			Bitmap fryMePic = new Bitmap(fryMeme);

			for (int x = 0; x < fryMePic.Size.Width; x++)
			{
				for (int y = 0; y < fryMePic.Size.Height; y++)
				{

					Color newColor = fryMePic.GetPixel(x, y);

					fryMePic.SetPixel(x, y, ModifyColor(fryMePic.GetPixel(x, y), 0, x, y));
				}
			}

			

			return fryMePic;
		}

		public Color ModifyColor(Color modColor , int option, int x, int y)
		{

			Random rand = new Random();

			if (option == 0)
			{
				return modColor = Color.FromArgb(modColor.A, modColor.R / rand.Next(1, (modColor.R + x + 1) / 3), modColor.G / rand.Next(1, ( modColor.G + y + 1 ) / 3), modColor.B / rand.Next(1, ( modColor.B + x + 1 ) / 3) );
			}

			else
				return modColor;

		}
		
		/// <summary>
		/// Exports the meme
		/// </summary>
		public void ExportMeme()
		{
			saveFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png | All files(*.*) | *.* ";

			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				friedMeme.Save(saveFileDialog1.FileName);
			}
		}
		
		public Bitmap ResizeBitmap(Bitmap bitInput, int width, int height)
		{

			Graphics mygraphics = Graphics.FromImage(bitInput);
			mygraphics.InterpolationMode = InterpolationMode.NearestNeighbor;
			Bitmap outPut = new Bitmap(width, height, mygraphics);

			for (int x = 0; x < width; x++)
			{
				for (int y = 0; y < height; y++)
				{
					if ( x % 2 == 0)
						outPut.SetPixel(x, y, Color.Red);
					else
						outPut.SetPixel(x, y, Color.Blue);
				}
			}

			return outPut;
		
		}

		/// <summary>
		/// Previews the fried meme
		/// </summary>
		public void PreviewMeme()
		{
			pictureBox_export.Image = friedMeme;
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

		#region Maze

		public Graphics g;


		private void button_MazeGen_Generate_Click(object sender, EventArgs e)
		{

			Bitmap test = new Bitmap(20, 20);

			for (int i = 1; i < 20; i++)
			{
				for (int j = 1; j < 20; j++)
				{
					
					if ((i + j) % 2 == 0)
						test.SetPixel(i, j, Color.Red);
					else
						test.SetPixel(i, j, Color.Blue);

					test.SetPixel(1, 1, Color.Black);
					test.SetPixel(1, 19, Color.Black);
					test.SetPixel(19, 1, Color.Black);
					test.SetPixel(19, 19, Color.Black);


				}
			}

			g.DrawImage(test, panel_Maze.DisplayRectangle);
		}

		private void panel_Maze_Paint(object sender, EventArgs e)
		{
			g = panel_Maze.CreateGraphics();

			g.InterpolationMode = InterpolationMode.NearestNeighbor;
			g.FillRectangle(new SolidBrush(Color.White), panel_Maze.DisplayRectangle);

		}

		#endregion

	}


}
