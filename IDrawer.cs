using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsole
{
	interface IDrawer
	{
		void DrawPoint(int x, int y);
		void ClearPoint(int x, int y);
		void WriteGameOver();
		void InitField();
	}
}
