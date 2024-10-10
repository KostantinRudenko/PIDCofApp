namespace PIDCofApp
{
	public partial class Form1 : Form
	{
		private int N = 40;
		private bool shouldDraw = false;
		private Point[] points;


		public Form1()
		{
			points = new Point[N+1];
			InitializeComponent();
			this.Paint += new PaintEventHandler(mainPanel_Paint);
		}

		private void button1_Click(object sender, EventArgs pe)
		{
			shouldDraw = true;
			mainPanel.Invalidate();
		}

		private void mainPanel_Paint(object sender, PaintEventArgs e)
		{
			if (shouldDraw)
			{
				int xRange = N / 2;

				string strA, strB, strC;
				strA = textBoxA.Text;
				strB = textBoxB.Text;
				strC = textBoxC.Text;

				if (strA != "" &&
					strB != "" &&
					strC != "")
				{

					int a = int.Parse(strA);
					int b = int.Parse(strB);
					int c = int.Parse(strC);

					for (int x = -xRange; x <= xRange; x++)
					{
						int y = a * x * x + b * x + c;
						points[x + xRange] = new Point(
							x + mainPanel.Width / 2,
							mainPanel.Height - y);
					}
				}

				Pen pen = new Pen(Color.Black, 2);
				using (Graphics g = mainPanel.CreateGraphics())
				{
					g.DrawCurve(pen, points);
				}
				pen.Dispose();
			}
		}
	}
}