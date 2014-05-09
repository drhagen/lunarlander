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
 * Part 3 of 8
*/ 
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace LunarLander
{
	/// <summary>
	/// Summary description for FormHelp.
	/// </summary>
	public class FormHelp : System.Windows.Forms.Form
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
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Button Okbtn;
		private System.Windows.Forms.Label label17;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormHelp()
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
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.Okbtn = new System.Windows.Forms.Button();
			this.label17 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Yellow;
			this.label1.Location = new System.Drawing.Point(298, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "Lunar Landar Help";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(0, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 27);
			this.label2.TabIndex = 1;
			this.label2.Text = "Object";
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(0, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(456, 32);
			this.label3.TabIndex = 2;
			this.label3.Text = "- To land the lander on flat terrain at the safe speed using keyboard controls - " +
				"Rack up your scholarship by landing safely many times in a row!";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Yellow;
			this.label4.Location = new System.Drawing.Point(0, 102);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 26);
			this.label4.TabIndex = 3;
			this.label4.Text = "Menu: Game";
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(0, 129);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(422, 27);
			this.label5.TabIndex = 4;
			this.label5.Text = "- New Game (F2):  Click here or hit the F2 button to start a new game";
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(0, 157);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(451, 26);
			this.label6.TabIndex = 5;
			this.label6.Text = "- Unpause (F3): Click here or hit the F3 button to unpause a paused game";
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(0, 185);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(336, 26);
			this.label7.TabIndex = 6;
			this.label7.Text = "- High Scores: Click here to see the top ten high scores";
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(0, 212);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(211, 27);
			this.label8.TabIndex = 7;
			this.label8.Text = "- Exit: Click here to exit the game";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(192)));
			this.label9.Location = new System.Drawing.Point(0, 240);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(120, 27);
			this.label9.TabIndex = 8;
			this.label9.Text = "Menu: Options";
			// 
			// label10
			// 
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(0, 268);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(576, 26);
			this.label10.TabIndex = 9;
			this.label10.Text = "- Difficulty: Increasing the level of difficulty decreases the safe horizontal an" +
				"d vertical velocities";
			// 
			// label11
			// 
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(29, 295);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(509, 27);
			this.label11.TabIndex = 10;
			this.label11.Text = "- - Fine Arts: Easiest level.  Safe Horizontal Velocity=50, Safe Vertical Velocit" +
				"y=200";
			// 
			// label12
			// 
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(29, 323);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(509, 27);
			this.label12.TabIndex = 11;
			this.label12.Text = "- - Business: Medium level.  Safe Horizontal Velocity=40, Safe Vertical Velocity=" +
				"150";
			// 
			// label13
			// 
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(29, 351);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(509, 26);
			this.label13.TabIndex = 12;
			this.label13.Text = "- - Engineering: Hard level.  Safe Horizontal Velocity=30, Safe Vertical Velocity" +
				"=100";
			// 
			// label14
			// 
			this.label14.ForeColor = System.Drawing.Color.White;
			this.label14.Location = new System.Drawing.Point(29, 378);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(509, 27);
			this.label14.TabIndex = 13;
			this.label14.Text = "- - Science: Very Hard level.  Safe Horizontal Velocity=10, Safe Vertical Velocit" +
				"y=50";
			// 
			// label15
			// 
			this.label15.ForeColor = System.Drawing.Color.White;
			this.label15.Location = new System.Drawing.Point(0, 406);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(374, 18);
			this.label15.TabIndex = 14;
			this.label15.Text = "- Background Picture: Select the picture in the background";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.ForeColor = System.Drawing.Color.White;
			this.label16.Location = new System.Drawing.Point(0, 456);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(304, 16);
			this.label16.TabIndex = 15;
			this.label16.Text = "- Player Controls: Change the game control keys";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label18.ForeColor = System.Drawing.Color.Red;
			this.label18.Location = new System.Drawing.Point(0, 489);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(120, 27);
			this.label18.TabIndex = 17;
			this.label18.Text = "Menu: Screen";
			// 
			// label19
			// 
			this.label19.ForeColor = System.Drawing.Color.White;
			this.label19.Location = new System.Drawing.Point(0, 517);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(749, 26);
			this.label19.TabIndex = 18;
			this.label19.Text = "- Displays the current horizontal velocity, vertical velocity, high score, player" +
				"\'s current score, and player\'s total score";
			// 
			// Okbtn
			// 
			this.Okbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Okbtn.ForeColor = System.Drawing.Color.Yellow;
			this.Okbtn.Location = new System.Drawing.Point(344, 544);
			this.Okbtn.Name = "Okbtn";
			this.Okbtn.Size = new System.Drawing.Size(80, 32);
			this.Okbtn.TabIndex = 19;
			this.Okbtn.Text = "Thanks";
			this.Okbtn.Click += new System.EventHandler(this.Okbtn_Click);
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.ForeColor = System.Drawing.Color.White;
			this.label17.Location = new System.Drawing.Point(0, 432);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(400, 16);
			this.label17.TabIndex = 20;
			this.label17.Text = "- Wall Type: Select how the lander reacts when it hits a side wall";
			// 
			// FormHelp
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(748, 583);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.Okbtn);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
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
			this.Name = "FormHelp";
			this.Text = "Case in Space Help";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.FormHelp_Closing);
			this.ResumeLayout(false);

		}
		#endregion

		private void Okbtn_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void FormHelp_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = true;
			Visible = false;
		}
	}
}
