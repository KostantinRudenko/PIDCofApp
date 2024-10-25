using ZedGraph;

namespace PIDCofApp
{
	public partial class Form1 : Form
	{
		private ZedGraphControl zgc;
		private GraphPane pane;


		public Form1()
		{
			zgc = new ZedGraphControl();
			zgc.Dock = DockStyle.Fill;
			Controls.Add(zgc);

			pane = zgc.GraphPane;

			createGraph();
			drawSin();

			zgc.AxisChange();
		}

		private void createGraph()
		{
			pane.Title.Text = "Graphic";
			pane.XAxis.Title.Text = "X";
			pane.YAxis.Title.Text = "Y";

			pane.XAxis.Scale.Min = 0;
			pane.XAxis.Scale.Max = 100;
			pane.YAxis.Scale.Min = -100;
			pane.YAxis.Scale.Max = 100;

			pane.XAxis.MajorGrid.IsVisible = true;
			pane.YAxis.MajorGrid.IsVisible = true;

		}

		private void drawSin()
		{
			PointPairList sinPoints = new PointPairList();
			for (double x = -10; x <= 100; x += 0.1)
			{
				double y = Math.Sin(x)*5;
				sinPoints.Add(x, y);
			}

			LineItem sinCurve = pane.AddCurve("Sin(x)", sinPoints, System.Drawing.Color.Blue, SymbolType.None);
			sinCurve.Line.Width = 2;
		}
	}
}