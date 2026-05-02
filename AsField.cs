using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsole
{
	static class AsField
	{
		private static int _winWidth = 40;
		private static int _winHeight = 30;

		public static int GetWidth()
		{
			return _winWidth;
		}

		public static void SetWidth(int v)
		{
			_winWidth = v;
			Console.SetWindowSize(AsField._winWidth, AsField._winHeight);
			Console.SetBufferSize(AsField._winWidth, AsField._winHeight);
		}
	}
}
