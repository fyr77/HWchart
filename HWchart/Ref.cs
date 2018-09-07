using System;
using System.Resources;
using System.Reflection;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Management;

namespace HWchart
{
	/// <summary>
	/// Class for loading resources
	/// </summary>
	public static class Ref
	{
		public static int locationShown;
		public static string[] contents = new string[476];
		public static Bitmap getRes(string name, int number) 
		{
			pics[number] = name;
			
			ResourceManager resm = new ResourceManager("HWchart.Resources", Assembly.GetExecutingAssembly());
			Bitmap bm = (Bitmap)resm.GetObject(name);
			return bm;
		}
		public static Bitmap getRes(string name) 
		{
			ResourceManager resm = new ResourceManager("HWchart.Resources", Assembly.GetExecutingAssembly());
			Bitmap bm = (Bitmap)resm.GetObject(name);
			return bm;
		}
		public static string tempPath;
		public static string tempContentPath;
		public static string tempPicsPath;
		public static string tempNamesPath;

		public static void generateTemp() {
			if (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
			{
				tempPath = Environment.GetEnvironmentVariable("HOME");

				if (tempPath.EndsWith("/", StringComparison.Ordinal))
					tempPath = tempPath + ".hws/";
				else
					tempPath = tempPath +"/.hws/";
			}
			else
				tempPath = Path.GetTempPath() + "hws\\";

			tempContentPath = tempPath + "hwctext.txt";
			tempPicsPath = tempPath + "hwcpics.txt";
			tempNamesPath = tempPath + "hwcnames.txt";
		}

		public static string[] pics = new string[476];

		public static string img;
		public static string txt;
		public static int origNumber;
		public static PictureBox picBox = null;
		public static string[] names = new string[476];
		public static bool isModified = false;
		
		/*
		 * 0 = Cursor
		 * 1 = Server
		 * 2 = Database
		 * 3 = PC
		 * 4 = Cross Connect
		 * 5 = Horizontal Connect
		 * 6 = Vertical Connect
		 * 7 = Reverse L Connect
		 * 8 = L Connect
		 * 9 = Left-to-Down Connect
		 * 10 = Right-to-Down Connect
		 * 11 = Cross Seperator
		 * 12 = Horizontal Seperator
		 * 13 = Vertical Seperator
		 * 14 = Reverse L Seperator
		 * 15 = L Seperator
		 * 16 = Left-to-Down Seperator
		 * 17 = Right-to-Down Seperator
		 * 18 = Eraser
		 * 19 = Move
		 * 20 = Info
		 * 21 = Location
		 */
		public static int selectedTool = 0;
	}
}
