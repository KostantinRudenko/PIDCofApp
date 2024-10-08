namespace PIDCofApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.Paint += new PaintEventHandler(PaintParabola);
		}

		private void PaintParabola(object sender, PaintEventArgs e)
		{
			Pen pen = new Pen(Color.Black, 2);
			
			int num = 15;

			Point[] points = new Point[num*2+1];
			int centerX = this.ClientSize.Width/2;
			int centerY = this.ClientSize.Height;


			for (int x = -num; x <= num; x++)
			{
				int y = x * x;
				points[x + num] = new Point(centerX + x, centerY - y);
			}
			e.Graphics.DrawCurve(pen, points);

			pen.Dispose();
		}

	}
}
