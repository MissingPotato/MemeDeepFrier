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
			this.pictureBox_import = new System.Windows.Forms.PictureBox();
			this.pictureBox_export = new System.Windows.Forms.PictureBox();
			this.button_import = new System.Windows.Forms.Button();
			this.button_fry = new System.Windows.Forms.Button();
			this.button_export = new System.Windows.Forms.Button();
			this.label_meme = new System.Windows.Forms.Label();
			this.label_fryed = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_import)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_export)).BeginInit();
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
			this.panel1.Location = new System.Drawing.Point(155, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(311, 641);
			this.panel1.TabIndex = 1;
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
			// pictureBox_export
			// 
			this.pictureBox_export.Location = new System.Drawing.Point(32, 360);
			this.pictureBox_export.Name = "pictureBox_export";
			this.pictureBox_export.Size = new System.Drawing.Size(256, 256);
			this.pictureBox_export.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_export.TabIndex = 1;
			this.pictureBox_export.TabStop = false;
			// 
			// button_import
			// 
			this.button_import.Location = new System.Drawing.Point(12, 12);
			this.button_import.Name = "button_import";
			this.button_import.Size = new System.Drawing.Size(123, 26);
			this.button_import.TabIndex = 2;
			this.button_import.Text = "Import Meme";
			this.button_import.UseVisualStyleBackColor = true;
			this.button_import.Click += new System.EventHandler(this.button_import_Click);
			// 
			// button_fry
			// 
			this.button_fry.Location = new System.Drawing.Point(12, 44);
			this.button_fry.Name = "button_fry";
			this.button_fry.Size = new System.Drawing.Size(123, 26);
			this.button_fry.TabIndex = 3;
			this.button_fry.Text = "Deep Fry";
			this.button_fry.UseVisualStyleBackColor = true;
			this.button_fry.Click += new System.EventHandler(this.button_fry_Click);
			// 
			// button_export
			// 
			this.button_export.Location = new System.Drawing.Point(12, 76);
			this.button_export.Name = "button_export";
			this.button_export.Size = new System.Drawing.Size(123, 26);
			this.button_export.TabIndex = 4;
			this.button_export.Text = "Export Meme";
			this.button_export.UseVisualStyleBackColor = true;
			this.button_export.Click += new System.EventHandler(this.button_export_Click);
			// 
			// label_meme
			// 
			this.label_meme.AutoSize = true;
			this.label_meme.Location = new System.Drawing.Point(143, 13);
			this.label_meme.Name = "label_meme";
			this.label_meme.Size = new System.Drawing.Size(36, 13);
			this.label_meme.TabIndex = 2;
			this.label_meme.Text = "Meme";
			// 
			// label_fryed
			// 
			this.label_fryed.AutoSize = true;
			this.label_fryed.Location = new System.Drawing.Point(128, 344);
			this.label_fryed.Name = "label_fryed";
			this.label_fryed.Size = new System.Drawing.Size(65, 13);
			this.label_fryed.TabIndex = 3;
			this.label_fryed.Text = "Fryed Meme";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 665);
			this.Controls.Add(this.button_export);
			this.Controls.Add(this.button_fry);
			this.Controls.Add(this.button_import);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Meme Deep Fryer";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_import)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_export)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox_export;
		private System.Windows.Forms.PictureBox pictureBox_import;
		private System.Windows.Forms.Button button_import;
		private System.Windows.Forms.Button button_fry;
		private System.Windows.Forms.Label label_fryed;
		private System.Windows.Forms.Label label_meme;
		private System.Windows.Forms.Button button_export;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}

