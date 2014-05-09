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
 * Part 8 of 8
*/ 
using System;
using System.Drawing;

namespace LunarLander
{
	/// <summary>
	/// Summary description for Terrain.
	/// </summary>
	public class Terrain
	{
		public int[] Land;
		public int[] LandAppear;
		public Point[] FillGround;
		public int GoodSpotLeft;
		public int GoodSpotRight;

		public Terrain()
			//Constructor of a random piece of terrain
		{
			Random rdm = new Random();
			Land = new int[800];
			int temp = rdm.Next(100, 300);
			for(int i = 0; i < 10; i++)
				//for each segment of land
			{
				int next = rdm.Next(-80, 80);
				for(int j = 0; j < 80; j++)
					//for each pixel of land
				{
					if(temp + next >= 500) next = -next;
					if(temp + next <= 100) next = -next;
					Land[i * 80 + j] = temp + next * j / 80;
				}
				temp += next;
			}

			//Create the landing zone
			GoodSpotLeft = rdm.Next(0, 9) * 80;
			GoodSpotRight = GoodSpotLeft + 80;
			int a = (Land[GoodSpotLeft] + Land[GoodSpotRight]) / 2;
			for(int i = 0; i < 80; i++)
			{
				if(GoodSpotLeft != 0)
				{
					Land[GoodSpotLeft - 80 + i] = Land[GoodSpotLeft - 80] + (a - Land[GoodSpotLeft - 80]) * i / 80;
				}
				if(GoodSpotRight != 800)
				{
					Land[GoodSpotRight + 79 - i] = Land[GoodSpotRight + 79] + (a - Land[GoodSpotRight + 79]) * i / 80;
				}
				Land[i + GoodSpotLeft] = a;
			}
			LandAppear = new int[800];
			for(int i = 0; i < 800; i++)
				//Make the ground look choppy
			{
				LandAppear[i] = Land[i] + rdm.Next(-5, 5);
			}
			for(int i = 0; i < 80; i++)
				//Flatten out the landing zone
			{
				LandAppear[i + GoodSpotLeft] = a;
			}

			FillGround = new Point[802];
			for(int i = 0; i < 800; i++)
				//Make the "polygon" that represents the ground
			{
				FillGround[i] = new Point(i, 600 - LandAppear[i]);
			}
			FillGround[800] = new Point(800, 600);
			FillGround[801] = new Point(0, 600);
		}

		public void Draw(Graphics g)
		{
			g.FillPolygon(new SolidBrush(Color.Gray), FillGround);
		}
	}
}
