using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsole
{
	class APoint
	{
		public int X { get; set; }
		public int Y;

		public APoint() {}

		public APoint(int _x, int _y) {

			X = _x;
			Y = _y;
		}

		public APoint(APoint p) {

			X = p.X;
			Y = p.Y;
		}


		public void Draw()
		{
			DrawerProvider.Drawer.DrawPoint(X, Y);
		}


		public void Clear()
		{
			DrawerProvider.Drawer.ClearPoint(X, Y);
		}


		public void Move(EDirection dir)
		{
			switch (dir) {

				case EDirection.Up:
					Y -= 1;
					break;

				case EDirection.Down:
					Y += 1;
					break;

				case EDirection.Left:
					X -= 1;
					break;

				case EDirection.Right:
					X += 1;
					break;

			}
		}
	}
}
