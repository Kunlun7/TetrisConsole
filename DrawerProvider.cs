using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsole
{
	static class DrawerProvider
	{
		private static IDrawer _drawer = new AConsoleDrawer();

		public static IDrawer Drawer
		{
			get
			{
				return _drawer;
			}
		}
	}
}
