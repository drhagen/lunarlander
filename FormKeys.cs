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
 * Part 4 of 8
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
	public class FormKeys : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button Cancelbtn;
		private System.Windows.Forms.Button Okbtn;
		private System.Windows.Forms.TextBox Upbox;
		private System.Windows.Forms.TextBox Leftbox;
		private System.Windows.Forms.TextBox Rightbox;
		private System.Windows.Forms.Label Leftlbl;
		private System.Windows.Forms.Label Uplbl;
		private System.Windows.Forms.Label Rightlbl;
		private System.Windows.Forms.Label Contlbl;
		private System.Windows.Forms.TextBox Contbox;

		public Keys AccelLeft;
		public Keys AccelRight;
		public Keys AccelUp;
		public Keys Continue;

		private Keys AccelLeftTemp;
		private Keys AccelRightTemp;
		private Keys AccelUpTemp;
		private Keys ContinueTemp;

		public string ContText;
		private System.Windows.Forms.Label label1;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormKeys()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

			AccelLeftTemp = AccelLeft = Keys.Left;
			AccelRightTemp = AccelRight = Keys.Right;
			AccelUpTemp = AccelUp = Keys.Down;
			ContinueTemp = Continue = Keys.Space;
			ContText = Keys.Space.ToString();

			Leftbox.Text = AccelLeft.ToString();
			Rightbox.Text = AccelRight.ToString();
			Upbox.Text = AccelUp.ToString();
			Contbox.Text = Continue.ToString();
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
			this.Cancelbtn = new System.Windows.Forms.Button();
			this.Okbtn = new System.Windows.Forms.Button();
			this.Upbox = new System.Windows.Forms.TextBox();
			this.Leftbox = new System.Windows.Forms.TextBox();
			this.Rightbox = new System.Windows.Forms.TextBox();
			this.Leftlbl = new System.Windows.Forms.Label();
			this.Uplbl = new System.Windows.Forms.Label();
			this.Rightlbl = new System.Windows.Forms.Label();
			this.Contlbl = new System.Windows.Forms.Label();
			this.Contbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Cancelbtn
			// 
			this.Cancelbtn.BackColor = System.Drawing.Color.Transparent;
			this.Cancelbtn.ForeColor = System.Drawing.Color.Yellow;
			this.Cancelbtn.Location = new System.Drawing.Point(272, 296);
			this.Cancelbtn.Name = "Cancelbtn";
			this.Cancelbtn.Size = new System.Drawing.Size(88, 24);
			this.Cancelbtn.TabIndex = 6;
			this.Cancelbtn.Text = "Cancel";
			this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
			// 
			// Okbtn
			// 
			this.Okbtn.BackColor = System.Drawing.Color.Transparent;
			this.Okbtn.ForeColor = System.Drawing.Color.Yellow;
			this.Okbtn.Location = new System.Drawing.Point(176, 296);
			this.Okbtn.Name = "Okbtn";
			this.Okbtn.Size = new System.Drawing.Size(88, 24);
			this.Okbtn.TabIndex = 5;
			this.Okbtn.Text = "OK";
			this.Okbtn.Click += new System.EventHandler(this.Okbtn_Click);
			// 
			// Upbox
			// 
			this.Upbox.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.Upbox.ForeColor = System.Drawing.Color.Yellow;
			this.Upbox.Location = new System.Drawing.Point(136, 144);
			this.Upbox.Name = "Upbox";
			this.Upbox.ReadOnly = true;
			this.Upbox.TabIndex = 3;
			this.Upbox.Text = "";
			this.Upbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Upbox_KeyDown);
			// 
			// Leftbox
			// 
			this.Leftbox.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.Leftbox.ForeColor = System.Drawing.Color.Yellow;
			this.Leftbox.Location = new System.Drawing.Point(24, 96);
			this.Leftbox.Name = "Leftbox";
			this.Leftbox.ReadOnly = true;
			this.Leftbox.TabIndex = 1;
			this.Leftbox.Text = "";
			this.Leftbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Leftbox_KeyDown);
			// 
			// Rightbox
			// 
			this.Rightbox.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.Rightbox.ForeColor = System.Drawing.Color.Yellow;
			this.Rightbox.Location = new System.Drawing.Point(248, 96);
			this.Rightbox.Name = "Rightbox";
			this.Rightbox.ReadOnly = true;
			this.Rightbox.TabIndex = 2;
			this.Rightbox.Text = "";
			this.Rightbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Rightbox_KeyDown);
			// 
			// Leftlbl
			// 
			this.Leftlbl.BackColor = System.Drawing.Color.Transparent;
			this.Leftlbl.ForeColor = System.Drawing.Color.White;
			this.Leftlbl.Location = new System.Drawing.Point(32, 120);
			this.Leftlbl.Name = "Leftlbl";
			this.Leftlbl.Size = new System.Drawing.Size(88, 24);
			this.Leftlbl.TabIndex = 5;
			this.Leftlbl.Text = "Accel Left";
			this.Leftlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Uplbl
			// 
			this.Uplbl.BackColor = System.Drawing.Color.Transparent;
			this.Uplbl.ForeColor = System.Drawing.Color.White;
			this.Uplbl.Location = new System.Drawing.Point(144, 168);
			this.Uplbl.Name = "Uplbl";
			this.Uplbl.Size = new System.Drawing.Size(88, 24);
			this.Uplbl.TabIndex = 6;
			this.Uplbl.Text = "Accel Up";
			this.Uplbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Rightlbl
			// 
			this.Rightlbl.BackColor = System.Drawing.Color.Transparent;
			this.Rightlbl.ForeColor = System.Drawing.Color.White;
			this.Rightlbl.Location = new System.Drawing.Point(256, 120);
			this.Rightlbl.Name = "Rightlbl";
			this.Rightlbl.Size = new System.Drawing.Size(88, 24);
			this.Rightlbl.TabIndex = 7;
			this.Rightlbl.Text = "Accel Right";
			this.Rightlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Contlbl
			// 
			this.Contlbl.BackColor = System.Drawing.Color.Transparent;
			this.Contlbl.ForeColor = System.Drawing.Color.White;
			this.Contlbl.Location = new System.Drawing.Point(32, 224);
			this.Contlbl.Name = "Contlbl";
			this.Contlbl.Size = new System.Drawing.Size(88, 24);
			this.Contlbl.TabIndex = 9;
			this.Contlbl.Text = "Continue";
			this.Contlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Contbox
			// 
			this.Contbox.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.Contbox.ForeColor = System.Drawing.Color.Yellow;
			this.Contbox.Location = new System.Drawing.Point(24, 200);
			this.Contbox.Name = "Contbox";
			this.Contbox.ReadOnly = true;
			this.Contbox.TabIndex = 4;
			this.Contbox.Text = "";
			this.Contbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Contbox_KeyDown);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 64);
			this.label1.TabIndex = 10;
			this.label1.Text = "Click in a box and press a key to change that control. Tab will change boxes.";
			// 
			// FormKeys
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(376, 335);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Contlbl);
			this.Controls.Add(this.Contbox);
			this.Controls.Add(this.Rightlbl);
			this.Controls.Add(this.Uplbl);
			this.Controls.Add(this.Leftlbl);
			this.Controls.Add(this.Rightbox);
			this.Controls.Add(this.Leftbox);
			this.Controls.Add(this.Upbox);
			this.Controls.Add(this.Okbtn);
			this.Controls.Add(this.Cancelbtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormKeys";
			this.Text = "Case in Space Player Controls";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.FormKeys_Closing);
			this.VisibleChanged += new System.EventHandler(this.FormKeys_VisibleChanged);
			this.ResumeLayout(false);

		}
		#endregion

		private void Okbtn_Click(object sender, System.EventArgs e)
		{
			AccelLeft = AccelLeftTemp;
			AccelRight = AccelRightTemp;
			AccelUp = AccelUpTemp;
			Continue = ContinueTemp;
			this.Visible = false;
		}

		private void Cancelbtn_Click(object sender, System.EventArgs e)
		{
			this.Visible = false;
		}

		private void Leftbox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			AccelLeftTemp = e.KeyCode;
			Leftbox.Text = e.KeyCode.ToString();
			e.Handled = true;
		}

		private void Rightbox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			AccelRightTemp = e.KeyCode;
			Rightbox.Text = e.KeyCode.ToString();
			e.Handled = true;
		}

		private void Upbox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			AccelUpTemp = e.KeyCode;
			Upbox.Text = e.KeyCode.ToString();
			e.Handled = true;
		}

		private void Contbox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			ContinueTemp = e.KeyCode;
			Contbox.Text = e.KeyCode.ToString();
			ContText = e.KeyCode.ToString();
			e.Handled = true;		
		}

		private void FormKeys_VisibleChanged(object sender, System.EventArgs e)
		{
			Leftbox.Text = AccelLeft.ToString();
			Rightbox.Text = AccelRight.ToString();
			Upbox.Text = AccelUp.ToString();
			Contbox.Text = Continue.ToString();
			ContText = Continue.ToString();
		}

		private void FormKeys_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = true;
			Visible = false;
		}
	}
}
