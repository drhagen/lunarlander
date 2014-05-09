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
 * Part 1 of 8
*/ 
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Drawing.Drawing2D;

namespace LunarLander
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Timer Timer1;
		private System.Windows.Forms.Timer Timer2;
		private System.Windows.Forms.Label PauseLbl;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem ngame;
		private System.Windows.Forms.MenuItem pgame;
		private System.Windows.Forms.MenuItem hscores;
		private System.Windows.Forms.MenuItem Difficulty;
		private System.Windows.Forms.MenuItem Easy;
		private System.Windows.Forms.MenuItem Medium;
		private System.Windows.Forms.MenuItem Exit;
		private System.Windows.Forms.Label hVellbl;
		private System.Windows.Forms.Label vVellbl;
		private System.Windows.Forms.Label vVelNumlbl;
		private System.Windows.Forms.Label hVelNumlbl;
		private System.Windows.Forms.MenuItem Hard;
		private System.Windows.Forms.MenuItem VeryHard;
		private System.Windows.Forms.MenuItem BackPicItem;
		private System.Windows.Forms.MenuItem PicItem1;
		private System.Windows.Forms.MenuItem PicItem2;
		private System.Windows.Forms.MenuItem PicItem3;
		private System.Windows.Forms.MenuItem CtrlItem;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.Label HighScorelbl;
		private System.Windows.Forms.Label CurScorelbl;
		private System.Windows.Forms.Label TotScorelbl;
		private System.Windows.Forms.MenuItem HelpPageItem;
		private System.Windows.Forms.MenuItem AboutItem;
		private System.Windows.Forms.Label Winlbl1;
		private System.Windows.Forms.Label Winlbl2;
		private System.Windows.Forms.Label Startlbl;
		private System.Windows.Forms.MenuItem SkipItem;
		private System.Windows.Forms.MenuItem WallItem;
		private System.Windows.Forms.MenuItem WallItem1;
		private System.Windows.Forms.MenuItem WallItem2;
		private System.Windows.Forms.MenuItem WallItem3;
		private System.Windows.Forms.Label Destlbl2;
		private System.Windows.Forms.Label Destlbl1;
		private System.Windows.Forms.Label Introlbl;

		private LunarLander Lander;
		private Terrain Surface;
		private FormKeys FormKeys1;
		private HighScoresForm HighScoresForm1;
		private FormHelp FormHelp1;
		private FormAbout FormAbout1;

		private int xBin;
		private int yBin;
		private int FullBin;
		private int SafeH;
		private int SafeV;

		private int Cycle;
		private int RefreshPeriod;
		private Rectangle OldBounds;

		private int hThrusters;
		private int vThrusters;
		private int hThrusterStrength;
		private int vThrusterStrength;
		private int GravityStrength;
		private int Condition;

		private int DiffOp;
		private int WallType;
		private bool ShowStars;

		private bool SkipIntro;
		private bool IntroRunning;
		private int iBin;
		private System.Windows.Forms.Label Cover;
		private Bitmap HundertPic;
		private Bitmap CheneyPic;
		private Bitmap EdwardsPic;
		private Bitmap AndersPic;
		private Bitmap ShackPic;
		private bool HThere;
		private bool CThere;
		private bool EThere;
		private bool AThere;
		private bool SThere;

		private Bitmap CaseFlag;

		private PointF[][] vertices1=new PointF[42][];
		private PointF[][] vertices2=new PointF[35][];
		private GraphicsPath[] polygon1=new GraphicsPath[42];
		private GraphicsPath[] polygon2=new GraphicsPath[35];
		private Region[] region1=new Region[42];
		private Region[] region2=new Region[35];
		private int X=120;
		private int Y=80;
		private int M=60;
		private int N=40;

		private int ScoreCurr;
		private int ScoreTot;
		private int ScoreHigh;
		private int ScoreMax;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);

			Surface = new Terrain();
			Lander = new LunarLander();
			FormKeys1 = new FormKeys();
			HighScoresForm1 = new HighScoresForm();
			FormHelp1 = new FormHelp();
			FormAbout1 = new FormAbout();

			FullBin = 75;
			SafeH = 50;
			SafeV = 150;
			RefreshPeriod = 6;
			hThrusterStrength = 3;
			vThrusterStrength = 6;
			GravityStrength = 2;
			Condition = 0;

			DiffOp = 1;
			WallType = 0;
			ShowStars = true;

			SkipIntro = false;
			IntroRunning = true;
			iBin = 0;
			HundertPic = new Bitmap("hundert.bmp");
			CheneyPic = new Bitmap("cheney.bmp");
			EdwardsPic = new Bitmap("edwards.bmp");
			AndersPic = new Bitmap("anders.bmp");
			ShackPic = new Bitmap("shacks.bmp");
			this.Cover = new System.Windows.Forms.Label();
				this.Cover.BackColor = System.Drawing.Color.Black;
				this.Cover.ForeColor = System.Drawing.Color.Black;
				this.Cover.Location = new System.Drawing.Point(0, 0);
				this.Cover.Name = "Cover";
				this.Cover.Size = new System.Drawing.Size(800, 600);
				this.Cover.TabIndex = 50;
				this.Cover.Text = "";
				this.Cover.Visible = false;

			ScoreCurr = ScoreMax = 500;
			ScoreHigh = HighScoresForm1.Scores[9].score;
			HighScorelbl.Text = "High Score: " + ScoreHigh.ToString();
			
			CaseFlag = new Bitmap("caseflag.bmp");

			for(int x=0; x<7; x++)
			{
				for(int y=0; y<6; y++)
				{
					vertices1[x+7*y]=new PointF[10]{new PointF(0+X*x,6+Y*y),new PointF(6+X*x,6+Y*y),new PointF(8+X*x,0+Y*y),new PointF(10+X*x,6+Y*y),new PointF(16+X*x,6+Y*y),new PointF(11+X*x,9+Y*y),new PointF(13+X*x,15+Y*y),new PointF(8+X*x,11+Y*y),new PointF(3+X*x,15+Y*y),new PointF(5+X*x,9+Y*y)};
				}
			}
			for(int x=0; x<7; x++)
			{
				for(int y=0; y<5; y++)
				{
					vertices2[x+7*y]=new PointF[10]{new PointF(0+M+X*x,6+N+Y*y),new PointF(6+M+X*x,6+N+Y*y),new PointF(8+M+X*x,0+N+Y*y),new PointF(10+M+X*x,6+N+Y*y),new PointF(16+M+X*x,6+N+Y*y),new PointF(11+M+X*x,9+N+Y*y),new PointF(13+M+X*x,15+N+Y*y),new PointF(8+M+X*x,11+N+Y*y),new PointF(3+M+X*x,15+N+Y*y),new PointF(5+M+X*x,9+N+Y*y)};
				}
			}
			for(int i=0; i<1; i++)
			{
				polygon1[i]=new GraphicsPath();
				polygon1[i].AddPolygon(vertices1[i]);
				region1[i]=new Region(polygon1[i]);

				polygon2[i]=new GraphicsPath();
				polygon2[i].AddPolygon(vertices2[i]);
				region2[i]=new Region(polygon2[i]);
			}

			this.Paint += new PaintEventHandler(Form1_Paint);
			this.Paint += new PaintEventHandler(Intro_Paint);
			Timer1.Tick += new EventHandler(ChangePosition);
			Timer2.Tick += new EventHandler(ShowIntro);
			this.KeyDown += new KeyEventHandler(Form1_KeyDown);
			this.KeyUp += new KeyEventHandler(Form1_KeyUp);
			this.Closing += new CancelEventHandler(Form1_Closing);
			FormKeys1.VisibleChanged += new EventHandler(FormKeys1_VisibleChanged);

			LoadState();
			if(SkipIntro)
			{
				IntroRunning = false;
				NewGame();
			}
			else
			{
				this.Paint -= new PaintEventHandler(Form1_Paint);
				Timer2.Start();
				HighScorelbl.Visible = false;
				TotScorelbl.Visible = false;
				CurScorelbl.Visible = false;
				hVellbl.Visible = false;
				vVellbl.Visible = false;
				hVelNumlbl.Visible = false;
				vVelNumlbl.Visible = false;
				Cover.Visible = true;
			}
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			this.components = new System.ComponentModel.Container();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.PauseLbl = new System.Windows.Forms.Label();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.ngame = new System.Windows.Forms.MenuItem();
			this.pgame = new System.Windows.Forms.MenuItem();
			this.hscores = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.Exit = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.Difficulty = new System.Windows.Forms.MenuItem();
			this.Easy = new System.Windows.Forms.MenuItem();
			this.Medium = new System.Windows.Forms.MenuItem();
			this.Hard = new System.Windows.Forms.MenuItem();
			this.VeryHard = new System.Windows.Forms.MenuItem();
			this.BackPicItem = new System.Windows.Forms.MenuItem();
			this.PicItem1 = new System.Windows.Forms.MenuItem();
			this.PicItem2 = new System.Windows.Forms.MenuItem();
			this.PicItem3 = new System.Windows.Forms.MenuItem();
			this.WallItem = new System.Windows.Forms.MenuItem();
			this.WallItem1 = new System.Windows.Forms.MenuItem();
			this.WallItem2 = new System.Windows.Forms.MenuItem();
			this.WallItem3 = new System.Windows.Forms.MenuItem();
			this.SkipItem = new System.Windows.Forms.MenuItem();
			this.CtrlItem = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.HelpPageItem = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.AboutItem = new System.Windows.Forms.MenuItem();
			this.hVellbl = new System.Windows.Forms.Label();
			this.vVellbl = new System.Windows.Forms.Label();
			this.vVelNumlbl = new System.Windows.Forms.Label();
			this.hVelNumlbl = new System.Windows.Forms.Label();
			this.HighScorelbl = new System.Windows.Forms.Label();
			this.CurScorelbl = new System.Windows.Forms.Label();
			this.TotScorelbl = new System.Windows.Forms.Label();
			this.Winlbl1 = new System.Windows.Forms.Label();
			this.Winlbl2 = new System.Windows.Forms.Label();
			this.Startlbl = new System.Windows.Forms.Label();
			this.Timer2 = new System.Windows.Forms.Timer(this.components);
			this.Introlbl = new System.Windows.Forms.Label();
			this.Destlbl2 = new System.Windows.Forms.Label();
			this.Destlbl1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Timer1
			// 
			this.Timer1.Interval = 1;
			// 
			// PauseLbl
			// 
			this.PauseLbl.BackColor = System.Drawing.Color.Transparent;
			this.PauseLbl.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.PauseLbl.ForeColor = System.Drawing.Color.Red;
			this.PauseLbl.Location = new System.Drawing.Point(280, 224);
			this.PauseLbl.Name = "PauseLbl";
			this.PauseLbl.Size = new System.Drawing.Size(264, 32);
			this.PauseLbl.TabIndex = 0;
			this.PauseLbl.Text = "Paused (F3 to resume)";
			this.PauseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.PauseLbl.Visible = false;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem2,
																					  this.menuItem3});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.ngame,
																					  this.pgame,
																					  this.hscores,
																					  this.menuItem7,
																					  this.Exit});
			this.menuItem1.Text = "Game";
			// 
			// ngame
			// 
			this.ngame.Index = 0;
			this.ngame.Shortcut = System.Windows.Forms.Shortcut.F2;
			this.ngame.Text = "New Game";
			this.ngame.Click += new System.EventHandler(this.ngame_Click);
			// 
			// pgame
			// 
			this.pgame.Index = 1;
			this.pgame.Shortcut = System.Windows.Forms.Shortcut.F3;
			this.pgame.Text = "Pause Game";
			this.pgame.Click += new System.EventHandler(this.pgame_Click);
			// 
			// hscores
			// 
			this.hscores.Index = 2;
			this.hscores.Text = "High Scores...";
			this.hscores.Click += new System.EventHandler(this.hscores_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 3;
			this.menuItem7.Text = "-";
			// 
			// Exit
			// 
			this.Exit.Index = 4;
			this.Exit.Text = "Exit";
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.Difficulty,
																					  this.BackPicItem,
																					  this.WallItem,
																					  this.SkipItem,
																					  this.CtrlItem});
			this.menuItem2.Text = "Options";
			// 
			// Difficulty
			// 
			this.Difficulty.Index = 0;
			this.Difficulty.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.Easy,
																					   this.Medium,
																					   this.Hard,
																					   this.VeryHard});
			this.Difficulty.Text = "Difficulty";
			// 
			// Easy
			// 
			this.Easy.Index = 0;
			this.Easy.Text = "Fine Arts";
			this.Easy.Click += new System.EventHandler(this.Easy_Click);
			// 
			// Medium
			// 
			this.Medium.Checked = true;
			this.Medium.Index = 1;
			this.Medium.Text = "Business";
			this.Medium.Click += new System.EventHandler(this.Medium_Click);
			// 
			// Hard
			// 
			this.Hard.Index = 2;
			this.Hard.Text = "Engineering";
			this.Hard.Click += new System.EventHandler(this.Hard_Click);
			// 
			// VeryHard
			// 
			this.VeryHard.Index = 3;
			this.VeryHard.Text = "Science";
			this.VeryHard.Click += new System.EventHandler(this.VeryHard_Click);
			// 
			// BackPicItem
			// 
			this.BackPicItem.Index = 1;
			this.BackPicItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.PicItem1,
																						this.PicItem2,
																						this.PicItem3});
			this.BackPicItem.Text = "Background Picture";
			// 
			// PicItem1
			// 
			this.PicItem1.Checked = true;
			this.PicItem1.Index = 0;
			this.PicItem1.Text = "5-Points";
			this.PicItem1.Click += new System.EventHandler(this.PicItem1_Click);
			// 
			// PicItem2
			// 
			this.PicItem2.Index = 1;
			this.PicItem2.Text = "Hubble Deep Field";
			this.PicItem2.Click += new System.EventHandler(this.PicItem2_Click);
			// 
			// PicItem3
			// 
			this.PicItem3.Index = 2;
			this.PicItem3.Text = "Earth at Night";
			this.PicItem3.Click += new System.EventHandler(this.PicItem3_Click);
			// 
			// WallItem
			// 
			this.WallItem.Index = 2;
			this.WallItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.WallItem1,
																					 this.WallItem2,
																					 this.WallItem3});
			this.WallItem.Text = "Wall Type";
			// 
			// WallItem1
			// 
			this.WallItem1.Index = 0;
			this.WallItem1.Text = "Reflecting";
			this.WallItem1.Click += new System.EventHandler(this.WallItem1_Click);
			// 
			// WallItem2
			// 
			this.WallItem2.Index = 1;
			this.WallItem2.Text = "Hard";
			this.WallItem2.Click += new System.EventHandler(this.WallItem2_Click);
			// 
			// WallItem3
			// 
			this.WallItem3.Index = 2;
			this.WallItem3.Text = "Sticky";
			this.WallItem3.Click += new System.EventHandler(this.WallItem3_Click);
			// 
			// SkipItem
			// 
			this.SkipItem.Index = 3;
			this.SkipItem.Text = "Skip Intro";
			this.SkipItem.Click += new System.EventHandler(this.SkipItem_Click);
			// 
			// CtrlItem
			// 
			this.CtrlItem.Index = 4;
			this.CtrlItem.Shortcut = System.Windows.Forms.Shortcut.F8;
			this.CtrlItem.Text = "Player Controls...";
			this.CtrlItem.Click += new System.EventHandler(this.CtrlItem_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.HelpPageItem,
																					  this.menuItem5,
																					  this.AboutItem});
			this.menuItem3.Text = "About";
			// 
			// HelpPageItem
			// 
			this.HelpPageItem.Index = 0;
			this.HelpPageItem.Shortcut = System.Windows.Forms.Shortcut.F1;
			this.HelpPageItem.Text = "Help Page...";
			this.HelpPageItem.Click += new System.EventHandler(this.HelpPage_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.Text = "-";
			// 
			// AboutItem
			// 
			this.AboutItem.Index = 2;
			this.AboutItem.Text = "About Case in Space...";
			this.AboutItem.Click += new System.EventHandler(this.About_Click);
			// 
			// hVellbl
			// 
			this.hVellbl.BackColor = System.Drawing.Color.Transparent;
			this.hVellbl.ForeColor = System.Drawing.Color.White;
			this.hVellbl.Location = new System.Drawing.Point(584, 40);
			this.hVellbl.Name = "hVellbl";
			this.hVellbl.Size = new System.Drawing.Size(120, 16);
			this.hVellbl.TabIndex = 1;
			this.hVellbl.Text = "Horizontal Velocity:";
			this.hVellbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// vVellbl
			// 
			this.vVellbl.BackColor = System.Drawing.Color.Transparent;
			this.vVellbl.ForeColor = System.Drawing.Color.White;
			this.vVellbl.Location = new System.Drawing.Point(584, 64);
			this.vVellbl.Name = "vVellbl";
			this.vVellbl.Size = new System.Drawing.Size(120, 16);
			this.vVellbl.TabIndex = 2;
			this.vVellbl.Text = "Vertical Velocity:";
			this.vVellbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// vVelNumlbl
			// 
			this.vVelNumlbl.BackColor = System.Drawing.Color.Transparent;
			this.vVelNumlbl.ForeColor = System.Drawing.Color.White;
			this.vVelNumlbl.Location = new System.Drawing.Point(704, 64);
			this.vVelNumlbl.Name = "vVelNumlbl";
			this.vVelNumlbl.Size = new System.Drawing.Size(64, 16);
			this.vVelNumlbl.TabIndex = 3;
			this.vVelNumlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// hVelNumlbl
			// 
			this.hVelNumlbl.BackColor = System.Drawing.Color.Transparent;
			this.hVelNumlbl.ForeColor = System.Drawing.Color.White;
			this.hVelNumlbl.Location = new System.Drawing.Point(704, 40);
			this.hVelNumlbl.Name = "hVelNumlbl";
			this.hVelNumlbl.Size = new System.Drawing.Size(64, 16);
			this.hVelNumlbl.TabIndex = 4;
			this.hVelNumlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// HighScorelbl
			// 
			this.HighScorelbl.BackColor = System.Drawing.Color.Transparent;
			this.HighScorelbl.ForeColor = System.Drawing.Color.White;
			this.HighScorelbl.Location = new System.Drawing.Point(96, 504);
			this.HighScorelbl.Name = "HighScorelbl";
			this.HighScorelbl.Size = new System.Drawing.Size(175, 16);
			this.HighScorelbl.TabIndex = 5;
			this.HighScorelbl.Text = "High Score:";
			this.HighScorelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// CurScorelbl
			// 
			this.CurScorelbl.BackColor = System.Drawing.Color.Transparent;
			this.CurScorelbl.ForeColor = System.Drawing.Color.White;
			this.CurScorelbl.Location = new System.Drawing.Point(288, 504);
			this.CurScorelbl.Name = "CurScorelbl";
			this.CurScorelbl.Size = new System.Drawing.Size(175, 16);
			this.CurScorelbl.TabIndex = 6;
			this.CurScorelbl.Text = "Current Score:";
			this.CurScorelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TotScorelbl
			// 
			this.TotScorelbl.BackColor = System.Drawing.Color.Transparent;
			this.TotScorelbl.ForeColor = System.Drawing.Color.White;
			this.TotScorelbl.Location = new System.Drawing.Point(480, 504);
			this.TotScorelbl.Name = "TotScorelbl";
			this.TotScorelbl.Size = new System.Drawing.Size(175, 16);
			this.TotScorelbl.TabIndex = 7;
			this.TotScorelbl.Text = "Total Score:";
			this.TotScorelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Winlbl1
			// 
			this.Winlbl1.BackColor = System.Drawing.Color.Transparent;
			this.Winlbl1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Winlbl1.ForeColor = System.Drawing.Color.Red;
			this.Winlbl1.Location = new System.Drawing.Point(136, 64);
			this.Winlbl1.Name = "Winlbl1";
			this.Winlbl1.Size = new System.Drawing.Size(112, 40);
			this.Winlbl1.TabIndex = 8;
			this.Winlbl1.Text = "Score!";
			this.Winlbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Winlbl1.Visible = false;
			// 
			// Winlbl2
			// 
			this.Winlbl2.BackColor = System.Drawing.Color.Transparent;
			this.Winlbl2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Winlbl2.ForeColor = System.Drawing.Color.Red;
			this.Winlbl2.Location = new System.Drawing.Point(64, 104);
			this.Winlbl2.Name = "Winlbl2";
			this.Winlbl2.Size = new System.Drawing.Size(256, 24);
			this.Winlbl2.TabIndex = 9;
			this.Winlbl2.Text = "Press Space to continue";
			this.Winlbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Winlbl2.Visible = false;
			// 
			// Startlbl
			// 
			this.Startlbl.BackColor = System.Drawing.Color.Transparent;
			this.Startlbl.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Startlbl.ForeColor = System.Drawing.Color.Red;
			this.Startlbl.Location = new System.Drawing.Point(240, 152);
			this.Startlbl.Name = "Startlbl";
			this.Startlbl.Size = new System.Drawing.Size(352, 64);
			this.Startlbl.TabIndex = 10;
			this.Startlbl.Text = "For Cleveland and the Galaxy! -Press F3 to Launch-";
			this.Startlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Startlbl.Visible = false;
			// 
			// Timer2
			// 
			this.Timer2.Interval = 500;
			// 
			// Introlbl
			// 
			this.Introlbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Introlbl.ForeColor = System.Drawing.Color.Yellow;
			this.Introlbl.Location = new System.Drawing.Point(224, 8);
			this.Introlbl.Name = "Introlbl";
			this.Introlbl.Size = new System.Drawing.Size(368, 328);
			this.Introlbl.TabIndex = 11;
			this.Introlbl.Visible = false;
			// 
			// Destlbl2
			// 
			this.Destlbl2.BackColor = System.Drawing.Color.Transparent;
			this.Destlbl2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Destlbl2.ForeColor = System.Drawing.Color.Red;
			this.Destlbl2.Location = new System.Drawing.Point(104, 96);
			this.Destlbl2.Name = "Destlbl2";
			this.Destlbl2.Size = new System.Drawing.Size(224, 32);
			this.Destlbl2.TabIndex = 12;
			this.Destlbl2.Text = "Southside feels your pain.";
			this.Destlbl2.Visible = false;
			// 
			// Destlbl1
			// 
			this.Destlbl1.BackColor = System.Drawing.Color.Transparent;
			this.Destlbl1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Destlbl1.ForeColor = System.Drawing.Color.Red;
			this.Destlbl1.Location = new System.Drawing.Point(120, 56);
			this.Destlbl1.Name = "Destlbl1";
			this.Destlbl1.Size = new System.Drawing.Size(176, 40);
			this.Destlbl1.TabIndex = 13;
			this.Destlbl1.Text = "Destroyed!";
			this.Destlbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Destlbl1.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(792, 541);
			this.Controls.Add(this.Destlbl1);
			this.Controls.Add(this.Destlbl2);
			this.Controls.Add(this.Introlbl);
			this.Controls.Add(this.Startlbl);
			this.Controls.Add(this.Winlbl2);
			this.Controls.Add(this.Winlbl1);
			this.Controls.Add(this.TotScorelbl);
			this.Controls.Add(this.CurScorelbl);
			this.Controls.Add(this.HighScorelbl);
			this.Controls.Add(this.hVelNumlbl);
			this.Controls.Add(this.vVelNumlbl);
			this.Controls.Add(this.vVellbl);
			this.Controls.Add(this.hVellbl);
			this.Controls.Add(this.PauseLbl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Case in Space: Lunar Lander ";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void ShowIntro(object sender, EventArgs e)
			//Plays the introduction to the game
		{
			if(iBin == 0)
				//Pause
			{
				HThere = CThere = EThere = false;
			}
			else if(iBin == 5)
				//Intro words
			{
				Introlbl.Text = "In an unnamed pub just off campus, three worthy gentlemen gather for a round of social intercourse.";
				Introlbl.Visible = true;
			}
			else if(iBin == 15)
				//Hundert speaks
			{
				Introlbl.Text = "The Race at Case was a spectacular success!!";
				HThere = true;
			}
			else if(iBin == 20)
				//Hundert speaks
			{
				Introlbl.Text = "We had so many celebrities in town,";
			}
			else if(iBin == 25)
				//Hundert speaks
			{
				Introlbl.Text = "and I even found us a commencement speaker!";
			}
			else if(iBin == 30)
				//Mathews pops up
			{
				AThere = true;
			}
			else if(iBin == 33)
				//Cheney speaks
			{
				HThere = AThere = false;
				CThere = true;
				Introlbl.Text = "Yes, and this debate has given me a chance to show off my oratory skills.";
			}
			else if(iBin == 40)
				//Cheney speaks
			{
				Introlbl.Text = "GRRRR!";
			}
			else if(iBin == 43)
				//Edwards speaks
			{
				CThere = false;
				EThere = true;
				Introlbl.Text = "And me a chance to show thousands of college kids my killer smile.";
			}
			else if(iBin == 50)
				//Edwards speaks
			{
				Introlbl.Text = "EEEEE!";
			}
			else if(iBin == 53)
				//Hundert speaks
			{
				EThere = false;
				HThere = true;
				Introlbl.Text = "Yes,  I think this was 4 million dollars well spent, ";
			}
			else if(iBin == 58)
				//Hundert speaks
			{
				Introlbl.Text = "even if this means we run out of housing for next year.";
			}
			else if(iBin == 63)
				//Shacks pop-up
			{
				SThere = true;
			}
			else if(iBin == 67)
				//Cheney
			{
				HThere = SThere = false;
				CThere = true;
				Introlbl.Text = "GRRRR!";
			}
			else if(iBin == 71)
				//Edwards
			{
				CThere = false;
				EThere = true;
				Introlbl.Text = "EEEEE!";
			}
			else if(iBin == 74)
				//Cheney
			{
				EThere = false;
				CThere = true;
				Introlbl.Text = "What are you going to do next?";
			}
			else if(iBin == 79)
				//Edwards
			{
				CThere = false;
				EThere = true;
				Introlbl.Text = "...now that the Race at Case has finished.";
			}
			else if(iBin == 84)
				//Hundert
			{
				EThere = false;
				HThere = true;
				Introlbl.Text = "Let me introduce: Case in Space!";
			}
			else if(iBin == 89)
				//Hundert
			{
				Introlbl.Text = "A program to make Case the most powerful learning environment in the Universe!!";
			}
			else if(iBin == 95)
				//Cheney
			{
				HThere = false;
				CThere = true;
				Introlbl.Text = "???";
			}
			else if(iBin == 98)
				//Edwards
			{
				CThere = false;
				EThere = true;
				Introlbl.Text = "???";
			}
			else if(iBin == 101)
				//Hundert
			{
				EThere = false;
				HThere = true;
				Introlbl.Text = "For Cleveland!";
			}
			else if(iBin == 104)
				//Hundert
			{
				Introlbl.Text = "For the GALAXY!!!";
			}
			else if(iBin == 108)
				//Cheney
			{
				HThere = false;
				CThere = true;
				Introlbl.Text = "GRRR!";
			}
			else if(iBin == 111)
				//Edwards
			{
				CThere = false;
				EThere = true;
				Introlbl.Text = "EEEEE!";
			}
			else if(iBin == 114)
			{
				this.Paint += new PaintEventHandler(Form1_Paint);
				this.Paint -= new PaintEventHandler(Intro_Paint);
				Introlbl.Visible = false;
				Cover.Visible = false;
				HighScorelbl.Visible = true;
				TotScorelbl.Visible = true;
				CurScorelbl.Visible = true;
				hVellbl.Visible = true;
				vVellbl.Visible = true;
				hVelNumlbl.Visible = true;
				vVelNumlbl.Visible = true;
				IntroRunning = false;
				Timer2.Stop();
				NewGame();
			}
			iBin++;
			Invalidate();
		}

		private void Intro_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			if(HThere)
			{
				g.DrawImage(HundertPic, 20, 20);
			}
			if(CThere)
			{
				g.DrawImage(CheneyPic, 20, 20);
			}
			if(EThere)
			{
				g.DrawImage(EdwardsPic, 20, 20);
			}
			if(AThere)
			{
				g.DrawImage(AndersPic, 400, 300);
			}
			if(SThere)
			{
				g.DrawImage(ShackPic, 400, 300);
			}
		}

		public void ChangePosition(object sender, EventArgs e)
			//The main Timer based method; moves and refreshes according to keys pressed and time
		{
			ChangeVelocity();
			yBin += Lander.vVelocity;
			xBin += Lander.hVelocity;

			while(yBin > FullBin)
			{
				yBin -= FullBin;
				Lander.Position.Y += 1;
			}
			while(yBin < -FullBin)
			{
				yBin += FullBin;
				Lander.Position.Y -= 1;
			}
			while(xBin > FullBin)
			{
				xBin -= FullBin;
				Lander.Position.X += 1;
			}
			while(xBin < -FullBin)
			{
				xBin += FullBin;
				Lander.Position.X -= 1;
			}

			//Determine if the lander is hitting the side
			if(Lander.Position.Left < 0)
				//It is rubbing against the left side
			{
				if(WallType == 0)
				{
					Lander.hVelocity = -Lander.hVelocity;
				}
				else if(WallType == 1)
				{
					Lander.hVelocity = 0;
				}
				Lander.Position.X = 0;
			}
			else if(Lander.Position.Right > this.Size.Width - 3)
				//It is rubbing up against the right side
			{
				if(WallType == 0)
				{
					Lander.hVelocity = -Lander.hVelocity;
				}
				else if(WallType == 1)
				{
					Lander.hVelocity = 0;
				}
				Lander.Position.X = this.Size.Width - Lander.Position.Width - 3;
			}

			//Determine if the lander crashed or landed
			if(Lander.Position.Y + Lander.Position.Height >= 600 - Surface.Land[Lander.Position.Left] || Lander.Position.Y + Lander.Position.Height >= 600 - Surface.Land[Lander.Position.Right])
				//It hit ground
			{
				if(Lander.Position.Left >= Surface.GoodSpotLeft && Lander.Position.Right <= Surface.GoodSpotRight && Math.Abs(Lander.hVelocity) < SafeH && Lander.vVelocity < SafeV)
				{
					WinGame();
				}
				else
				{
					LoseGame();
				}
			}

			//Refresh the picture of the lander every so often
			Cycle++;
			if(Cycle == RefreshPeriod)
			{
				hVelNumlbl.Text = Lander.hVelocity.ToString();
				vVelNumlbl.Text = Lander.vVelocity.ToString();
				Invalidate(OldBounds);
				Invalidate(Lander.Position);
				OldBounds = Lander.Position;
				Cycle = 0;
				ScoreCurr -= 1;
				CurScorelbl.Text = "Current Score: " + ScoreCurr;
			}
		}

		public void ChangeVelocity()
			//Changes the velocity if the arrows are pressed
		{
			Lander.vVelocity += GravityStrength - vThrusters * vThrusterStrength;
			Lander.hVelocity += hThrusters * hThrusterStrength;
		}

		public void NewGame()
			//Reset all the values, make a new terrain, and start over
		{
				xBin = 0;
				yBin = 0;
				Lander.vVelocity = 0;
				Lander.hVelocity = 0;
				Lander.Position.Y = 0;
				Lander.Position.X = this.Width / 2 - Lander.Position.Width / 2;
				Cycle = 0;
				Condition = 0;
				Surface = new Terrain();
				ScoreTot = 0;
				ScoreCurr = ScoreMax;
				TotScorelbl.Text = "Total Score: " + ScoreTot;
				CurScorelbl.Text = "Current Score: " + ScoreCurr;
				Winlbl1.Visible = false;
				Winlbl2.Visible = false;
				Startlbl.Visible = true;
				Timer1.Start();
				PauseGame();
				PauseLbl.Visible = false;
				Destlbl1.Visible = false;
				Destlbl2.Visible = false;
				Invalidate();
		}

		public void PauseGame()
			//Pause and unpause the game
		{
			if(Timer1.Enabled)
			{
				Timer1.Stop();
				PauseLbl.Visible = true;
				pgame.Text = "Unpause Game";
			}
			else if(!Timer1.Enabled && !IntroRunning)
			{
				Timer1.Start();
				PauseLbl.Visible = false;
				Startlbl.Visible = false;
				pgame.Text = "Pause Game";
			}
		}

		private void WinGame()
			//Good things happen
		{
			Timer1.Stop();
			Condition = 1;

			hVelNumlbl.Text = Lander.hVelocity.ToString();
			vVelNumlbl.Text = Lander.vVelocity.ToString();
			Winlbl2.Text = "Press " + FormKeys1.ContText + " to continue.";
			Winlbl1.Visible = true;
			Winlbl2.Visible = true;
			Invalidate();

			ScoreTot += ScoreCurr;
			TotScorelbl.Text = "Total Score: " + ScoreTot;
		}

		private void NewWinGame()
		{
			xBin = 0;
			yBin = 0;
			Lander.vVelocity = 0;
			Lander.hVelocity = 0;
			Lander.Position.Y = 0;
			Lander.Position.X = this.Width / 2 - Lander.Position.Width / 2;
			Cycle = 0;
			Condition = 0;
			ScoreCurr = ScoreMax;
			Surface = new Terrain();
			Winlbl1.Visible = false;
			Winlbl2.Visible = false;
			Timer1.Start();
			Invalidate();
		}

		private void LoseGame()
			//Bad things happen
		{
			Timer1.Stop();
			Condition = 2;
			HighScoresForm1.HighScore(ScoreTot);
			ScoreHigh = HighScoresForm1.Scores[9].score;
			HighScorelbl.Text = "High Score: " + ScoreHigh;
			TotScorelbl.Text = "Total Score: " + ScoreTot;
			Destlbl1.Visible = true;
			Destlbl2.Visible = true;
			Invalidate();
		}

		private void LoadState()
			//Load the options as they were at the when the program was closed
		{
			if(File.Exists("state.txt"))
			{
				StreamReader rdr = new StreamReader("state.txt");
				DiffOp = int.Parse(rdr.ReadLine());
				if(DiffOp == 0)
				{
					Easy.Checked = true;
					Medium.Checked = false;
					Hard.Checked = false;
					VeryHard.Checked = false;
					SafeH = 100;
					SafeV = 400;
				}
				else if(DiffOp == 1)
				{
					Easy.Checked = false;
					Medium.Checked = true;
					Hard.Checked = false;
					VeryHard.Checked = false;
					SafeH = 60;
					SafeV = 200;
				}
				else if(DiffOp == 2)
				{
					DiffOp = 2;
					Easy.Checked = false;
					Medium.Checked = false;
					Hard.Checked = true;
					VeryHard.Checked = false;
					SafeH = 30;
					SafeV = 100;
				}
				else if(DiffOp == 3)
				{
					Easy.Checked = false;
					Medium.Checked = false;
					Hard.Checked = false;
					VeryHard.Checked = true;
					SafeH = 10;
					SafeV = 50;
				}
				WallType = int.Parse(rdr.ReadLine());
				if(WallType == 0)
				{
					WallItem1.Checked = true;
					WallItem2.Checked = false;
					WallItem3.Checked = false;
				}
				else if(WallType == 1)
				{
					WallItem1.Checked = false;
					WallItem2.Checked = true;
					WallItem3.Checked = false;
				}
				else if(WallType == 2)
				{
					WallItem1.Checked = false;
					WallItem2.Checked = false;
					WallItem3.Checked = true;
				}
				SkipIntro = bool.Parse(rdr.ReadLine());
				if(SkipIntro)
				{
					SkipItem.Checked = true;
				}
				for(int i = 0; i < 10; i++)
				{
					HighScoresForm1.Scores[i].name = rdr.ReadLine();
					HighScoresForm1.Scores[i].score = int.Parse(rdr.ReadLine());
				}
				ScoreHigh = HighScoresForm1.Scores[9].score;	
				HighScorelbl.Text = "High Score: " + ScoreHigh.ToString();
				rdr.Close();
			}
		}
		
		private void Form1_Closing(object sender, CancelEventArgs e)
			//Save the options
		{
			StreamWriter wtr = new StreamWriter("state.txt");
			wtr.WriteLine(DiffOp);
			wtr.WriteLine(WallType);
			wtr.WriteLine(SkipIntro);
			for(int i = 0; i < 10; i++)
			{
				wtr.WriteLine(HighScoresForm1.Scores[i].name);
				wtr.WriteLine(HighScoresForm1.Scores[i].score);
			}
			wtr.Close();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
			//Inherited event that maintains coherency of the images
		{
			Graphics g = e.Graphics;
			if(ShowStars)
			{
				for(int i=0; i<vertices1.Length; i++)
				{
					g.DrawPolygon(Pens.Yellow,vertices1[i]);
					g.FillPolygon(Brushes.Yellow,vertices1[i]);
				}
				for(int i=0; i<vertices2.Length; i++)
				{
					g.DrawPolygon(Pens.Yellow,vertices2[i]);
					g.FillPolygon(Brushes.Yellow,vertices2[i]);
				}
			}

			if(Condition == 1)
			{
				g.DrawImage(CaseFlag, Lander.Position.Right, Lander.Position.Bottom - CaseFlag.Height);
			}

			Surface.Draw(g);
			Lander.Draw(g, hThrusters, vThrusters, Condition);
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
			//Turns the thrusters on
		{
			if(e.KeyCode == FormKeys1.AccelUp)
			{
				vThrusters = 1;
			}
			else if(e.KeyCode == FormKeys1.AccelLeft)
			{
				hThrusters = -1;
			}
			else if(e.KeyCode == FormKeys1.AccelRight)
			{
				hThrusters = 1;
			}
			if(Condition == 1 && e.KeyCode == FormKeys1.Continue)
			{
				NewWinGame();
			}
		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
			//Turns the thrusters off
		{
			if(e.KeyCode == FormKeys1.AccelUp)
			{
				vThrusters = 0;
			}
			else if(e.KeyCode == FormKeys1.AccelLeft && hThrusters == -1)
			{
				hThrusters = 0;
			}
			else if(e.KeyCode == FormKeys1.AccelRight && hThrusters == 1)
			{
				hThrusters = 0;
			}
		}

		private void ngame_Click(object sender, System.EventArgs e)
		{
			NewGame();
		}

		private void pgame_Click(object sender, System.EventArgs e)
		{
			if(Condition != 1 && Condition != 2)
			{
				PauseGame();
			}
		}

		private void hscores_Click(object sender, System.EventArgs e)
		{
			HighScoresForm1.Show();
		}

		private void Exit_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void Easy_Click(object sender, System.EventArgs e)
		{
			DiffOp = 0;
			Easy.Checked = true;
			Medium.Checked = false;
			Hard.Checked = false;
			VeryHard.Checked = false;
			SafeH = 100;
			SafeV = 400;
		}

		private void Medium_Click(object sender, System.EventArgs e)
		{
			DiffOp = 1;
			Easy.Checked = false;
			Medium.Checked = true;
			Hard.Checked = false;
			VeryHard.Checked = false;
			SafeH = 60;
			SafeV = 200;
		}

		private void Hard_Click(object sender, System.EventArgs e)
		{
			DiffOp = 2;
			Easy.Checked = false;
			Medium.Checked = false;
			Hard.Checked = true;
			VeryHard.Checked = false;
			SafeH = 30;
			SafeV = 100;
		}

		private void VeryHard_Click(object sender, System.EventArgs e)
		{
			DiffOp = 3;
			Easy.Checked = false;
			Medium.Checked = false;
			Hard.Checked = false;
			VeryHard.Checked = true;
			SafeH = 10;
			SafeV = 50;
		}

		private void PicItem1_Click(object sender, System.EventArgs e)
		{
			ShowStars = true;
			PicItem1.Checked = true;
			PicItem2.Checked = false;
			PicItem3.Checked = false;
			this.BackgroundImage = null;
		}

		private void PicItem2_Click(object sender, System.EventArgs e)
		{
			ShowStars = false;
			PicItem1.Checked = false;
			PicItem2.Checked = true;
			PicItem3.Checked = false;
			this.BackgroundImage = new Bitmap("stars.bmp");
		}

		private void PicItem3_Click(object sender, System.EventArgs e)
		{
			ShowStars = false;
			PicItem1.Checked = false;
			PicItem2.Checked = false;
			PicItem3.Checked = true;
			this.BackgroundImage = new Bitmap("earthatnight.bmp");
		}

		private void CtrlItem_Click(object sender, System.EventArgs e)
		{
			FormKeys1.Show();
		}

		private void HelpPage_Click(object sender, System.EventArgs e)
		{
			FormHelp1.Show();
		}

		private void About_Click(object sender, System.EventArgs e)
		{
			FormAbout1.Show();
		}

		private void SkipItem_Click(object sender, System.EventArgs e)
		{
			if(!SkipItem.Checked)
			{
				SkipIntro = true;
				SkipItem.Checked = true;
			}
			else if(SkipItem.Checked)
			{
				SkipIntro = false;
				SkipItem.Checked = false;
			}
			if(IntroRunning == true)
			{
				iBin = 114;
			}
		}

		private void WallItem1_Click(object sender, System.EventArgs e)
		{
			WallType = 0;
			WallItem1.Checked = true;
			WallItem2.Checked = false;
			WallItem3.Checked = false;
		}

		private void WallItem2_Click(object sender, System.EventArgs e)
		{
			WallType = 1;
			WallItem1.Checked = false;
			WallItem2.Checked = true;
			WallItem3.Checked = false;
		}

		private void WallItem3_Click(object sender, System.EventArgs e)
		{
			WallType = 2;
			WallItem1.Checked = false;
			WallItem2.Checked = false;
			WallItem3.Checked = true;
		}

		private void FormKeys1_VisibleChanged(object sender, EventArgs e)
		{
			Winlbl2.Text = "Press " + FormKeys1.ContText + " to continue.";
		}
	}
}
