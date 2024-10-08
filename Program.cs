using System.Runtime.CompilerServices;

namespace PIDCofApp
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			Application.Run(new Form1());
		}
	}
}