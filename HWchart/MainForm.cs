using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace HWchart
{
	/// <summary>
	/// An application for making charts of network/server configurations
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm(string[] args)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			if (args.Length != 0) {
				DirectLoad(args);
			}
			Ref.generateTemp();
		}
		void ButtonSelectClick(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
			Ref.selectedTool = 0;
		}
		void ButtonServerClick(object sender, EventArgs e)
		{
			Ref.selectedTool = 1;
			this.Cursor = Cursors.Cross;
		}
		void ButtonDBClick(object sender, EventArgs e)
		{
			Ref.selectedTool = 2;
			this.Cursor = Cursors.Cross;
		}
		void ButtonPCClick(object sender, EventArgs e)
		{
			Ref.selectedTool = 3;
			this.Cursor = Cursors.Cross;
		}
		void ButtonMoveClick(object sender, EventArgs e)
		{
			Ref.selectedTool = 19;
			this.Cursor = Cursors.Hand;
		}
		void ButtonInfoClick(object sender, EventArgs e)
		{
			Ref.selectedTool = 20;
			this.Cursor = Cursors.Cross;
		}
		void ButtonLocClick(object sender, EventArgs e)
		{
			Ref.selectedTool = 21;
			this.Cursor = Cursors.Cross;
		}
		/// <summary>
		/// Checks the name of the button and sets the variable accordingly.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void ButtonConnClick(object sender, EventArgs e)
		{
			string func = ((ToolStripButton)sender).Text;
			this.Cursor = Cursors.Cross;
			
			switch (func) {
				case "cross":
					Ref.selectedTool = 4;
					break;
				case "horizontal":
					Ref.selectedTool = 5;
					break;
				case "vertical":
					Ref.selectedTool = 6;
					break;
				case "up-left":
					Ref.selectedTool = 7;
					break;
				case "up-right":
					Ref.selectedTool = 8;
					break;
				case "down-left":
					Ref.selectedTool = 9;
					break;
				case "down-right":
					Ref.selectedTool = 10;
					break;
			}
		}
		/// <summary>
		/// Checks the name of the button and sets the variable accordingly.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void ButtonSepClick(object sender, EventArgs e)
		{
			string func = ((ToolStripButton)sender).Text;
			this.Cursor = Cursors.Cross;
			
			switch (func) {
				case "cross":
					Ref.selectedTool = 11;
					break;
				case "horizontal":
					Ref.selectedTool = 12;
					break;
				case "vertical":
					Ref.selectedTool = 13;
					break;
				case "up-left":
					Ref.selectedTool = 14;
					break;
				case "up-right":
					Ref.selectedTool = 15;
					break;
				case "down-left":
					Ref.selectedTool = 16;
					break;
				case "down-right":
					Ref.selectedTool = 17;
					break;
			}
		}
		/// <summary>
		/// Sets the contents of the picture boxes on click.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void PictureBoxClick(object sender, EventArgs e)
		{
			Ref.isModified = true;
			int number = Int32.Parse(Regex.Match(((PictureBox)sender).Name, @"\d+").Value) - 1;
			switch (Ref.selectedTool) {
				case 0:
					ToolDetails(number, ((PictureBox)sender));
					break;
				case 1:
					((PictureBox)sender).Image = Ref.getRes("server", number);
					break;
				case 2:
					((PictureBox)sender).Image = Ref.getRes("db", number);
					break;
				case 3:
					((PictureBox)sender).Image = Ref.getRes("pc", number);
					break;
				case 4:
					((PictureBox)sender).Image = Ref.getRes("ConnCross", number);
					break;
				case 5:
					((PictureBox)sender).Image = Ref.getRes("ConnHor", number);
					break;
				case 6:
					((PictureBox)sender).Image = Ref.getRes("ConnVert", number);
					break;
				case 7:
					((PictureBox)sender).Image = Ref.getRes("ConnU_L", number);
					break;
				case 8:
					((PictureBox)sender).Image = Ref.getRes("ConnU_R", number);
					break;
				case 9:
					((PictureBox)sender).Image = Ref.getRes("ConnD_L", number);
					break;
				case 10:
					((PictureBox)sender).Image = Ref.getRes("ConnD_R", number);
					break;
				case 11:
					((PictureBox)sender).Image = Ref.getRes("SepCross", number);
					break;
				case 12:
					((PictureBox)sender).Image = Ref.getRes("SepHor", number);
					break;
				case 13:
					((PictureBox)sender).Image = Ref.getRes("SepVert", number);
					break;
				case 14:
					((PictureBox)sender).Image = Ref.getRes("SepU_L", number);
					break;
				case 15:
					((PictureBox)sender).Image = Ref.getRes("SepU_R", number);
					break;
				case 16:
					((PictureBox)sender).Image = Ref.getRes("SepD_L", number);
					break;
				case 17:
					((PictureBox)sender).Image = Ref.getRes("SepD_R", number);
					break;
				case 18:
					((PictureBox)sender).Image = null;
					Ref.contents[number] = "";
					Ref.pics[number] = "";
					Ref.names[number] = "";
					break;
				case 19:
					ToolMove(number, ((PictureBox)sender));
					break;
				case 20:
					((PictureBox)sender).Image = Ref.getRes("info", number);
					break;
				case 21:
					((PictureBox)sender).Image = Ref.getRes("location", number);
					break;
			}
		}
		/// <summary>
		/// For moving icons to other picture boxes
		/// </summary>
		/// <param name="number"></param>
		/// <param name="sender"></param>
		void ToolMove (int number, PictureBox sender) 
		{
			if (this.Cursor == Cursors.UpArrow) 
			{
				sender.Image = Ref.getRes(Ref.img);
				Ref.contents[number] = Ref.txt;
				Ref.pics[number] = Ref.img;
				
				Ref.picBox.Image = null;
				Ref.contents[Ref.origNumber] = "";
				Ref.pics[Ref.origNumber] = "";
				
				this.Cursor = Cursors.Hand;
			}
			else if (sender.Image != null)
			{
				this.Cursor = Cursors.UpArrow;
				Ref.img = Ref.pics[number];
				Ref.txt = Ref.contents[number];
				Ref.origNumber = number;
				Ref.picBox = sender;
			}
		}
		/// <summary>
		/// For showing details of a specific icon
		/// </summary>
		/// <param name="number"></param>
		/// <param name="sender"></param>
		void ToolDetails (int number, PictureBox sender) 
		{
			if (sender.Image != null) {
				Ref.locationShown = number;
				
				DetailsForm df = new DetailsForm();
				df.ShowDialog();
			}
		}
		/// <summary>
		/// Triggers save
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void ButtonSaveClick(object sender, EventArgs e)
		{
			Util.Save();
		}
		/// <summary>
		/// For deleting icons from picture boxes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void ButtonDelClick(object sender, EventArgs e)
		{
			this.Cursor = Cursors.No;
			Ref.selectedTool = 18;
		}
		/// <summary>
		/// Opens a previously saved file
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void ButtonOpenClick(object sender, EventArgs e)
		{
			string path;
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "HWChart save file|*.hws";
			dlg.Title = "Open hardware chart";
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				path = dlg.FileName;
				if (Directory.Exists(Ref.tempPath))
				{
					Directory.Delete(Ref.tempPath, true);
					Directory.CreateDirectory(Ref.tempPath);
				}
				else
					Directory.CreateDirectory(Ref.tempPath);
				
				Util.Extract(path, Ref.tempPath);
				
				Ref.pics = File.ReadAllLines(Ref.tempPicsPath);
				Ref.contents = File.ReadAllLines(Ref.tempContentPath);
				Ref.names = File.ReadAllLines(Ref.tempNamesPath);
				
				foreach (Control x in tableLayoutPanel1.Controls)
				{
					if (x is PictureBox) {
						int number = Int32.Parse(Regex.Match(((PictureBox)x).Name, @"\d+").Value) - 1;
						((PictureBox)x).Image = Ref.getRes(Ref.pics[number]);
					}
				}
			}
		}
		/// <summary>
		/// Clears the application. Same as restarting it.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void ButtonNewClick(object sender, EventArgs e)
		{
			if (Ref.isModified) {
				DialogResult dlgr = MessageBox.Show("A new file will be created. Do you want to save?", "Save changes?", MessageBoxButtons.YesNoCancel);
				if (dlgr == DialogResult.Yes) {
					Util.Save();
					Util.Clear();
				    foreach (Control x in tableLayoutPanel1.Controls)
					{
						if (x is PictureBox) {
							((PictureBox)x).Image = null;
						}
					}
				}
				else if (dlgr == DialogResult.No) {
					Util.Clear();
				    foreach (Control x in tableLayoutPanel1.Controls)
					{
						if (x is PictureBox) {
							((PictureBox)x).Image = null;
						}
					}
				}
			}
			else {
				Util.Clear();
                foreach (Control x in tableLayoutPanel1.Controls)
                {
                    if (x is PictureBox)
                    {
                        ((PictureBox)x).Image = null;
                    }
                }
			}
		}
		/// <summary>
		/// Asks for save before closing
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if (Ref.isModified == true) {
				DialogResult dialogResult = MessageBox.Show("Do you want to save your changes?", "Save?", MessageBoxButtons.YesNoCancel);
				if(dialogResult == DialogResult.Yes)
				{
					Util.Save();
					Directory.Delete(Ref.tempPath, true);
				}
				else if (dialogResult == DialogResult.No)
					Directory.Delete(Ref.tempPath, true);
				else if (dialogResult == DialogResult.Cancel)
					e.Cancel = true;
			}
		}
		/// <summary>
		/// Loads file if opened with application
		/// </summary>
		/// <param name="files"></param>
		void DirectLoad (string[] files)
		{
			if (files.Length > 1) {
				MessageBox.Show("Can only open one file at a time. First selected file will be loaded.");
			}
			string path = files[0];
			var regex = @".+\.hws$";
			var match = Regex.Match(path, regex, RegexOptions.IgnoreCase);
			if (match.Success) {
				if (Directory.Exists(Ref.tempPath))
				{
					Directory.Delete(Ref.tempPath, true);
					Directory.CreateDirectory(Ref.tempPath);
				}
				else
					Directory.CreateDirectory(Ref.tempPath);
				
				Util.Extract(path, Ref.tempPath);
				
				Ref.pics = File.ReadAllLines(Ref.tempPicsPath);
				Ref.contents = File.ReadAllLines(Ref.tempContentPath);
				Ref.names = File.ReadAllLines(Ref.tempNamesPath);
				
				foreach (Control x in tableLayoutPanel1.Controls)
				{
					if (x is PictureBox) {
						int number = Int32.Parse(Regex.Match(((PictureBox)x).Name, @"\d+").Value) - 1;
						((PictureBox)x).Image = Ref.getRes(Ref.pics[number]);
					}
				}
			}
			else if (File.Exists(path)) {
				MessageBox.Show("Cannot load file! Application only supports hws files.","Error loading file");
			}
			else
			{
				MessageBox.Show("File not found.","Error loading file");
			}
		}
		/// <summary>
		/// Shows tooltips
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void PictureBoxMouseHover(object sender, EventArgs e)
		{
			int number = Int32.Parse(Regex.Match(((PictureBox)sender).Name, @"\d+").Value) - 1;
			string curr = Ref.names[number];
			if (curr != "")
			    	tt.SetToolTip(((PictureBox)sender), Ref.names[number]);
		}
		void ButtonHelpClick(object sender, EventArgs e)
		{
			MessageBox.Show("---HWchart 1.4 by Jakob Senkl---\n\nUse the buttons in the toolbar to place different icons.\nThese can be named by clicking on them using the \"Select\" tool.", "Help");
		}
	}
}
