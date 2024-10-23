namespace PIDCofApp
{
	public partial class Form1 : Form
	{
		private int PointsN;
		private Pen pen;
		private Point[] points;


		public Form1()
		{
			PointsN = 40;
			points = new Point[PointsN+1];
			pen = new Pen(Color.Black, 2.0f);

			InitializeComponent();
			this.Paint += new PaintEventHandler(mainPanel_Paint);
		}

		private void button1_Click(object sender, EventArgs pe)
		{
			mainPanel.Invalidate();
		}

		private void mainPanel_Paint(object sender, PaintEventArgs e)
		{
		}
	}
}