namespace MemeDeepFrier
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label_fryed = new System.Windows.Forms.Label();
			this.label_meme = new System.Windows.Forms.Label();
			this.pictureBox_export = new System.Windows.Forms.PictureBox();
			this.pictureBox_import = new System.Windows.Forms.PictureBox();
			this.button_DeepFry_import = new System.Windows.Forms.Button();
			this.button_fry = new System.Windows.Forms.Button();
			this.button_DeepFry_Export = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage_DeepFry = new System.Windows.Forms.TabPage();
			this.tabPage_MazeGen = new System.Windows.Forms.TabPage();
			this.panel_Maze = new System.Windows.Forms.Panel();
			this.button_MazeGen_Export = new System.Windows.Forms.Button();
			this.button_MazeGen_Generate = new System.Windows.Forms.Button();
			this.tabPage_MapGen = new System.Windows.Forms.TabPage();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_export)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_import)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage_DeepFry.SuspendLayout();
			this.tabPage_MazeGen.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.label_fryed);
			this.panel1.Controls.Add(this.label_meme);
			this.panel1.Controls.Add(this.pictureBox_export);
			this.panel1.Controls.Add(this.pictureBox_import);
			this.panel1.Location = new System.Drawing.Point(399, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(311, 617);
			this.panel1.TabIndex = 1;
			// 
			// label_fryed
			// 
			this.label_fryed.AutoSize = true;
			this.label_fryed.Location = new System.Drawing.Point(128, 344);
			this.label_fryed.Name = "label_fryed";
			this.label_fryed.Size = new System.Drawing.Size(37, 13);
			this.label_fryed.TabIndex = 3;
			this.label_fryed.Text = "Export";
			// 
			// label_meme
			// 
			this.label_meme.AutoSize = true;
			this.label_meme.Location = new System.Drawing.Point(143, 13);
			this.label_meme.Name = "label_meme";
			this.label_meme.Size = new System.Drawing.Size(36, 13);
			this.label_meme.TabIndex = 2;
			this.label_meme.Text = "Import";
			// 
			// pictureBox_export
			// 
			this.pictureBox_export.Location = new System.Drawing.Point(32, 360);
			this.pictureBox_export.Name = "pictureBox_export";
			this.pictureBox_export.Size = new System.Drawing.Size(256, 256);
			this.pictureBox_export.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_export.TabIndex = 1;
			this.pictureBox_export.TabStop = false;
			// 
			// pictureBox_import
			// 
			this.pictureBox_import.Location = new System.Drawing.Point(32, 36);
			this.pictureBox_import.Name = "pictureBox_import";
			this.pictureBox_import.Size = new System.Drawing.Size(256, 256);
			this.pictureBox_import.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_import.TabIndex = 0;
			this.pictureBox_import.TabStop = false;
			// 
			// button_DeepFry_import
			// 
			this.button_DeepFry_import.Location = new System.Drawing.Point(6, 20);
			this.button_DeepFry_import.Name = "button_DeepFry_import";
			this.button_DeepFry_import.Size = new System.Drawing.Size(123, 26);
			this.button_DeepFry_import.TabIndex = 2;
			this.button_DeepFry_import.Text = "Import";
			this.button_DeepFry_import.UseVisualStyleBackColor = true;
			this.button_DeepFry_import.Click += new System.EventHandler(this.button_import_Click);
			// 
			// button_fry
			// 
			this.button_fry.Location = new System.Drawing.Point(6, 52);
			this.button_fry.Name = "button_fry";
			this.button_fry.Size = new System.Drawing.Size(123, 26);
			this.button_fry.TabIndex = 3;
			this.button_fry.Text = "Execute";
			this.button_fry.UseVisualStyleBackColor = true;
			this.button_fry.Click += new System.EventHandler(this.button_fry_Click);
			// 
			// button_DeepFry_Export
			// 
			this.button_DeepFry_Export.Location = new System.Drawing.Point(135, 20);
			this.button_DeepFry_Export.Name = "button_DeepFry_Export";
			this.button_DeepFry_Export.Size = new System.Drawing.Size(123, 26);
			this.button_DeepFry_Export.TabIndex = 4;
			this.button_DeepFry_Export.Text = "Export";
			this.button_DeepFry_Export.UseVisualStyleBackColor = true;
			this.button_DeepFry_Export.Click += new System.EventHandler(this.button_export_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage_DeepFry);
			this.tabControl1.Controls.Add(this.tabPage_MazeGen);
			this.tabControl1.Controls.Add(this.tabPage_MapGen);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(381, 616);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.tabControl1.TabIndex = 5;
			// 
			// tabPage_DeepFry
			// 
			this.tabPage_DeepFry.Controls.Add(this.button_fry);
			this.tabPage_DeepFry.Controls.Add(this.button_DeepFry_Export);
			this.tabPage_DeepFry.Controls.Add(this.button_DeepFry_import);
			this.tabPage_DeepFry.Location = new System.Drawing.Point(4, 22);
			this.tabPage_DeepFry.Name = "tabPage_DeepFry";
			this.tabPage_DeepFry.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_DeepFry.Size = new System.Drawing.Size(373, 590);
			this.tabPage_DeepFry.TabIndex = 0;
			this.tabPage_DeepFry.Text = "DeepFry";
			this.tabPage_DeepFry.UseVisualStyleBackColor = true;
			// 
			// tabPage_MazeGen
			// 
			this.tabPage_MazeGen.Controls.Add(this.panel_Maze);
			this.tabPage_MazeGen.Controls.Add(this.button_MazeGen_Export);
			this.tabPage_MazeGen.Controls.Add(this.button_MazeGen_Generate);
			this.tabPage_MazeGen.Location = new System.Drawing.Point(4, 22);
			this.tabPage_MazeGen.Name = "tabPage_MazeGen";
			this.tabPage_MazeGen.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_MazeGen.Size = new System.Drawing.Size(373, 590);
			this.tabPage_MazeGen.TabIndex = 1;
			this.tabPage_MazeGen.Text = "MazeGen";
			this.tabPage_MazeGen.UseVisualStyleBackColor = true;
			// 
			// panel_Maze
			// 
			this.panel_Maze.Location = new System.Drawing.Point(16, 43);
			this.panel_Maze.Name = "panel_Maze";
			this.panel_Maze.Size = new System.Drawing.Size(351, 334);
			this.panel_Maze.TabIndex = 2;
			this.panel_Maze.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Maze_Paint);
			// 
			// button_MazeGen_Export
			// 
			this.button_MazeGen_Export.Location = new System.Drawing.Point(255, 14);
			this.button_MazeGen_Export.Name = "button_MazeGen_Export";
			this.button_MazeGen_Export.Size = new System.Drawing.Size(112, 23);
			this.button_MazeGen_Export.TabIndex = 1;
			this.button_MazeGen_Export.Text = "Export Maze";
			this.button_MazeGen_Export.UseVisualStyleBackColor = true;
			// 
			// button_MazeGen_Generate
			// 
			this.button_MazeGen_Generate.Location = new System.Drawing.Point(16, 14);
			this.button_MazeGen_Generate.Name = "button_MazeGen_Generate";
			this.button_MazeGen_Generate.Size = new System.Drawing.Size(112, 23);
			this.button_MazeGen_Generate.TabIndex = 0;
			this.button_MazeGen_Generate.Text = "Generate Maze";
			this.button_MazeGen_Generate.UseVisualStyleBackColor = true;
			this.button_MazeGen_Generate.Click += new System.EventHandler(this.button_MazeGen_Generate_Click);
			// 
			// tabPage_MapGen
			// 
			this.tabPage_MapGen.Location = new System.Drawing.Point(4, 22);
			this.tabPage_MapGen.Name = "tabPage_MapGen";
			this.tabPage_MapGen.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_MapGen.Size = new System.Drawing.Size(373, 590);
			this.tabPage_MapGen.TabIndex = 2;
			this.tabPage_MapGen.Text = "MapGen";
			this.tabPage_MapGen.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(728, 641);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(744, 680);
			this.Name = "Form1";
			this.Text = "Meme Deep Fryer";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_export)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_import)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage_DeepFry.ResumeLayout(false);
			this.tabPage_MazeGen.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox_export;
		private System.Windows.Forms.PictureBox pictureBox_import;
		private System.Windows.Forms.Button button_DeepFry_import;
		private System.Windows.Forms.Button button_fry;
		private System.Windows.Forms.Label label_fryed;
		private System.Windows.Forms.Label label_meme;
		private System.Windows.Forms.Button button_DeepFry_Export;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage_DeepFry;
		private System.Windows.Forms.TabPage tabPage_MazeGen;
		private System.Windows.Forms.TabPage tabPage_MapGen;
		private System.Windows.Forms.Button button_MazeGen_Export;
		private System.Windows.Forms.Button button_MazeGen_Generate;
		private System.Windows.Forms.Panel panel_Maze;
	}
}

