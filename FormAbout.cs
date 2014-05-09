/*
 * Olivia Corey
 * Alison Dietz
 * David Hagen
 * Amy Rohmiller
 * Tuesday 1:15, Matt Himrod
 * 3 May 2005
 * 
 * Final Project
 * "Case in Space: Lunar Lander"
 * Part 2 of 8
*/ 
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace LunarLander
{
	/// <summary>
	/// Summary description for FormAbout.
	/// </summary>
	public class FormAbout : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button ok;
		private System.Windows.Forms.Label label16;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormAbout()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.ok = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(8, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Created by:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(208, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 26);
			this.label2.TabIndex = 1;
			this.label2.Text = "Version 1.0";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(24, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(307, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Images Taken From";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(10, 166);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(345, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "http://www.case.edu - President Hundert and Case logo";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(29, 200);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(243, 49);
			this.label5.TabIndex = 4;
			this.label5.Text = "http://gazette.unc.edu/archives/04jul14/7-16-webpix/john-edwards.jpg - John Edwar" +
				"ds";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(29, 249);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(297, 28);
			this.label6.TabIndex = 5;
			this.label6.Text = "www.commondreams.org/ views02/0906-04.htm - Dick Cheney";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(19, 286);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(288, 37);
			this.label7.TabIndex = 6;
			this.label7.Text = "www.uaf.edu/museum/ mammal/Hayward/0038.htm - Gorilla";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(29, 328);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(283, 37);
			this.label8.TabIndex = 7;
			this.label8.Text = "http://www.northwestern.edu/provost/students/circum2004/photo_gallery2.html - Sha" +
				"cks";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(29, 376);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(297, 37);
			this.label9.TabIndex = 8;
			this.label9.Text = "http://forum.hwsw.hu/index.php?showtopic=58921&st=180 - Lunar Lander";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(29, 423);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(203, 39);
			this.label10.TabIndex = 9;
			this.label10.Text = "http://www.masterengraver.com/astronaut-banjo.jpg - Astronaut ";
			// 
			// ok
			// 
			this.ok.BackColor = System.Drawing.Color.Transparent;
			this.ok.ForeColor = System.Drawing.Color.Yellow;
			this.ok.Location = new System.Drawing.Point(125, 554);
			this.ok.Name = "ok";
			this.ok.Size = new System.Drawing.Size(90, 25);
			this.ok.TabIndex = 10;
			this.ok.Text = "OK";
			this.ok.Click += new System.EventHandler(this.ok_Click);
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(29, 464);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(291, 37);
			this.label11.TabIndex = 11;
			this.label11.Text = "http://www.asaeweekly.org/asae/image_upload/matthews%20chris.jpg - Chris Matthews" +
				"";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Red;
			this.label12.Location = new System.Drawing.Point(16, 8);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(320, 32);
			this.label12.TabIndex = 12;
			this.label12.Text = "Case in Space: Lunar Lander";
			this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(80, 48);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 64);
			this.label13.TabIndex = 13;
			this.label13.Text = "Olivia Corey Alison Dietz David Hagen Amy Rohmiller";
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.ForeColor = System.Drawing.Color.White;
			this.label14.Location = new System.Drawing.Point(80, 112);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(232, 24);
			this.label14.TabIndex = 14;
			this.label14.Text = "Case Western Reserve University";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.ForeColor = System.Drawing.Color.White;
			this.label15.Location = new System.Drawing.Point(208, 72);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(120, 26);
			this.label15.TabIndex = 15;
			this.label15.Text = "(c) 2005";
			// 
			// label16
			// 
			this.label16.ForeColor = System.Drawing.Color.White;
			this.label16.Location = new System.Drawing.Point(38, 517);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(279, 26);
			this.label16.TabIndex = 16;
			this.label16.Text = "Baby image from Microsoft Clipart";
			// 
			// FormAbout
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(351, 597);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.ok);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAbout";
			this.Text = "About Case in Space";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.FormAbout_Closing);
			this.ResumeLayout(false);

		}
		#endregion


		private void ok_Click(object sender, System.EventArgs e)
		{
			Visible = false;
		}

		private void FormAbout_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = true;
			Visible = false;
		}
	}
}
