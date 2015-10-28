﻿/*
 * Created by SharpDevelop.
 * User: Latsuj
 * Date: 26/10/2015
 * Time: 20:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
namespace Lecteur
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{				
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			MainForm mf = new MainForm();
			Player player = new Player(mf);
			player.createMusicsList();
			Application.Run(mf);
		}
		
	}
}
