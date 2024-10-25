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
			textBoxP = new TextBox();
			textBoxI = new TextBox();
			textBoxD = new TextBox();
			labelP = new Label();
			labelI = new Label();
			labelD = new Label();
			drawButton = new Button();
			SuspendLayout();
			// 
			// textBoxP
			// 
			textBoxP.Location = new Point(872, 12);
			textBoxP.Name = "textBoxP";
			textBoxP.Size = new Size(100, 23);
			textBoxP.TabIndex = 1;
			// 
			// textBoxI
			// 
			textBoxI.Location = new Point(872, 41);
			textBoxI.Name = "textBoxI";
			textBoxI.Size = new Size(100, 23);
			textBoxI.TabIndex = 2;
			// 
			// textBoxD
			// 
			textBoxD.Location = new Point(872, 70);
			textBoxD.Name = "textBoxD";
			textBoxD.Size = new Size(100, 23);
			textBoxD.TabIndex = 3;
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
			// drawButton
			// 
			drawButton.Location = new Point(872, 397);
			drawButton.Name = "drawButton";
			drawButton.Size = new Size(100, 52);
			drawButton.TabIndex = 7;
			drawButton.Text = "Draw";
			drawButton.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(984, 461);
			Controls.Add(drawButton);
			Controls.Add(labelD);
			Controls.Add(labelI);
			Controls.Add(labelP);
			Controls.Add(textBoxD);
			Controls.Add(textBoxI);
			Controls.Add(textBoxP);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TextBox textBoxP;
		private TextBox textBoxI;
		private TextBox textBoxD;
		private Label labelP;
		private Label labelI;
		private Label labelD;
		private Button drawButton;
	}
}
