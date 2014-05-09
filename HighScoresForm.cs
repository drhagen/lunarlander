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
 * Part 5 of 8
*/ 
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace LunarLander
{
	/// <summary>
	/// Summary description for HighScoresForm.
	/// </summary>
	public class HighScoresForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button okbtn;
		private System.Windows.Forms.Button cancelbtn;
		private System.Windows.Forms.Label ranklbl;
		private System.Windows.Forms.Label namelbl;
		private System.Windows.Forms.Label scorelbl;
		private System.Windows.Forms.Label rank1;
		private System.Windows.Forms.Label rank2;
		private System.Windows.Forms.Label rank3;
		private System.Windows.Forms.Label rank4;
		private System.Windows.Forms.Label rank5;
		private System.Windows.Forms.Label rank6;
		private System.Windows.Forms.Label rank7;
		private System.Windows.Forms.Label rank8;
		private System.Windows.Forms.Label rank9;
		private System.Windows.Forms.Label rank10;
		private System.Windows.Forms.Label name1;
		private System.Windows.Forms.Label name2;
		private System.Windows.Forms.Label name3;
		private System.Windows.Forms.Label name4;
		private System.Windows.Forms.Label name5;
		private System.Windows.Forms.Label name6;
		private System.Windows.Forms.Label name7;
		private System.Windows.Forms.Label name8;
		private System.Windows.Forms.Label name9;
		private System.Windows.Forms.Label name10;
		private System.Windows.Forms.Label score1;
		private System.Windows.Forms.Label score2;
		private System.Windows.Forms.Label score3;
		private System.Windows.Forms.Label score4;
		private System.Windows.Forms.Label score5;
		private System.Windows.Forms.Label score6;
		private System.Windows.Forms.Label score7;
		private System.Windows.Forms.Label score8;
		private System.Windows.Forms.Label score9;
		private System.Windows.Forms.Label score10;
		private System.Windows.Forms.TextBox Winbox1;
		private System.Windows.Forms.TextBox Winbox2;
		private System.Windows.Forms.TextBox Winbox3;
		private System.Windows.Forms.TextBox Winbox5;
		private System.Windows.Forms.TextBox Winbox4;
		private System.Windows.Forms.TextBox Winbox6;
		private System.Windows.Forms.TextBox Winbox7;
		private System.Windows.Forms.TextBox Winbox8;
		private System.Windows.Forms.TextBox Winbox9;
		private System.Windows.Forms.TextBox Winbox10;

		public Score[] Scores;
		private Label[] Nlbls;
		private TextBox[] Wboxes;
		private bool Win;
		private Score Hold;
		private int Stop;
		private System.Windows.Forms.Label Congratslbl;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public HighScoresForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			Scores = new Score[10] {new Score("", 0), new Score("", 0), new Score("", 0), new Score("", 0), new Score("", 0), new Score("", 0), new Score("", 0), new Score("", 0), new Score("", 0), new Score("", 0)};
			Nlbls = new Label[10] {name1, name2, name3, name4, name5, name6, name7, name8, name9, name10};
			Wboxes = new TextBox[10] {Winbox1, Winbox2, Winbox3, Winbox4, Winbox5, Winbox6, Winbox7, Winbox8, Winbox9, Winbox10};
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
			this.okbtn = new System.Windows.Forms.Button();
			this.cancelbtn = new System.Windows.Forms.Button();
			this.ranklbl = new System.Windows.Forms.Label();
			this.namelbl = new System.Windows.Forms.Label();
			this.scorelbl = new System.Windows.Forms.Label();
			this.rank1 = new System.Windows.Forms.Label();
			this.rank2 = new System.Windows.Forms.Label();
			this.rank3 = new System.Windows.Forms.Label();
			this.rank4 = new System.Windows.Forms.Label();
			this.rank5 = new System.Windows.Forms.Label();
			this.rank6 = new System.Windows.Forms.Label();
			this.rank7 = new System.Windows.Forms.Label();
			this.rank8 = new System.Windows.Forms.Label();
			this.rank9 = new System.Windows.Forms.Label();
			this.rank10 = new System.Windows.Forms.Label();
			this.name1 = new System.Windows.Forms.Label();
			this.name2 = new System.Windows.Forms.Label();
			this.name3 = new System.Windows.Forms.Label();
			this.name4 = new System.Windows.Forms.Label();
			this.name5 = new System.Windows.Forms.Label();
			this.name6 = new System.Windows.Forms.Label();
			this.name7 = new System.Windows.Forms.Label();
			this.name8 = new System.Windows.Forms.Label();
			this.name9 = new System.Windows.Forms.Label();
			this.name10 = new System.Windows.Forms.Label();
			this.score1 = new System.Windows.Forms.Label();
			this.score2 = new System.Windows.Forms.Label();
			this.score3 = new System.Windows.Forms.Label();
			this.score4 = new System.Windows.Forms.Label();
			this.score5 = new System.Windows.Forms.Label();
			this.score6 = new System.Windows.Forms.Label();
			this.score7 = new System.Windows.Forms.Label();
			this.score8 = new System.Windows.Forms.Label();
			this.score9 = new System.Windows.Forms.Label();
			this.score10 = new System.Windows.Forms.Label();
			this.Winbox1 = new System.Windows.Forms.TextBox();
			this.Winbox2 = new System.Windows.Forms.TextBox();
			this.Winbox3 = new System.Windows.Forms.TextBox();
			this.Winbox5 = new System.Windows.Forms.TextBox();
			this.Winbox4 = new System.Windows.Forms.TextBox();
			this.Winbox6 = new System.Windows.Forms.TextBox();
			this.Winbox7 = new System.Windows.Forms.TextBox();
			this.Winbox8 = new System.Windows.Forms.TextBox();
			this.Winbox9 = new System.Windows.Forms.TextBox();
			this.Winbox10 = new System.Windows.Forms.TextBox();
			this.Congratslbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// okbtn
			// 
			this.okbtn.BackColor = System.Drawing.Color.Black;
			this.okbtn.ForeColor = System.Drawing.Color.White;
			this.okbtn.Location = new System.Drawing.Point(296, 392);
			this.okbtn.Name = "okbtn";
			this.okbtn.Size = new System.Drawing.Size(90, 27);
			this.okbtn.TabIndex = 100;
			this.okbtn.Text = "OK";
			this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
			// 
			// cancelbtn
			// 
			this.cancelbtn.ForeColor = System.Drawing.Color.White;
			this.cancelbtn.Location = new System.Drawing.Point(408, 392);
			this.cancelbtn.Name = "cancelbtn";
			this.cancelbtn.Size = new System.Drawing.Size(90, 27);
			this.cancelbtn.TabIndex = 101;
			this.cancelbtn.Text = "Cancel";
			this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
			// 
			// ranklbl
			// 
			this.ranklbl.BackColor = System.Drawing.Color.Transparent;
			this.ranklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ranklbl.ForeColor = System.Drawing.Color.Red;
			this.ranklbl.Location = new System.Drawing.Point(24, 72);
			this.ranklbl.Name = "ranklbl";
			this.ranklbl.Size = new System.Drawing.Size(80, 27);
			this.ranklbl.TabIndex = 2;
			this.ranklbl.Text = "Rank";
			this.ranklbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// namelbl
			// 
			this.namelbl.BackColor = System.Drawing.Color.Transparent;
			this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.namelbl.ForeColor = System.Drawing.Color.Yellow;
			this.namelbl.Location = new System.Drawing.Point(160, 72);
			this.namelbl.Name = "namelbl";
			this.namelbl.Size = new System.Drawing.Size(120, 27);
			this.namelbl.TabIndex = 3;
			this.namelbl.Text = "Name";
			// 
			// scorelbl
			// 
			this.scorelbl.BackColor = System.Drawing.Color.Transparent;
			this.scorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.scorelbl.ForeColor = System.Drawing.Color.MediumBlue;
			this.scorelbl.Location = new System.Drawing.Point(400, 72);
			this.scorelbl.Name = "scorelbl";
			this.scorelbl.Size = new System.Drawing.Size(64, 27);
			this.scorelbl.TabIndex = 4;
			this.scorelbl.Text = "Score";
			this.scorelbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// rank1
			// 
			this.rank1.ForeColor = System.Drawing.Color.White;
			this.rank1.Location = new System.Drawing.Point(40, 128);
			this.rank1.Name = "rank1";
			this.rank1.Size = new System.Drawing.Size(50, 16);
			this.rank1.TabIndex = 5;
			this.rank1.Text = "1.";
			this.rank1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// rank2
			// 
			this.rank2.ForeColor = System.Drawing.Color.White;
			this.rank2.Location = new System.Drawing.Point(40, 152);
			this.rank2.Name = "rank2";
			this.rank2.Size = new System.Drawing.Size(50, 16);
			this.rank2.TabIndex = 6;
			this.rank2.Text = "2.";
			this.rank2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// rank3
			// 
			this.rank3.ForeColor = System.Drawing.Color.White;
			this.rank3.Location = new System.Drawing.Point(40, 176);
			this.rank3.Name = "rank3";
			this.rank3.Size = new System.Drawing.Size(50, 16);
			this.rank3.TabIndex = 7;
			this.rank3.Text = "3.";
			this.rank3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// rank4
			// 
			this.rank4.ForeColor = System.Drawing.Color.White;
			this.rank4.Location = new System.Drawing.Point(40, 200);
			this.rank4.Name = "rank4";
			this.rank4.Size = new System.Drawing.Size(50, 16);
			this.rank4.TabIndex = 8;
			this.rank4.Text = "4.";
			this.rank4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// rank5
			// 
			this.rank5.ForeColor = System.Drawing.Color.White;
			this.rank5.Location = new System.Drawing.Point(40, 224);
			this.rank5.Name = "rank5";
			this.rank5.Size = new System.Drawing.Size(50, 16);
			this.rank5.TabIndex = 9;
			this.rank5.Text = "5.";
			this.rank5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// rank6
			// 
			this.rank6.ForeColor = System.Drawing.Color.White;
			this.rank6.Location = new System.Drawing.Point(40, 248);
			this.rank6.Name = "rank6";
			this.rank6.Size = new System.Drawing.Size(50, 16);
			this.rank6.TabIndex = 10;
			this.rank6.Text = "6.";
			this.rank6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// rank7
			// 
			this.rank7.ForeColor = System.Drawing.Color.White;
			this.rank7.Location = new System.Drawing.Point(40, 272);
			this.rank7.Name = "rank7";
			this.rank7.Size = new System.Drawing.Size(50, 16);
			this.rank7.TabIndex = 11;
			this.rank7.Text = "7.";
			this.rank7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// rank8
			// 
			this.rank8.ForeColor = System.Drawing.Color.White;
			this.rank8.Location = new System.Drawing.Point(40, 296);
			this.rank8.Name = "rank8";
			this.rank8.Size = new System.Drawing.Size(50, 16);
			this.rank8.TabIndex = 12;
			this.rank8.Text = "8.";
			this.rank8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// rank9
			// 
			this.rank9.ForeColor = System.Drawing.Color.White;
			this.rank9.Location = new System.Drawing.Point(40, 320);
			this.rank9.Name = "rank9";
			this.rank9.Size = new System.Drawing.Size(50, 16);
			this.rank9.TabIndex = 13;
			this.rank9.Text = "9.";
			this.rank9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// rank10
			// 
			this.rank10.ForeColor = System.Drawing.Color.White;
			this.rank10.Location = new System.Drawing.Point(40, 344);
			this.rank10.Name = "rank10";
			this.rank10.Size = new System.Drawing.Size(50, 16);
			this.rank10.TabIndex = 14;
			this.rank10.Text = "10.";
			this.rank10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// name1
			// 
			this.name1.ForeColor = System.Drawing.Color.White;
			this.name1.Location = new System.Drawing.Point(152, 128);
			this.name1.Name = "name1";
			this.name1.Size = new System.Drawing.Size(200, 16);
			this.name1.TabIndex = 15;
			this.name1.Text = "joe";
			// 
			// name2
			// 
			this.name2.ForeColor = System.Drawing.Color.White;
			this.name2.Location = new System.Drawing.Point(152, 152);
			this.name2.Name = "name2";
			this.name2.Size = new System.Drawing.Size(200, 16);
			this.name2.TabIndex = 16;
			this.name2.Text = "joe";
			// 
			// name3
			// 
			this.name3.ForeColor = System.Drawing.Color.White;
			this.name3.Location = new System.Drawing.Point(152, 176);
			this.name3.Name = "name3";
			this.name3.Size = new System.Drawing.Size(200, 16);
			this.name3.TabIndex = 17;
			this.name3.Text = "joe";
			// 
			// name4
			// 
			this.name4.ForeColor = System.Drawing.Color.White;
			this.name4.Location = new System.Drawing.Point(152, 200);
			this.name4.Name = "name4";
			this.name4.Size = new System.Drawing.Size(200, 16);
			this.name4.TabIndex = 18;
			this.name4.Text = "joe";
			// 
			// name5
			// 
			this.name5.ForeColor = System.Drawing.Color.White;
			this.name5.Location = new System.Drawing.Point(152, 224);
			this.name5.Name = "name5";
			this.name5.Size = new System.Drawing.Size(200, 16);
			this.name5.TabIndex = 19;
			this.name5.Text = "joe";
			// 
			// name6
			// 
			this.name6.ForeColor = System.Drawing.Color.White;
			this.name6.Location = new System.Drawing.Point(152, 248);
			this.name6.Name = "name6";
			this.name6.Size = new System.Drawing.Size(200, 16);
			this.name6.TabIndex = 20;
			this.name6.Text = "joe";
			// 
			// name7
			// 
			this.name7.ForeColor = System.Drawing.Color.White;
			this.name7.Location = new System.Drawing.Point(152, 272);
			this.name7.Name = "name7";
			this.name7.Size = new System.Drawing.Size(200, 16);
			this.name7.TabIndex = 21;
			this.name7.Text = "joe";
			// 
			// name8
			// 
			this.name8.ForeColor = System.Drawing.Color.White;
			this.name8.Location = new System.Drawing.Point(152, 296);
			this.name8.Name = "name8";
			this.name8.Size = new System.Drawing.Size(200, 16);
			this.name8.TabIndex = 22;
			this.name8.Text = "joe";
			// 
			// name9
			// 
			this.name9.ForeColor = System.Drawing.Color.White;
			this.name9.Location = new System.Drawing.Point(152, 320);
			this.name9.Name = "name9";
			this.name9.Size = new System.Drawing.Size(200, 16);
			this.name9.TabIndex = 23;
			this.name9.Text = "joe";
			// 
			// name10
			// 
			this.name10.ForeColor = System.Drawing.Color.White;
			this.name10.Location = new System.Drawing.Point(152, 344);
			this.name10.Name = "name10";
			this.name10.Size = new System.Drawing.Size(200, 16);
			this.name10.TabIndex = 24;
			this.name10.Text = "joe";
			// 
			// score1
			// 
			this.score1.ForeColor = System.Drawing.Color.White;
			this.score1.Location = new System.Drawing.Point(392, 128);
			this.score1.Name = "score1";
			this.score1.Size = new System.Drawing.Size(75, 16);
			this.score1.TabIndex = 25;
			this.score1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// score2
			// 
			this.score2.ForeColor = System.Drawing.Color.White;
			this.score2.Location = new System.Drawing.Point(392, 152);
			this.score2.Name = "score2";
			this.score2.Size = new System.Drawing.Size(75, 16);
			this.score2.TabIndex = 26;
			this.score2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// score3
			// 
			this.score3.ForeColor = System.Drawing.Color.White;
			this.score3.Location = new System.Drawing.Point(392, 176);
			this.score3.Name = "score3";
			this.score3.Size = new System.Drawing.Size(75, 16);
			this.score3.TabIndex = 27;
			this.score3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// score4
			// 
			this.score4.ForeColor = System.Drawing.Color.White;
			this.score4.Location = new System.Drawing.Point(392, 200);
			this.score4.Name = "score4";
			this.score4.Size = new System.Drawing.Size(75, 16);
			this.score4.TabIndex = 28;
			this.score4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// score5
			// 
			this.score5.ForeColor = System.Drawing.Color.White;
			this.score5.Location = new System.Drawing.Point(392, 224);
			this.score5.Name = "score5";
			this.score5.Size = new System.Drawing.Size(75, 16);
			this.score5.TabIndex = 29;
			this.score5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// score6
			// 
			this.score6.ForeColor = System.Drawing.Color.White;
			this.score6.Location = new System.Drawing.Point(392, 248);
			this.score6.Name = "score6";
			this.score6.Size = new System.Drawing.Size(75, 16);
			this.score6.TabIndex = 30;
			this.score6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// score7
			// 
			this.score7.ForeColor = System.Drawing.Color.White;
			this.score7.Location = new System.Drawing.Point(392, 272);
			this.score7.Name = "score7";
			this.score7.Size = new System.Drawing.Size(75, 16);
			this.score7.TabIndex = 31;
			this.score7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// score8
			// 
			this.score8.ForeColor = System.Drawing.Color.White;
			this.score8.Location = new System.Drawing.Point(392, 296);
			this.score8.Name = "score8";
			this.score8.Size = new System.Drawing.Size(75, 16);
			this.score8.TabIndex = 32;
			this.score8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// score9
			// 
			this.score9.ForeColor = System.Drawing.Color.White;
			this.score9.Location = new System.Drawing.Point(392, 320);
			this.score9.Name = "score9";
			this.score9.Size = new System.Drawing.Size(75, 16);
			this.score9.TabIndex = 33;
			this.score9.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// score10
			// 
			this.score10.ForeColor = System.Drawing.Color.White;
			this.score10.Location = new System.Drawing.Point(392, 344);
			this.score10.Name = "score10";
			this.score10.Size = new System.Drawing.Size(75, 16);
			this.score10.TabIndex = 34;
			this.score10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Winbox1
			// 
			this.Winbox1.BackColor = System.Drawing.Color.Black;
			this.Winbox1.ForeColor = System.Drawing.Color.White;
			this.Winbox1.Location = new System.Drawing.Point(152, 120);
			this.Winbox1.Name = "Winbox1";
			this.Winbox1.Size = new System.Drawing.Size(136, 22);
			this.Winbox1.TabIndex = 35;
			this.Winbox1.Text = "";
			this.Winbox1.Visible = false;
			// 
			// Winbox2
			// 
			this.Winbox2.BackColor = System.Drawing.Color.Black;
			this.Winbox2.ForeColor = System.Drawing.Color.White;
			this.Winbox2.Location = new System.Drawing.Point(152, 144);
			this.Winbox2.Name = "Winbox2";
			this.Winbox2.Size = new System.Drawing.Size(136, 22);
			this.Winbox2.TabIndex = 36;
			this.Winbox2.Text = "";
			this.Winbox2.Visible = false;
			// 
			// Winbox3
			// 
			this.Winbox3.BackColor = System.Drawing.Color.Black;
			this.Winbox3.ForeColor = System.Drawing.Color.White;
			this.Winbox3.Location = new System.Drawing.Point(152, 168);
			this.Winbox3.Name = "Winbox3";
			this.Winbox3.Size = new System.Drawing.Size(136, 22);
			this.Winbox3.TabIndex = 37;
			this.Winbox3.Text = "";
			this.Winbox3.Visible = false;
			// 
			// Winbox5
			// 
			this.Winbox5.BackColor = System.Drawing.Color.Black;
			this.Winbox5.ForeColor = System.Drawing.Color.White;
			this.Winbox5.Location = new System.Drawing.Point(152, 216);
			this.Winbox5.Name = "Winbox5";
			this.Winbox5.Size = new System.Drawing.Size(136, 22);
			this.Winbox5.TabIndex = 38;
			this.Winbox5.Text = "";
			this.Winbox5.Visible = false;
			// 
			// Winbox4
			// 
			this.Winbox4.BackColor = System.Drawing.Color.Black;
			this.Winbox4.ForeColor = System.Drawing.Color.White;
			this.Winbox4.Location = new System.Drawing.Point(152, 192);
			this.Winbox4.Name = "Winbox4";
			this.Winbox4.Size = new System.Drawing.Size(136, 22);
			this.Winbox4.TabIndex = 39;
			this.Winbox4.Text = "";
			this.Winbox4.Visible = false;
			// 
			// Winbox6
			// 
			this.Winbox6.BackColor = System.Drawing.Color.Black;
			this.Winbox6.ForeColor = System.Drawing.Color.White;
			this.Winbox6.Location = new System.Drawing.Point(152, 240);
			this.Winbox6.Name = "Winbox6";
			this.Winbox6.Size = new System.Drawing.Size(136, 22);
			this.Winbox6.TabIndex = 40;
			this.Winbox6.Text = "";
			this.Winbox6.Visible = false;
			// 
			// Winbox7
			// 
			this.Winbox7.BackColor = System.Drawing.Color.Black;
			this.Winbox7.ForeColor = System.Drawing.Color.White;
			this.Winbox7.Location = new System.Drawing.Point(152, 264);
			this.Winbox7.Name = "Winbox7";
			this.Winbox7.Size = new System.Drawing.Size(136, 22);
			this.Winbox7.TabIndex = 41;
			this.Winbox7.Text = "";
			this.Winbox7.Visible = false;
			// 
			// Winbox8
			// 
			this.Winbox8.BackColor = System.Drawing.Color.Black;
			this.Winbox8.ForeColor = System.Drawing.Color.White;
			this.Winbox8.Location = new System.Drawing.Point(152, 288);
			this.Winbox8.Name = "Winbox8";
			this.Winbox8.Size = new System.Drawing.Size(136, 22);
			this.Winbox8.TabIndex = 42;
			this.Winbox8.Text = "";
			this.Winbox8.Visible = false;
			// 
			// Winbox9
			// 
			this.Winbox9.BackColor = System.Drawing.Color.Black;
			this.Winbox9.ForeColor = System.Drawing.Color.White;
			this.Winbox9.Location = new System.Drawing.Point(152, 312);
			this.Winbox9.Name = "Winbox9";
			this.Winbox9.Size = new System.Drawing.Size(136, 22);
			this.Winbox9.TabIndex = 43;
			this.Winbox9.Text = "";
			this.Winbox9.Visible = false;
			// 
			// Winbox10
			// 
			this.Winbox10.BackColor = System.Drawing.Color.Black;
			this.Winbox10.ForeColor = System.Drawing.Color.White;
			this.Winbox10.Location = new System.Drawing.Point(152, 336);
			this.Winbox10.Name = "Winbox10";
			this.Winbox10.Size = new System.Drawing.Size(136, 22);
			this.Winbox10.TabIndex = 44;
			this.Winbox10.Text = "";
			this.Winbox10.Visible = false;
			// 
			// Congratslbl
			// 
			this.Congratslbl.Font = new System.Drawing.Font("Goudy Old Style", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Congratslbl.ForeColor = System.Drawing.Color.Red;
			this.Congratslbl.Location = new System.Drawing.Point(128, 0);
			this.Congratslbl.Name = "Congratslbl";
			this.Congratslbl.Size = new System.Drawing.Size(264, 56);
			this.Congratslbl.TabIndex = 45;
			this.Congratslbl.Text = "President Hundert finds you inciting and provocative!";
			this.Congratslbl.Visible = false;
			// 
			// HighScoresForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(518, 437);
			this.Controls.Add(this.Congratslbl);
			this.Controls.Add(this.Winbox10);
			this.Controls.Add(this.Winbox9);
			this.Controls.Add(this.Winbox8);
			this.Controls.Add(this.Winbox7);
			this.Controls.Add(this.Winbox6);
			this.Controls.Add(this.Winbox4);
			this.Controls.Add(this.Winbox5);
			this.Controls.Add(this.Winbox3);
			this.Controls.Add(this.Winbox2);
			this.Controls.Add(this.Winbox1);
			this.Controls.Add(this.score10);
			this.Controls.Add(this.score9);
			this.Controls.Add(this.score8);
			this.Controls.Add(this.score7);
			this.Controls.Add(this.score6);
			this.Controls.Add(this.score5);
			this.Controls.Add(this.score4);
			this.Controls.Add(this.score3);
			this.Controls.Add(this.score2);
			this.Controls.Add(this.score1);
			this.Controls.Add(this.name10);
			this.Controls.Add(this.name9);
			this.Controls.Add(this.name8);
			this.Controls.Add(this.name7);
			this.Controls.Add(this.name6);
			this.Controls.Add(this.name5);
			this.Controls.Add(this.name4);
			this.Controls.Add(this.name3);
			this.Controls.Add(this.name2);
			this.Controls.Add(this.name1);
			this.Controls.Add(this.rank10);
			this.Controls.Add(this.rank9);
			this.Controls.Add(this.rank8);
			this.Controls.Add(this.rank7);
			this.Controls.Add(this.rank6);
			this.Controls.Add(this.rank5);
			this.Controls.Add(this.rank4);
			this.Controls.Add(this.rank3);
			this.Controls.Add(this.rank2);
			this.Controls.Add(this.rank1);
			this.Controls.Add(this.scorelbl);
			this.Controls.Add(this.namelbl);
			this.Controls.Add(this.ranklbl);
			this.Controls.Add(this.cancelbtn);
			this.Controls.Add(this.okbtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "HighScoresForm";
			this.Text = "Case in Space High Scores";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.HighScoresForm_Closing);
			this.VisibleChanged += new System.EventHandler(this.HighScoresForm_VisibleChanged);
			this.ResumeLayout(false);

		}
		#endregion

		private void okbtn_Click(object sender, System.EventArgs e)
		{
			if(Win)
			{
				Scores[Stop].name = Wboxes[9 - Stop].Text;
				Wboxes[9 - Stop].Text = "";
				Wboxes[9 - Stop].Visible = false;
				Nlbls[9 - Stop].Visible = true;
				Congratslbl.Visible = false;
				Win = false;
				RefreshTable();
			}
			this.Visible = false;
		}

		private void cancelbtn_Click(object sender, System.EventArgs e)
		{
			this.Visible = false;
		}

		public void HighScore(int ScoreTot)
		{
			if (ScoreTot > Scores[0].score)
			{
				Win = true;
				Hold = Scores[0];
				Score insert = new Score("blank", ScoreTot);
				Scores[0] = insert;
				Score temp;
				int i = 1;
				while(i <= 9 && ScoreTot > Scores[i].score)
				{
					temp = Scores[i];
					Scores[i] = Scores[i - 1];
					Scores[i - 1] = temp;
					Stop = i;
					i++;
				}
				Nlbls[9 - Stop].Visible = false;
				Wboxes[9 - Stop].Visible = true;
				Congratslbl.Visible = true;
				RefreshTable();
				this.Visible = true;
			}
		}

		private void RefreshTable()
		{
			name1.Text = Scores[9].name;
			name2.Text = Scores[8].name;
			name3.Text = Scores[7].name;
			name4.Text = Scores[6].name;
			name5.Text = Scores[5].name;
			name6.Text = Scores[4].name;
			name7.Text = Scores[3].name;
			name8.Text = Scores[2].name;
			name9.Text = Scores[1].name;
			name10.Text = Scores[0].name;
			score1.Text = Scores[9].score.ToString();
			score2.Text = Scores[8].score.ToString();
			score3.Text = Scores[7].score.ToString();
			score4.Text = Scores[6].score.ToString();
			score5.Text = Scores[5].score.ToString();
			score6.Text = Scores[4].score.ToString();
			score7.Text = Scores[3].score.ToString();
			score8.Text = Scores[2].score.ToString();
			score9.Text = Scores[1].score.ToString();
			score10.Text = Scores[0].score.ToString();
		}

		private void HighScoresForm_VisibleChanged(object sender, System.EventArgs e)
		{
			if(Win && this.Visible == false)
			{
				Scores[Stop].name = Wboxes[9 - Stop].Text;
				Wboxes[9 - Stop].Text = "";
				Wboxes[9 - Stop].Visible = false;
				Nlbls[9 - Stop].Visible = true;
				Congratslbl.Visible = false;
				Win = false;
			}
			RefreshTable();
		}

		private void HighScoresForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = true;
			Visible = false;
		}
	}
}
