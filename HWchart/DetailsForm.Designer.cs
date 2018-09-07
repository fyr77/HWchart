/*
 * Created by SharpDevelop.
 * User: H50QSUA
 * Date: 23.08.2018
 * Time: 10:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HWchart
{
	partial class DetailsForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Label labelSaved;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBoxName;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonClose = new System.Windows.Forms.Button();
			this.labelSaved = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(3, 16);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(539, 266);
			this.textBox1.TabIndex = 0;
			// 
			// buttonSave
			// 
			this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSave.Location = new System.Drawing.Point(465, 330);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 1;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.Location = new System.Drawing.Point(380, 330);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(75, 23);
			this.buttonClose.TabIndex = 2;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.ButtonCloseClick);
			// 
			// labelSaved
			// 
			this.labelSaved.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.labelSaved.Location = new System.Drawing.Point(5, 330);
			this.labelSaved.Name = "labelSaved";
			this.labelSaved.Size = new System.Drawing.Size(365, 23);
			this.labelSaved.TabIndex = 3;
			this.labelSaved.Text = "not saved";
			this.labelSaved.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Location = new System.Drawing.Point(0, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(545, 285);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Details";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBoxName);
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(545, 40);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Name";
			// 
			// textBoxName
			// 
			this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxName.Location = new System.Drawing.Point(3, 16);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(539, 20);
			this.textBoxName.TabIndex = 0;
			// 
			// DetailsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(545, 357);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.labelSaved);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.buttonSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "DetailsForm";
			this.Text = "Details";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
