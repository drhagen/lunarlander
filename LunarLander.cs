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
 * Part 6 of 8
*/ 
using System;
using System.Drawing;

namespace LunarLander
{
	/// <summary>
	/// Summary description for LunarLander.
	/// </summary>
	public class LunarLander
	{
		public Bitmap None;
		public Bitmap Right;
		public Bitmap Left;
		public Bitmap Bot;
		public Bitmap RightBot;
		public Bitmap LeftBot;
		public Bitmap Wreck;
		public Bitmap Flag;
		public Rectangle Position;
		public int hVelocity;
		public int vVelocity;

		public LunarLander()
		{
			None = new Bitmap("landernone.bmp");
			Right = new Bitmap("landerright.bmp");
			Left = new Bitmap("landerleft.bmp");
			Bot = new Bitmap("landerbot.bmp");
			RightBot = new Bitmap("landerrightbot.bmp");
			LeftBot = new Bitmap("landerleftbot.bmp");
			Wreck = new Bitmap("landerwreck.bmp");
			Flag = new Bitmap("landerflag.bmp");
			Position.X = 0;
			Position.Y = 0;
			Position.Width = None.Width;
			Position.Height = None.Height;
			hVelocity = 0;
			vVelocity = 0;
		}

		public void Draw(Graphics g, int h, int v, int s)
		{
			if(s == 0 && h == 0 && v == 0)
			{
				g.DrawImage(None, Position);
			}
			else if(s == 0 && h == -1 && v == 0)
			{
				g.DrawImage(Right, Position);
			}
			else if(s == 0 && h == 1 && v == 0)
			{
				g.DrawImage(Left, Position);
			}
			else if(s == 0 && h == 0 && v == 1)
			{
				g.DrawImage(Bot, Position);
			}
			else if(s == 0 && h == -1 && v == 1)
			{
				g.DrawImage(RightBot, Position);
			}
			else if(s == 0 && h == 1 && v == 1)
			{
				g.DrawImage(LeftBot, Position);
			}
			else if(s == 1)
			{
				g.DrawImage(None, Position);
			}
			else if(s == 2)
			{
				g.DrawImage(Wreck, Position);
			}
		}
	}
}
