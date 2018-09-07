using System;
using System.Text;
using System.Windows.Forms;

namespace HWchart
{
	/// <summary>
	/// Window for editing and viewing details
	/// </summary>
	public partial class DetailsForm : Form
	{
		public DetailsForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			string x = Ref.contents[Ref.locationShown];
			StringBuilder builder = new StringBuilder(x);
			builder.Replace("//newline", Environment.NewLine);
			string y = builder.ToString();
			textBox1.Text = y;
			textBoxName.Text = Ref.names[Ref.locationShown];
		}
		/// <summary>
		/// Saves the contents of text boxes to string array.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void ButtonSaveClick(object sender, EventArgs e)
		{
			string x = textBox1.Text;
			StringBuilder builder = new StringBuilder(x);
			builder.Replace(Environment.NewLine, "//newline");
			string y = builder.ToString();
			Ref.contents[Ref.locationShown] = y;
			
			Ref.names[Ref.locationShown] = textBoxName.Text;
			
			labelSaved.Text = "Last save was at " + DateTime.Now.ToString("hh:mm:ss") + ".";
		}
		/// <summary>
		/// Closes this window.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void ButtonCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
