using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace PIDCofApp
{
	public partial class Form1 : Form
	{
		private TextBox textBoxP;
		private TextBox textBoxI;
		private TextBox textBoxD;
		private Button drawButton;

		private ZedGraphControl zgc;
		private GraphPane pane;

		public Form1()
		{
			InitializeComponent();
			this.Size = new Size(1000, 500);

			zgc = new ZedGraphControl
			{
				Location = new Point(12, 12),
				Size = new Size(832, 436)
			};
			Controls.Add(zgc);

			pane = zgc.GraphPane;

			textBoxP = new TextBox { Location = new Point(875, 15), Width = 100, Height = 20, Text = "" };
			textBoxI = new TextBox { Location = new Point(875, 40), Width = 100, Height = 20, Text = "" };
			textBoxD = new TextBox { Location = new Point(875, 67), Width = 100, Height = 20, Text = "" };
			drawButton = new Button { Location = new Point(872, 397), Width = 100, Height = 50, Text = "Draw" };

			drawButton.Click += new EventHandler(DrawButton_Click);

			Controls.Add(textBoxP);
			Controls.Add(textBoxI);
			Controls.Add(textBoxD);
			Controls.Add(drawButton);

			createGraph();
			zgc.AxisChange();
		}

		private void createGraph()
		{
			pane.Title.Text = "Graphic";
			pane.XAxis.Title.Text = "X";
			pane.YAxis.Title.Text = "Y";

			pane.XAxis.Scale.Min = -50;
			pane.XAxis.Scale.Max = 50;
			pane.YAxis.Scale.Min = -50;
			pane.YAxis.Scale.Max = 50;

			pane.XAxis.MajorGrid.IsVisible = true;
			pane.YAxis.MajorGrid.IsVisible = true;
		}

		private void DrawButton_Click(object sender, EventArgs e)
		{
			drawGraph();
		}

		private void drawGraph()
		{
			PointPairList sinPoints = new PointPairList();
			pane.CurveList.Clear();

			if (double.TryParse(textBoxP.Text, out double p) &&
				double.TryParse(textBoxI.Text, out double i) &&
				double.TryParse(textBoxD.Text, out double d))
			{
				for (double x = -10; x <= 100; x += 0.1)
				{
					double y = p * Math.Pow(x, 2) + i * x + d;
					sinPoints.Add(x, y);
				}

				LineItem sinCurve = pane.AddCurve("Parable", sinPoints, Color.Blue, SymbolType.None);
				sinCurve.Line.Width = 2;

				zgc.AxisChange();
				zgc.Invalidate();
			}
			else
			{
				MessageBox.Show("¬ведите корректные числовые значени€ в пол€ P, I и D.");
			}
		}
	}
}
