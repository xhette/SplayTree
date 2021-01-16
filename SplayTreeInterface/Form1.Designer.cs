
namespace SplayTreeInterface
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.search_Button = new System.Windows.Forms.Button();
			this.delete_Button = new System.Windows.Forms.Button();
			this.clear_Button = new System.Windows.Forms.Button();
			this.add_Button = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(668, 426);
			this.panel1.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(668, 426);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// search_Button
			// 
			this.search_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_Button.BackgroundImage")));
			this.search_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.search_Button.FlatAppearance.BorderSize = 0;
			this.search_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.search_Button.Location = new System.Drawing.Point(711, 146);
			this.search_Button.Name = "search_Button";
			this.search_Button.Size = new System.Drawing.Size(55, 55);
			this.search_Button.TabIndex = 4;
			this.search_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.search_Button.UseVisualStyleBackColor = true;
			this.search_Button.Click += new System.EventHandler(this.search_Button_Click);
			// 
			// delete_Button
			// 
			this.delete_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete_Button.BackgroundImage")));
			this.delete_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.delete_Button.FlatAppearance.BorderSize = 0;
			this.delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.delete_Button.Location = new System.Drawing.Point(711, 246);
			this.delete_Button.Name = "delete_Button";
			this.delete_Button.Size = new System.Drawing.Size(55, 55);
			this.delete_Button.TabIndex = 5;
			this.delete_Button.UseVisualStyleBackColor = true;
			this.delete_Button.Click += new System.EventHandler(this.delete_Button_Click);
			// 
			// clear_Button
			// 
			this.clear_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clear_Button.BackgroundImage")));
			this.clear_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.clear_Button.FlatAppearance.BorderSize = 0;
			this.clear_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clear_Button.Location = new System.Drawing.Point(711, 346);
			this.clear_Button.Name = "clear_Button";
			this.clear_Button.Size = new System.Drawing.Size(55, 55);
			this.clear_Button.TabIndex = 6;
			this.clear_Button.UseVisualStyleBackColor = true;
			this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
			// 
			// add_Button
			// 
			this.add_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_Button.BackgroundImage")));
			this.add_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.add_Button.Cursor = System.Windows.Forms.Cursors.Default;
			this.add_Button.FlatAppearance.BorderSize = 0;
			this.add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.add_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.add_Button.Location = new System.Drawing.Point(711, 46);
			this.add_Button.Name = "add_Button";
			this.add_Button.Size = new System.Drawing.Size(55, 55);
			this.add_Button.TabIndex = 7;
			this.add_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.add_Button.UseVisualStyleBackColor = true;
			this.add_Button.Click += new System.EventHandler(this.add_Button_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.add_Button);
			this.Controls.Add(this.clear_Button);
			this.Controls.Add(this.delete_Button);
			this.Controls.Add(this.search_Button);
			this.Controls.Add(this.panel1);
			this.MaximumSize = new System.Drawing.Size(818, 497);
			this.MinimumSize = new System.Drawing.Size(818, 497);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Косые деревья";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Button search_Button;
		public System.Windows.Forms.Button delete_Button;
		public System.Windows.Forms.Button clear_Button;
		public System.Windows.Forms.Button add_Button;
	}
}

