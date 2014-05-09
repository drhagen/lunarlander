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
 * Part 7 of 8
*/ 
using System;

namespace LunarLander
{
	/// <summary>
	/// Summary description for Scores.
	/// </summary>

	public class Score
	{
		public string name;
		public int score;

		public Score()
		{
			name = null;
			score = 0;
		}

		public Score(string a, int b)
		{
			name = a;
			score = b;
		}
	}
}
