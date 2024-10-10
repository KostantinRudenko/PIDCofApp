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
			button1 = new Button();
			textBoxA = new TextBox();
			textBoxB = new TextBox();
			textBoxC = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			mainPanel = new Panel();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(397, 224);
			button1.Name = "button1";
			button1.Size = new Size(75, 25);
			button1.TabIndex = 0;
			button1.Text = "Paint";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBoxA
			// 
			textBoxA.Location = new Point(370, 10);
			textBoxA.Name = "textBoxA";
			textBoxA.Size = new Size(100, 23);
			textBoxA.TabIndex = 1;
			// 
			// textBoxB
			// 
			textBoxB.Location = new Point(370, 40);
			textBoxB.Name = "textBoxB";
			textBoxB.Size = new Size(100, 23);
			textBoxB.TabIndex = 2;
			// 
			// textBoxC
			// 
			textBoxC.Location = new Point(370, 70);
			textBoxC.Name = "textBoxC";
			textBoxC.Size = new Size(100, 23);
			textBoxC.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(350, 10);
			label1.Name = "label1";
			label1.Size = new Size(16, 15);
			label1.TabIndex = 4;
			label1.Text = "a:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(350, 40);
			label2.Name = "label2";
			label2.Size = new Size(17, 15);
			label2.TabIndex = 5;
			label2.Text = "b:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(350, 70);
			label3.Name = "label3";
			label3.Size = new Size(16, 15);
			label3.TabIndex = 6;
			label3.Text = "c:";
			// 
			// mainPanel
			// 
			mainPanel.Location = new Point(12, 12);
			mainPanel.Name = "mainPanel";
			mainPanel.Size = new Size(332, 228);
			mainPanel.TabIndex = 7;
			mainPanel.Paint += mainPanel_Paint;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(484, 261);
			Controls.Add(mainPanel);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBoxC);
			Controls.Add(textBoxB);
			Controls.Add(textBoxA);
			Controls.Add(button1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private TextBox textBoxA;
		private TextBox textBoxB;
		private TextBox textBoxC;
		private Label label1;
		private Label label2;
		private Label label3;
		private Panel mainPanel;
	}
}
