namespace PIDCofApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			labelP = new Label();
			labelI = new Label();
			labelD = new Label();
			SuspendLayout();
			// 
			// labelP
			// 
			labelP.AutoSize = true;
			labelP.Location = new Point(850, 15);
			labelP.Name = "labelP";
			labelP.Size = new Size(20, 15);
			labelP.TabIndex = 4;
			labelP.Text = "P :";
			// 
			// labelI
			// 
			labelI.AutoSize = true;
			labelI.Location = new Point(850, 44);
			labelI.Name = "labelI";
			labelI.Size = new Size(16, 15);
			labelI.TabIndex = 5;
			labelI.Text = "I :";
			// 
			// labelD
			// 
			labelD.AutoSize = true;
			labelD.Location = new Point(850, 73);
			labelD.Name = "labelD";
			labelD.Size = new Size(21, 15);
			labelD.TabIndex = 6;
			labelD.Text = "D :";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(984, 461);
			Controls.Add(labelD);
			Controls.Add(labelI);
			Controls.Add(labelP);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label labelP;
		private Label labelI;
		private Label labelD;
	}
}
