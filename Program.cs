/*
 *
 * Developed by Adam Rakaska
 *  http://csharpcodewhisperer.blogspot.com
 *    http://arakaska.wix.com/intelligentsoftware
 *
 *
 * Made using SharpDevelop
 *
 * 
 */
using System;
using System.Threading;
using System.Windows.Forms;


namespace AranockAssist
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
			Application.ThreadException += new ThreadExceptionEventHandler(MainForm.MyExceptionHandler);
			Application.Run(new MainForm());
		}		
	}
}
