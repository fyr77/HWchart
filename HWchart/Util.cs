using System;
using System.IO;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;

namespace HWchart
{
	/// <summary>
	/// Class of Utilities used by the application
	/// </summary>
	public static class Util
	{
		/// <summary>
		/// Compresses a zip file
		/// </summary>
		/// <param name="path"></param>
		/// <param name="resultPath"></param>
		public static void Compress(string path, string resultPath) 
		{            
			FastZip fastZip = new FastZip();

            bool recurse = true;  // Include all files by recursing through the directory structure
            string filter = null; // Dont filter any files at all
			fastZip.CreateZip(resultPath, path, recurse, filter);
		}
		/// <summary>
		/// Extracts a zip file
		/// </summary>
		/// <param name="path"></param>
		/// <param name="destination"></param>
		public static void Extract(string path, string destination) 
		{
			FastZip fastZip = new FastZip();

            string filter = null; // Dont filter any files at all
			fastZip.ExtractZip(path, destination, filter);
		}
		/// <summary>
		/// Clears the application variables. Same as restarting.
		/// </summary>
		public static void Clear() 
		{
			for (int i = 0; i < Ref.contents.Length; i++) {
				Ref.contents[i] = "";
			}
			for (int i = 0; i < Ref.pics.Length; i++) {
				Ref.pics[i] = "";
			}
			Ref.img = "";
			Ref.locationShown = 0;
			Ref.origNumber = 0;
			Ref.picBox = null;
			Ref.txt = "";
		}
		/// <summary>
		/// Saves changes to a renamed zip file
		/// </summary>
		public static void Save()
		{
			SaveFileDialog svd = new SaveFileDialog();
			svd.Filter = "HWChart save file|*.hws";
			svd.Title = "Save hardware chart";
			svd.ShowDialog();
			
			if (Directory.Exists(Ref.tempPath)) 
			{
				Directory.Delete(Ref.tempPath, true);
				Directory.CreateDirectory(Ref.tempPath);
			}
			else
				Directory.CreateDirectory(Ref.tempPath);
			
			if (svd.FileName != "") {
				
				if (File.Exists(svd.FileName)) {
					File.Delete(svd.FileName);
				}
				
				File.WriteAllLines(Ref.tempContentPath, Ref.contents);
				File.WriteAllLines(Ref.tempPicsPath, Ref.pics);
				File.WriteAllLines(Ref.tempNamesPath, Ref.names);
				
				Compress(Ref.tempPath, svd.FileName);
			}
			
			Ref.isModified = false;
		}
	}
}
